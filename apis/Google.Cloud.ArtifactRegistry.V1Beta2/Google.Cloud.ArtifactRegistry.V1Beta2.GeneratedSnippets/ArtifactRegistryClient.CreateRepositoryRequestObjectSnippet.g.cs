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

namespace Google.Cloud.ArtifactRegistry.V1Beta2.Snippets
{
    // [START artifactregistry_v1beta2_generated_ArtifactRegistry_CreateRepository_sync]
    using Google.Api.Gax.ResourceNames;
    using Google.Cloud.ArtifactRegistry.V1Beta2;
    using Google.LongRunning;

    public sealed partial class GeneratedArtifactRegistryClientSnippets
    {
        /// <summary>Snippet for CreateRepository</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateRepositoryRequestObject()
        {
            // Create client
            ArtifactRegistryClient artifactRegistryClient = ArtifactRegistryClient.Create();
            // Initialize request argument(s)
            CreateRepositoryRequest request = new CreateRepositoryRequest
            {
                ParentAsLocationName = LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                RepositoryId = "",
                Repository = new Repository(),
            };
            // Make the request
            Operation<Repository, OperationMetadata> response = artifactRegistryClient.CreateRepository(request);

            // Poll until the returned long-running operation is complete
            Operation<Repository, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Repository result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Repository, OperationMetadata> retrievedResponse = artifactRegistryClient.PollOnceCreateRepository(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Repository retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END artifactregistry_v1beta2_generated_ArtifactRegistry_CreateRepository_sync]
}