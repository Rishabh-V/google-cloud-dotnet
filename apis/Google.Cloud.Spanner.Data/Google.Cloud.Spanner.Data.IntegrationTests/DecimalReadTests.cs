﻿// Copyright 2022 Google LLC
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

using Google.Cloud.Spanner.V1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    [Collection(nameof(DecimalTableFixture))]
    public class DecimalReadTests
    {
        private readonly DecimalTableFixture _fixture;

        public DecimalReadTests(DecimalTableFixture fixture) =>
            _fixture = fixture;

        public static IEnumerable<object[]> TestDecimals =>
            new List<object[]>
            {
                new object[] { new decimal(1.23456789) },
                new object[] { decimal.MinusOne },
                new object[] { decimal.Zero },
                new object[] { new decimal(123456789.0123456789012345678) },
            };

        public static IEnumerable<object[]> TestDecimalsWithNumeric =>
            new List<object[]>
            {
                new object[] { new decimal(1.23456789) },
                new object[] { decimal.MaxValue },
                new object[] { decimal.MinValue },
                new object[] { decimal.MinusOne },
                new object[] { decimal.Zero },
                new object[] { new decimal(123456789.0123456789012345678) },
            };

        [Theory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteThenRead_ShouldBeEqual(decimal expectedValue)
        {
            using var connection = _fixture.GetConnection();
            // Write the decimal value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                        new SpannerParameter("DecimalValue", SpannerDbType.Float64, expectedValue),
                }
            ).ExecuteNonQueryAsync();
            var decimalValue = await connection.CreateSelectCommand($"SELECT DecimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<decimal>();
            Assert.Equal(expectedValue, decimalValue);
        }

        [Theory]
        [MemberData(nameof(TestDecimals))]
        public async Task WriteThenRead_ShouldBeEqual_UseOptions(decimal expectedValue)
        {
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UseSpannerNumericForDecimal=true");
            // Write the decimal value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                        new SpannerParameter("DecimalValue", SpannerDbType.Float64, expectedValue),
                }
            ).ExecuteNonQueryAsync();
            var numericValue = await connection.CreateSelectCommand($"SELECT DecimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<SpannerNumeric>();
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), numericValue);
            // Explicitly test the scenario in which CLR Type is not specified.
            var value = await connection.CreateSelectCommand($"SELECT DecimalValue FROM {_fixture.TableName}").ExecuteScalarAsync<object>();
            Assert.True(value is SpannerNumeric);
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), (SpannerNumeric)value);
        }

        [Theory]
        [MemberData(nameof(TestDecimalsWithNumeric))]
        public async Task WriteThenRead_ShouldBeEqual_WithNumericColumn(decimal expectedValue)
        {
            using var connection = _fixture.GetConnection();
            // Write the decimal value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                        new SpannerParameter("NumericValue", SpannerDbType.Float64, expectedValue),
                }
            ).ExecuteNonQueryAsync();
            var decimalValue = await connection.CreateSelectCommand($"SELECT NumericValue FROM {_fixture.TableName}").ExecuteScalarAsync<decimal>();
            Assert.Equal(expectedValue, decimalValue);
        }

        [Theory]
        [MemberData(nameof(TestDecimalsWithNumeric))]
        public async Task WriteThenRead_ShouldBeEqual_UseOptions_WithNumericColumn(decimal expectedValue)
        {
            using var connection = new SpannerConnection($"{_fixture.ConnectionString};UseSpannerNumericForDecimal=true");
            // Write the decimal value and read it back.
            await connection.CreateInsertOrUpdateCommand(_fixture.TableName,
                new SpannerParameterCollection
                {
                        new SpannerParameter("NumericValue", SpannerDbType.Float64, expectedValue),
                }
            ).ExecuteNonQueryAsync();
            var numericValue = await connection.CreateSelectCommand($"SELECT NumericValue FROM {_fixture.TableName}").ExecuteScalarAsync<SpannerNumeric>();
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), numericValue);
            // Explicitly test the scenario in which CLR Type is not specified.
            var value = await connection.CreateSelectCommand($"SELECT NumericValue FROM {_fixture.TableName}").ExecuteScalarAsync<object>();
            Assert.True(value is SpannerNumeric);
            Assert.Equal(SpannerNumeric.FromDecimal(expectedValue, LossOfPrecisionHandling.Truncate), (SpannerNumeric)value);
        }
    }
}
