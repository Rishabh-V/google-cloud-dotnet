// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/gaming/v1beta/realms_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Gaming.V1Beta {
  /// <summary>
  /// A realm is a grouping of game server clusters that are considered
  /// interchangeable.
  /// </summary>
  public static partial class RealmsService
  {
    static readonly string __ServiceName = "google.cloud.gaming.v1beta.RealmsService";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest> __Marshaller_google_cloud_gaming_v1beta_ListRealmsRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse> __Marshaller_google_cloud_gaming_v1beta_ListRealmsResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Gaming.V1Beta.GetRealmRequest> __Marshaller_google_cloud_gaming_v1beta_GetRealmRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Gaming.V1Beta.GetRealmRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Gaming.V1Beta.Realm> __Marshaller_google_cloud_gaming_v1beta_Realm = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Gaming.V1Beta.Realm.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest> __Marshaller_google_cloud_gaming_v1beta_CreateRealmRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest.Parser));
    static readonly grpc::Marshaller<global::Google.LongRunning.Operation> __Marshaller_google_longrunning_Operation = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.LongRunning.Operation.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest> __Marshaller_google_cloud_gaming_v1beta_DeleteRealmRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest> __Marshaller_google_cloud_gaming_v1beta_UpdateRealmRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest> __Marshaller_google_cloud_gaming_v1beta_PreviewRealmUpdateRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest.Parser));
    static readonly grpc::Marshaller<global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse> __Marshaller_google_cloud_gaming_v1beta_PreviewRealmUpdateResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse.Parser));

    static readonly grpc::Method<global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest, global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse> __Method_ListRealms = new grpc::Method<global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest, global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListRealms",
        __Marshaller_google_cloud_gaming_v1beta_ListRealmsRequest,
        __Marshaller_google_cloud_gaming_v1beta_ListRealmsResponse);

    static readonly grpc::Method<global::Google.Cloud.Gaming.V1Beta.GetRealmRequest, global::Google.Cloud.Gaming.V1Beta.Realm> __Method_GetRealm = new grpc::Method<global::Google.Cloud.Gaming.V1Beta.GetRealmRequest, global::Google.Cloud.Gaming.V1Beta.Realm>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetRealm",
        __Marshaller_google_cloud_gaming_v1beta_GetRealmRequest,
        __Marshaller_google_cloud_gaming_v1beta_Realm);

    static readonly grpc::Method<global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest, global::Google.LongRunning.Operation> __Method_CreateRealm = new grpc::Method<global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateRealm",
        __Marshaller_google_cloud_gaming_v1beta_CreateRealmRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest, global::Google.LongRunning.Operation> __Method_DeleteRealm = new grpc::Method<global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteRealm",
        __Marshaller_google_cloud_gaming_v1beta_DeleteRealmRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest, global::Google.LongRunning.Operation> __Method_UpdateRealm = new grpc::Method<global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest, global::Google.LongRunning.Operation>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateRealm",
        __Marshaller_google_cloud_gaming_v1beta_UpdateRealmRequest,
        __Marshaller_google_longrunning_Operation);

    static readonly grpc::Method<global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest, global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse> __Method_PreviewRealmUpdate = new grpc::Method<global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest, global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "PreviewRealmUpdate",
        __Marshaller_google_cloud_gaming_v1beta_PreviewRealmUpdateRequest,
        __Marshaller_google_cloud_gaming_v1beta_PreviewRealmUpdateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Gaming.V1Beta.RealmsServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RealmsService</summary>
    [grpc::BindServiceMethod(typeof(RealmsService), "BindService")]
    public abstract partial class RealmsServiceBase
    {
      /// <summary>
      /// Lists realms in a given project and location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse> ListRealms(global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets details of a single realm.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Gaming.V1Beta.Realm> GetRealm(global::Google.Cloud.Gaming.V1Beta.GetRealmRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a new realm in a given project and location.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> CreateRealm(global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes a single realm.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> DeleteRealm(global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Patches a single realm.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.LongRunning.Operation> UpdateRealm(global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Previews patches to a single realm.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse> PreviewRealmUpdate(global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RealmsService</summary>
    public partial class RealmsServiceClient : grpc::ClientBase<RealmsServiceClient>
    {
      /// <summary>Creates a new client for RealmsService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RealmsServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RealmsService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RealmsServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RealmsServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RealmsServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists realms in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse ListRealms(global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListRealms(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists realms in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse ListRealms(global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListRealms, null, options, request);
      }
      /// <summary>
      /// Lists realms in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse> ListRealmsAsync(global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListRealmsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists realms in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse> ListRealmsAsync(global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListRealms, null, options, request);
      }
      /// <summary>
      /// Gets details of a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Gaming.V1Beta.Realm GetRealm(global::Google.Cloud.Gaming.V1Beta.GetRealmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRealm(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets details of a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Gaming.V1Beta.Realm GetRealm(global::Google.Cloud.Gaming.V1Beta.GetRealmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetRealm, null, options, request);
      }
      /// <summary>
      /// Gets details of a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Gaming.V1Beta.Realm> GetRealmAsync(global::Google.Cloud.Gaming.V1Beta.GetRealmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetRealmAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets details of a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Gaming.V1Beta.Realm> GetRealmAsync(global::Google.Cloud.Gaming.V1Beta.GetRealmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetRealm, null, options, request);
      }
      /// <summary>
      /// Creates a new realm in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateRealm(global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateRealm(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new realm in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation CreateRealm(global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateRealm, null, options, request);
      }
      /// <summary>
      /// Creates a new realm in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateRealmAsync(global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateRealmAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new realm in a given project and location.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> CreateRealmAsync(global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateRealm, null, options, request);
      }
      /// <summary>
      /// Deletes a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation DeleteRealm(global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteRealm(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation DeleteRealm(global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteRealm, null, options, request);
      }
      /// <summary>
      /// Deletes a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteRealmAsync(global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteRealmAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> DeleteRealmAsync(global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteRealm, null, options, request);
      }
      /// <summary>
      /// Patches a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation UpdateRealm(global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRealm(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Patches a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.LongRunning.Operation UpdateRealm(global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateRealm, null, options, request);
      }
      /// <summary>
      /// Patches a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateRealmAsync(global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateRealmAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Patches a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.LongRunning.Operation> UpdateRealmAsync(global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateRealm, null, options, request);
      }
      /// <summary>
      /// Previews patches to a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse PreviewRealmUpdate(global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PreviewRealmUpdate(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Previews patches to a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse PreviewRealmUpdate(global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_PreviewRealmUpdate, null, options, request);
      }
      /// <summary>
      /// Previews patches to a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse> PreviewRealmUpdateAsync(global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return PreviewRealmUpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Previews patches to a single realm.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse> PreviewRealmUpdateAsync(global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_PreviewRealmUpdate, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RealmsServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RealmsServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RealmsServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListRealms, serviceImpl.ListRealms)
          .AddMethod(__Method_GetRealm, serviceImpl.GetRealm)
          .AddMethod(__Method_CreateRealm, serviceImpl.CreateRealm)
          .AddMethod(__Method_DeleteRealm, serviceImpl.DeleteRealm)
          .AddMethod(__Method_UpdateRealm, serviceImpl.UpdateRealm)
          .AddMethod(__Method_PreviewRealmUpdate, serviceImpl.PreviewRealmUpdate).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, RealmsServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ListRealms, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Gaming.V1Beta.ListRealmsRequest, global::Google.Cloud.Gaming.V1Beta.ListRealmsResponse>(serviceImpl.ListRealms));
      serviceBinder.AddMethod(__Method_GetRealm, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Gaming.V1Beta.GetRealmRequest, global::Google.Cloud.Gaming.V1Beta.Realm>(serviceImpl.GetRealm));
      serviceBinder.AddMethod(__Method_CreateRealm, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Gaming.V1Beta.CreateRealmRequest, global::Google.LongRunning.Operation>(serviceImpl.CreateRealm));
      serviceBinder.AddMethod(__Method_DeleteRealm, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Gaming.V1Beta.DeleteRealmRequest, global::Google.LongRunning.Operation>(serviceImpl.DeleteRealm));
      serviceBinder.AddMethod(__Method_UpdateRealm, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Gaming.V1Beta.UpdateRealmRequest, global::Google.LongRunning.Operation>(serviceImpl.UpdateRealm));
      serviceBinder.AddMethod(__Method_PreviewRealmUpdate, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateRequest, global::Google.Cloud.Gaming.V1Beta.PreviewRealmUpdateResponse>(serviceImpl.PreviewRealmUpdate));
    }

  }
}
#endregion