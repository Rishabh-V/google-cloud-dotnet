// Copyright 2018 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace Google.Cloud.Spanner.Data
{
    /// <summary>
    /// Options for nuances in conversions between protobuf and CLR types.
    /// </summary>
    internal class SpannerConversionOptions
    {
        internal static SpannerConversionOptions Default { get; } = new SpannerConversionOptions(true, default, default);

        /// <summary>
        /// True to return DBNull.Value for null values; false to return a null reference.
        /// </summary>
        internal bool UseDBNull { get; }

        internal ConcurrentDictionary<System.Type, SpannerDbType> ClrToSpannerTypeMappings { get; }

        internal ConcurrentDictionary<SpannerDbType, System.Type> SpannerToClrTypeMappings { get; }

        private SpannerConversionOptions(bool useDBNull,
            IDictionary<System.Type, SpannerDbType> defaultClrToSpannerMappings,
            IDictionary<SpannerDbType, System.Type> defaultSpannerToClrMappings)
        {
            UseDBNull = useDBNull;
            ClrToSpannerTypeMappings = (ConcurrentDictionary<System.Type, SpannerDbType>)(defaultClrToSpannerMappings ?? new ConcurrentDictionary<System.Type, SpannerDbType>
            {
                [typeof(decimal)] = SpannerDbType.Float64,
                [typeof(DateTime)] = SpannerDbType.Timestamp
            });

            SpannerToClrTypeMappings = (ConcurrentDictionary<SpannerDbType, System.Type>)(defaultSpannerToClrMappings ?? new ConcurrentDictionary<SpannerDbType, System.Type>
            {
                [SpannerDbType.Float64] = typeof(double),
                [SpannerDbType.Date] = typeof(DateTime)
            });
        }

        /// <summary>
        /// Determines the right conversion options to use based on the connection string of the given connection.
        /// </summary>
        internal static SpannerConversionOptions ForConnection(SpannerConnection spannerConnection) =>
            ForConnectionStringBuilder(spannerConnection?.Builder);

        /// <summary>
        /// Determines the right conversion options to use based on the connection string of the given connection string builder.
        /// </summary>
        internal static SpannerConversionOptions ForConnectionStringBuilder(SpannerConnectionStringBuilder builder) =>
            builder == null ? Default :
            new SpannerConversionOptions(!builder.UseClrDefaultForNull, builder.ClrToSpannerTypeMappings, builder.SpannerToClrTypeMappings);

        internal SpannerDbType ConfiguredSpannerTypeForDecimal() => ConfiguredSpannerDbType(typeof(decimal)) ?? SpannerDbType.Float64;

        internal SpannerDbType ConfiguredSpannerTypeForDateTime() => ConfiguredSpannerDbType(typeof(DateTime)) ?? SpannerDbType.Timestamp;

        private SpannerDbType ConfiguredSpannerDbType(System.Type type)
        {
            if (ClrToSpannerTypeMappings.TryGetValue(type, out var spannerDbType))
            {
                return spannerDbType;
            }

            return default;
        }

        internal System.Type ConfiguredClrTypeForDate() => ConfiguredClrType(SpannerDbType.Date) ?? typeof(DateTime);

        internal System.Type ConfiguredClrTypeForFloat64() => ConfiguredClrType(SpannerDbType.Float64) ?? typeof(double);

        private System.Type ConfiguredClrType(SpannerDbType dbType)
        {
            if (SpannerToClrTypeMappings.TryGetValue(dbType, out var clrType))
            {
                return clrType;
            }

            return default;
        }
    }
}
