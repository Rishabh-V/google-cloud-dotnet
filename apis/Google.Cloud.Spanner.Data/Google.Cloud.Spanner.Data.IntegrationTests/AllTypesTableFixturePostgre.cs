// Copyright 2022 Google LLC
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

using Google.Cloud.Spanner.Data.CommonTesting;
using Xunit;

namespace Google.Cloud.Spanner.Data.IntegrationTests
{
    /// <summary>
    /// A table fixture that covers all Spanner PostgreSQL types. The fixture doesn't populate any data,
    /// but tests should not depend on the table being empty as other tests may modify it.
    /// </summary>
    [CollectionDefinition(nameof(AllTypesTableFixturePostgre))]
    public class AllTypesTableFixturePostgre : SpannerTableFixturePostgre, ICollectionFixture<AllTypesTableFixturePostgre>
    {
        public AllTypesTableFixturePostgre() : base("TypesTable")
        {
        }

        /// <summary>
        /// Creates INSERT command for the table created after executing the <see cref="CreateTable"/> method execution.
        /// </summary>
        /// <returns>The DML command to insert data into a table.</returns>
        public string CreateInsertCommand() =>
            $@"INSERT {TableName} (
                 k,
                 boolvalue,
                 bigintvalue,
                 stringvalue,
                 numericvalue,
                 datevalue,
                 timestampvalue,
                 boolarrayvalue,
                 bigintarrayvalue,
                 numericarrayvalue,
                 stringarrayvalue,
                 bytesarrayvalue,
                 datearrayvalue,                            
                 timestamparrayvalue) VALUES(
                 @K,
                 @BoolValue,
                 @BigIntValue,
                 @StringValue,
                 @NumericValue,
                 @DateValue,
                 @TimestampValue,
                 @BoolArrayValue,
                 @BigIntArrayValue,
                 @NumericArrayValue,
                 @StringArrayValue,
                 @BytesArrayValue,                 
                 @DateArrayValue,
                 @TimestampArrayValue
               )";

        protected override void CreateTable() =>
            ExecuteDdl($@"CREATE TABLE {TableName}(
                            k character varying NOT NULL,
                            boolvalue boolean,
                            bigintvalue bigint,
                            stringvalue character varying,
                            numericvalue numeric,
                            datevalue date,
                            timestampvalue timestamptz,
                            boolarrayvalue boolean[],
                            bigintarrayvalue bigint[],
                            numericarrayvalue numeric[],
                            stringarrayvalue character varying[],
                            bytesarrayvalue bytea,
                            datearrayvalue date[],                            
                            timestamparrayvalue timestamptz[],
                            PRIMARY KEY(k));");

        private string EmptyOnEmulator(string text) => RunningOnEmulator ? "" : text;
    }
}
