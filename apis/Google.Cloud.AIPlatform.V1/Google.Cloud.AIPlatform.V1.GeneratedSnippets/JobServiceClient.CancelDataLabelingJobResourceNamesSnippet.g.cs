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

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    // [START aiplatform_v1_generated_JobService_CancelDataLabelingJob_sync_flattened_resourceNames]
    using Google.Cloud.AIPlatform.V1;

    public sealed partial class GeneratedJobServiceClientSnippets
    {
        /// <summary>Snippet for CancelDataLabelingJob</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CancelDataLabelingJobResourceNames()
        {
            // Create client
            JobServiceClient jobServiceClient = JobServiceClient.Create();
            // Initialize request argument(s)
            DataLabelingJobName name = DataLabelingJobName.FromProjectLocationDataLabelingJob("[PROJECT]", "[LOCATION]", "[DATA_LABELING_JOB]");
            // Make the request
            jobServiceClient.CancelDataLabelingJob(name);
        }
    }
    // [END aiplatform_v1_generated_JobService_CancelDataLabelingJob_sync_flattened_resourceNames]
}