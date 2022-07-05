// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax.Grpc;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Cloud.PubSub.V1
{
    internal static class Extensions
    {
        internal static void Locked<TLock>(this TLock o, Action action) where TLock : class
        {
            lock (o)
            {
                action();
            }
        }

        internal static T Locked<TLock, T>(this TLock o, Func<T> fn) where TLock : class
        {
            lock (o)
            {
                return fn();
            }
        }

        internal static void EnqueueAll<T>(this Queue<T> queue, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                queue.Enqueue(item);
            }
        }

        internal static void Dequeue<T>(this Queue<T> queue, int count)
        {
            for (int i = 0; i < count; i++)
            {
                queue.Dequeue();
            }
        }

        internal static bool Is<T>(this Exception e) where T : Exception =>
            e is T || (e is AggregateException ae && ae.Flatten().InnerException is T);

        internal static bool IsCancellation(this Exception e) => e.Is<OperationCanceledException>();

        internal static T As<T>(this Exception e) where T : Exception =>
            (e as T) ?? ((e as AggregateException)?.Flatten()?.InnerException as T);

        internal static bool IsRpcCancellation(this Exception e) => e.As<RpcException>()?.Status.StatusCode == StatusCode.Cancelled;

        internal static IEnumerable<Exception> AllExceptions(this Exception e) =>
            (IEnumerable<Exception>)(e as AggregateException)?.Flatten().InnerExceptions ?? new[] { e };

        internal static Exception FlattenIfPossible(this Exception e)
        {
            var exs = e.AllExceptions().ToList();
            return exs.Count == 1 ? exs[0] : new AggregateException(exs);
        }

        internal static AckError GetAckError(this RpcException e)
        {
            // Check the gRPC status code for temporary errors that should be retried for all ackIds.            
            bool retryAll = e.ShouldRetryAll();
            if (!retryAll)
            {
                // We could have partial failure or complete failure. We classify the error as temporary of permanent
                // based on the error starting from TRANSIENT_FAILURE_ or PERMANENT_FAILURE_ and return
                // the temporary errors that needs to be retried in temporaryErrors and
                // the permanent errors that needs to be discarded or logged in permanentErrors.
                // TODO: Contains with ComparisionType isn't available in NET462. Do we need case insensitive check here?
                var temporaryErrors = e.GetErrorInfo()?.Metadata.Where(j => j.Value.Contains("TRANSIENT_FAILURE_")) ?? Enumerable.Empty<KeyValuePair<string, string>>();
                var permanentErrors = e.GetErrorInfo()?.Metadata.Where(j => j.Value.Contains("PERMANENT_FAILURE_")) ?? Enumerable.Empty<KeyValuePair<string, string>>();
                return new AckError(retryAll, temporaryErrors, permanentErrors);
            }

            // Return just the flag as true and empty temporary and permanent failures, so that caller can retry the whole batch.
            return new AckError(retryAll, Enumerable.Empty<KeyValuePair<string, string>>(), Enumerable.Empty<KeyValuePair<string, string>>());
        }

        internal static bool ShouldRetryAll(this RpcException e) => e.Status.StatusCode switch
        {
            StatusCode.DeadlineExceeded => true,
            StatusCode.ResourceExhausted => true,
            StatusCode.Aborted => true,
            StatusCode.Internal => true,
            StatusCode.Unavailable => true,
            _ => false,
        };


        internal static bool IsRecoverable(this RpcException e)
        {
            switch (e.Status.StatusCode)
            {
                case StatusCode.Aborted:
                case StatusCode.Cancelled:
                case StatusCode.DeadlineExceeded:
                case StatusCode.Internal:
                case StatusCode.ResourceExhausted:
                case StatusCode.Unknown:
                case StatusCode.Unavailable:
                    return true;
                default:
                    return false;
            }
        }
    }

    // TODO: Move to a new file.
    internal class AckError
    {
        /// <summary>
        /// True if there are any temporary failures to retry else false if all the failures are permanent.
        /// </summary>
        internal bool HasTemporaryErrors => TemporaryFailureIds.Any();

        /// <summary>
        /// True if all AckIds/ExtendIds/NackIds must be retried, else false if only the AckIds/ExtendIds/NackIds
        /// available in temporary failuers must be retried.
        /// </summary>
        internal bool RetryAll { get; }

        /// <summary>
        /// Gets the AckIds/ExtendIds/NackIds with temporary failures.
        /// This collection will be populated with AckIds/ExtendIds/NackIds only if error is temporary and <see cref="RetryAll"/> is false,
        /// else this collection will be empty (but not null).
        /// </summary>
        /// <remarks>
        /// If <see cref="RetryAll"/> is true, it means that all the AckIds/ExtendIds/NackIds must be retried. In that case, this collection will be empty.
        /// If <see cref="RetryAll"/> is false, and this collection is empty, it means that all the failures are permanent failures,
        /// since <see cref="AckError"/> class comes into picture only in case of error.
        /// </remarks>
        internal IEnumerable<string> TemporaryFailureIds => TemporaryFailures.Select(kvp => kvp.Key);

        /// <summary>
        /// Gets the temporary failures.
        /// This collection will be populated with AckId/NackId/ExtentendId with corresponding error only if error is temporary and <see cref="RetryAll"/> is false,
        /// else this collection will be empty (but not null).
        /// </summary>
        /// <remarks>
        /// If <see cref="RetryAll"/> is true, it means that all the errors must be retried. In that case, this collection will be empty.
        /// If <see cref="RetryAll"/> is false, and this collection is empty, it means that all the failures are permanent failures,
        /// since <see cref="AckError"/> class comes into picture only in case of error.
        /// </remarks>
        internal IEnumerable<KeyValuePair<string, string>> TemporaryFailures { get; }

        /// <summary>
        /// Gets the AckIds/ExtendIds/NackIds with permanent failures.
        /// This collection will be populated with AckIds/ExtendIds/NackIds only if error is permanent,
        /// else this collection will be empty (but not null).
        /// </summary>
        /// <remarks>
        /// If <see cref="RetryAll"/> is true, it means that all the AckIds/ExtendIds/NackIds must be retried. In that case, this collection will be empty.
        /// If <see cref="RetryAll"/> is false, and this collection is empty, it means that all the failures are temporary failures,
        /// since <see cref="AckError"/> class comes into picture only in case of error.
        /// </remarks>
        internal IEnumerable<string> PermanentFailureIds => PermanentFailures.Select(kvp => kvp.Key);

        /// <summary>
        /// Gets the permanent failures.
        /// This collection will be populated AckId/NackId/ExtentendId with corresponding error only if the failure is permanent,
        /// else this collection will be empty (but not null).
        /// </summary>
        /// <remarks>
        /// If <see cref="RetryAll"/> is true, it means that all the errors must be retried. In that case, this collection will be empty.
        /// If <see cref="RetryAll"/> is false, and this collection is empty, it means that all the failures are temporary failures,
        /// since <see cref="AckError"/> class comes into picture only in case of error.
        /// </remarks>
        internal IEnumerable<KeyValuePair<string, string>> PermanentFailures { get; }

        internal AckError(bool retryAll, IEnumerable<KeyValuePair<string, string>> temporaryFailures, IEnumerable<KeyValuePair<string, string>> permanentFailures)
        {
            RetryAll = retryAll;
            TemporaryFailures = temporaryFailures;
            PermanentFailures = permanentFailures;
        }
    }
}
