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

using Xunit;

namespace Google.Cloud.Storage.V1.Tests.Conformance
{
    //[Collection(nameof(RetryConformanceFixture))]
    public class RetryConformanceTest
    {
        //private readonly RetryConformanceFixture _fixture;

        //public RetryConformanceTest(RetryConformanceFixture fixture) => _fixture = fixture;

        public static TheoryData<RetryTest> RetryTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.RetryTests);

        [Theory, MemberData(nameof(RetryTestData))]
        public void RetryTest(RetryTest test)
        {
            var id = test.Id;
            var description = test.Description;
            var expectSuccess = test.ExpectSuccess;
            var preconditionProvided = test.PreconditionProvided;
            var methods = test.Methods;

            foreach (var item in test.Cases)
            {
                foreach (var method in methods)
                {


                }
            }
        }
    }
}
