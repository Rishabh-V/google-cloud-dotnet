// Copyright 2023 Google LLC
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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.DiscoveryEngine.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/models/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/schemas/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/targetSites/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/engines/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/branches/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/models/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/operations/*}" }, { "get": "/v1/{name=projects/*/locations/*/operations/*}" }, { "get": "/v1/{name=projects/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EiIvdjEve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9WlYSVC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL2JyYW5jaGVzLyovb3BlcmF0aW9ucy8qfVpUElIvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9tb2RlbHMvKi9vcGVyYXRpb25zLyp9WksSSS92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL29wZXJhdGlvbnMvKn1aVRJTL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2NoZW1hcy8qL29wZXJhdGlvbnMvKn1aXBJaL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyovc2l0ZVNlYXJjaEVuZ2luZS9vcGVyYXRpb25zLyp9WmgSZi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL3NpdGVTZWFyY2hFbmdpbmUvdGFyZ2V0U2l0ZXMvb3BlcmF0aW9ucy8qfVpIEkYvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2VuZ2luZXMvKi9vcGVyYXRpb25zLyp9Wj4SPC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovb3BlcmF0aW9ucy8qfVpIEkYvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kYXRhU3RvcmVzLyovYnJhbmNoZXMvKi9vcGVyYXRpb25zLyp9WkYSRC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKi9tb2RlbHMvKi9vcGVyYXRpb25zLyp9Wj0SOy92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2RhdGFTdG9yZXMvKi9vcGVyYXRpb25zLyp9WjASLi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn1aJBIiL3YxL3tuYW1lPXByb2plY3RzLyovb3BlcmF0aW9ucy8qfQ==")
                },
                {
                    "google.longrunning.Operations.ListOperations",
                    // { "get": "/v1/{name=projects/*}/operations", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/branches/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/models/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/schemas/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine/targetSites}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*/siteSearchEngine}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/dataStores/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*/engines/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/collections/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/branches/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*/models/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*/dataStores/*}/operations" }, { "get": "/v1/{name=projects/*/locations/*}/operations" }, { "get": "/v1/{name=projects/*}/operations" } ] }
                    proto::ByteString.FromBase64("EiAvdjEve25hbWU9cHJvamVjdHMvKn0vb3BlcmF0aW9uc1pUElIvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9icmFuY2hlcy8qfS9vcGVyYXRpb25zWlISUC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL21vZGVscy8qfS9vcGVyYXRpb25zWlMSUS92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL3NjaGVtYXMvKn0vb3BlcmF0aW9uc1pmEmQvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9jb2xsZWN0aW9ucy8qL2RhdGFTdG9yZXMvKi9zaXRlU2VhcmNoRW5naW5lL3RhcmdldFNpdGVzfS9vcGVyYXRpb25zWloSWC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL2NvbGxlY3Rpb25zLyovZGF0YVN0b3Jlcy8qL3NpdGVTZWFyY2hFbmdpbmV9L29wZXJhdGlvbnNaSRJHL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9kYXRhU3RvcmVzLyp9L29wZXJhdGlvbnNaRhJEL3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKi9lbmdpbmVzLyp9L29wZXJhdGlvbnNaPBI6L3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovY29sbGVjdGlvbnMvKn0vb3BlcmF0aW9uc1pGEkQvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kYXRhU3RvcmVzLyovYnJhbmNoZXMvKn0vb3BlcmF0aW9uc1pEEkIvdjEve25hbWU9cHJvamVjdHMvKi9sb2NhdGlvbnMvKi9kYXRhU3RvcmVzLyovbW9kZWxzLyp9L29wZXJhdGlvbnNaOxI5L3YxL3tuYW1lPXByb2plY3RzLyovbG9jYXRpb25zLyovZGF0YVN0b3Jlcy8qfS9vcGVyYXRpb25zWi4SLC92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qfS9vcGVyYXRpb25zWiISIC92MS97bmFtZT1wcm9qZWN0cy8qfS9vcGVyYXRpb25z")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return CommonReflection.Descriptor;
            yield return CompletionServiceReflection.Descriptor;
            yield return ConversationReflection.Descriptor;
            yield return ConversationalSearchServiceReflection.Descriptor;
            yield return DocumentReflection.Descriptor;
            yield return DocumentServiceReflection.Descriptor;
            yield return ImportConfigReflection.Descriptor;
            yield return PurgeConfigReflection.Descriptor;
            yield return SchemaReflection.Descriptor;
            yield return SchemaServiceReflection.Descriptor;
            yield return SearchServiceReflection.Descriptor;
            yield return UserEventReflection.Descriptor;
            yield return UserEventServiceReflection.Descriptor;
            yield return gcl::LocationsReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}
