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

namespace Google.Maps.AddressValidation.V1.Snippets
{
    // [START addressvalidation_v1_generated_AddressValidation_ValidateAddress_sync]
    using Google.Maps.AddressValidation.V1;
    using Google.Type;

    public sealed partial class GeneratedAddressValidationClientSnippets
    {
        /// <summary>Snippet for ValidateAddress</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ValidateAddressRequestObject()
        {
            // Create client
            AddressValidationClient addressValidationClient = AddressValidationClient.Create();
            // Initialize request argument(s)
            ValidateAddressRequest request = new ValidateAddressRequest
            {
                Address = new PostalAddress(),
                PreviousResponseId = "",
                EnableUspsCass = false,
            };
            // Make the request
            ValidateAddressResponse response = addressValidationClient.ValidateAddress(request);
        }
    }
    // [END addressvalidation_v1_generated_AddressValidation_ValidateAddress_sync]
}