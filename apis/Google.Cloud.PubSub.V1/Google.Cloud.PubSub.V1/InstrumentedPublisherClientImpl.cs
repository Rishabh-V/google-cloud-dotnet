// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.
using Google.Protobuf;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Google.Cloud.PubSub.V1;

/// <summary>
/// The instrumented publisher client for Google Cloud Pub/Sub.
/// </summary>
public sealed class InstrumentedPublisherClientImpl : PublisherClient
{
    private static readonly ActivitySource ActivitySource = new ActivitySource("Google.Cloud.PubSub.V1", "3.3.0.0");
    
    private readonly PublisherClientImpl _impl;

    /// <inheritdoc/>
    public override TopicName TopicName => _impl.TopicName;

    /// <summary>
    /// Initialize a new instance of <see cref="InstrumentedPublisherClientImpl"/> class.
    /// </summary>
    /// <param name="client">The PublisherClient.</param>
    public InstrumentedPublisherClientImpl(PublisherClientImpl client) => _impl = client;

    /// <inheritdoc/>
    public override Task<string> PublishAsync(PubsubMessage message)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(message), message);
        return _impl.PublishAsync(message);
    }

    /// <inheritdoc/>
    public override Task<string> PublishAsync(string orderingKey, string message, System.Text.Encoding encoding = null)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(orderingKey), orderingKey);
        _ = activity?.SetTag(nameof(message), message);
        _ = activity?.SetTag(nameof(encoding), encoding);
        return _impl.PublishAsync(orderingKey, message, encoding);
    }

    /// <inheritdoc/>
    public override Task<string> PublishAsync(string message, System.Text.Encoding encoding = null)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(message), message);
        _ = activity?.SetTag(nameof(encoding), encoding);
        return _impl.PublishAsync(message, encoding);
    }

    /// <inheritdoc/>
    public override Task<string> PublishAsync(string orderingKey, IMessage message)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(orderingKey), orderingKey);
        _ = activity?.SetTag(nameof(message), message);
        return _impl.PublishAsync(orderingKey, message);
    }

    /// <inheritdoc/>
    public override Task<string> PublishAsync(IMessage message)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(message), message);
        return _impl.PublishAsync(message);
    }

    /// <inheritdoc/>
    public override Task<string> PublishAsync(string orderingKey, ByteString message)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(orderingKey), orderingKey);
        _ = activity?.SetTag(nameof(message), message);
        return _impl.PublishAsync(orderingKey, message);
    }

    /// <inheritdoc/>
    public override Task<string> PublishAsync(ByteString message)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(message), message);
        return _impl.PublishAsync(message);
    }

    /// <inheritdoc/>
    public override Task<string> PublishAsync(string orderingKey, byte[] message)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(orderingKey), orderingKey);
        _ = activity?.SetTag(nameof(message), message);
        return _impl.PublishAsync(orderingKey, message);
    }

    /// <inheritdoc/>
    public override Task<string> PublishAsync(byte[] message)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(message), message);
        return _impl.PublishAsync(message);
    }

    /// <inheritdoc/>
    public override void ResumePublish(string orderingKey)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(orderingKey), orderingKey);
        _impl.ResumePublish(orderingKey);
    }

    /// <inheritdoc/>
    public override Task ShutdownAsync(CancellationToken hardStopToken)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(hardStopToken), hardStopToken);
        return _impl.ShutdownAsync(hardStopToken);
    }

    /// <inheritdoc/>
    public override Task ShutdownAsync(TimeSpan timeout)
    {
        using var activity = ActivitySource.StartActivity();
        _ = activity?.SetTag(nameof(timeout), timeout);
        return _impl.ShutdownAsync(timeout);
    }
}
