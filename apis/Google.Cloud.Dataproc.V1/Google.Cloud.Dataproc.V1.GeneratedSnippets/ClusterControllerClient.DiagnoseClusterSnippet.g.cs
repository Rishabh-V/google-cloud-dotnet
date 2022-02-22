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

namespace Google.Cloud.Dataproc.V1.Snippets
{
    // [START dataproc_v1_generated_ClusterController_DiagnoseCluster_sync_flattened]
    using Google.Cloud.Dataproc.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedClusterControllerClientSnippets
    {
        /// <summary>Snippet for DiagnoseCluster</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DiagnoseCluster()
        {
            // Create client
            ClusterControllerClient clusterControllerClient = ClusterControllerClient.Create();
            // Initialize request argument(s)
            string projectId = "";
            string region = "";
            string clusterName = "";
            // Make the request
            Operation<DiagnoseClusterResults, ClusterOperationMetadata> response = clusterControllerClient.DiagnoseCluster(projectId, region, clusterName);

            // Poll until the returned long-running operation is complete
            Operation<DiagnoseClusterResults, ClusterOperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            DiagnoseClusterResults result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<DiagnoseClusterResults, ClusterOperationMetadata> retrievedResponse = clusterControllerClient.PollOnceDiagnoseCluster(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                DiagnoseClusterResults retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END dataproc_v1_generated_ClusterController_DiagnoseCluster_sync_flattened]
}