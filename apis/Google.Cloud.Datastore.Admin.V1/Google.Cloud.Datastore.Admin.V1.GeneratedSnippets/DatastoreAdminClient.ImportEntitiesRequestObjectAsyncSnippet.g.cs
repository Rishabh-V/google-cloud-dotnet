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

namespace Google.Cloud.Datastore.Admin.V1.Snippets
{
    // [START datastore_v1_generated_DatastoreAdmin_ImportEntities_async]
    using Google.Cloud.Datastore.Admin.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDatastoreAdminClientSnippets
    {
        /// <summary>Snippet for ImportEntitiesAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ImportEntitiesRequestObjectAsync()
        {
            // Create client
            DatastoreAdminClient datastoreAdminClient = await DatastoreAdminClient.CreateAsync();
            // Initialize request argument(s)
            ImportEntitiesRequest request = new ImportEntitiesRequest
            {
                ProjectId = "",
                Labels = { { "", "" }, },
                InputUrl = "",
                EntityFilter = new EntityFilter(),
            };
            // Make the request
            Operation<Empty, ImportEntitiesMetadata> response = await datastoreAdminClient.ImportEntitiesAsync(request);

            // Poll until the returned long-running operation is complete
            Operation<Empty, ImportEntitiesMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, ImportEntitiesMetadata> retrievedResponse = await datastoreAdminClient.PollOnceImportEntitiesAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END datastore_v1_generated_DatastoreAdmin_ImportEntities_async]
}