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

using Google.Cloud.Storage.V1.Tests.Conformance;
using Google.Protobuf.Collections;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V1.RetryConformanceTests
{
    public class RetryConformanceTest
    {
        public static TheoryData<RetryTest> RetryTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.RetryTests);

        public static string TestBenchUrl { get; } = GetEnvironmentVariableOrDefault("TEST_BENCH_URL", "https://storage-testbench-vkcain7hhq-el.a.run.app/");

        [Theory, MemberData(nameof(RetryTestData))]
        public async Task RetryTest(RetryTest test)
        {
            int index = 0;
            foreach (InstructionList testCase in test.Cases)
            {
                foreach (Method method in test.Methods)
                {
                    await RunTestCase(test, testCase, method, index);
                }
            }
        }

        private async Task RunTestCase(RetryTest test, InstructionList testCase, Method method, int index)
        {
            var clientBuilder = new StorageClientBuilder
            {
                BaseUri = TestBenchUrl + "retry_test"
            };

            // Create client and set headers.
            var client = await clientBuilder.BuildAsync();

            // Create a dictionary which maps method names and index with the Storage client delegate to be called.
            CreateMethodMapping(client, method, index);

            // Create retry test resource
            HttpResponseMessage response = await CreateRetryTestResource(test, method, testCase.Instructions);
            
            // Read Id from response headers.
            var id = GetIdFromResponse(response); 
            bool expectSuccess = test.ExpectSuccess;
            bool success = true;
            try
            {
                RunRetryTest(id, test.PreconditionProvided, method.Resources);
            }
            catch (System.Exception)
            {
                // Log exception to check the tests?
                success = false;
            }

            Assert.Equal(expectSuccess, success);

            HttpResponseMessage responseMessage = GetRetryTest(id);
            var content = await responseMessage.Content.ReadAsStringAsync();
            
            // Assert that instructions are done.
        }

        private string GetIdFromResponse(HttpResponseMessage response)
        {
            throw new NotImplementedException();
        }

        private void CreateMethodMapping(StorageClient client, Method method, int index)
        {
            throw new NotImplementedException();
        }

        private HttpResponseMessage GetRetryTest(string id)
        {
            throw new System.NotImplementedException();
        }

        private void RunRetryTest(string id, bool preconditionProvided, RepeatedField<Resource> resources)
        {
            
        }

        private async Task<HttpResponseMessage> CreateRetryTestResource(RetryTest test, Method method, RepeatedField<string> instructions)
        {
            // method.resources specifies the resources needed by the test. Create the resource for each scenario.

            // Use method mapping to call the StorageTestBench API.
            return await Task.FromResult<HttpResponseMessage>(default);
        }

        private static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
        {
            string value = Environment.GetEnvironmentVariable(name);
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }
    }
}
