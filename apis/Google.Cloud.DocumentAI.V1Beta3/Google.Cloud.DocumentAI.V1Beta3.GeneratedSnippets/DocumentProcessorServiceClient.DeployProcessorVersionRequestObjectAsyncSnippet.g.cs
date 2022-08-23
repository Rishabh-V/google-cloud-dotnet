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

// Generated code. DO NOT EDIT!

namespace Google.Cloud.DocumentAI.V1Beta3.Snippets
{
    // [START documentai_v1beta3_generated_DocumentProcessorService_DeployProcessorVersion_async]
    using Google.Cloud.DocumentAI.V1Beta3;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDocumentProcessorServiceClientSnippets
    {
        /// <summary>Snippet for DeployProcessorVersionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task DeployProcessorVersionRequestObjectAsync()
        {
            // Create client
            DocumentProcessorServiceClient documentProcessorServiceClient = await DocumentProcessorServiceClient.CreateAsync();
            // Initialize request argument(s)
            DeployProcessorVersionRequest request = new DeployProcessorVersionRequest
            {
                ProcessorVersionName = ProcessorVersionName.FromProjectLocationProcessorProcessorVersion("[PROJECT]", "[LOCATION]", "[PROCESSOR]", "[PROCESSOR_VERSION]"),
            };
            // Make the request
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> response = await documentProcessorServiceClient.DeployProcessorVersionAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            DeployProcessorVersionResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> retrievedResponse = await documentProcessorServiceClient.PollOnceDeployProcessorVersionAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DeployProcessorVersionResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END documentai_v1beta3_generated_DocumentProcessorService_DeployProcessorVersion_async]
}