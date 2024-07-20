// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/directory/writer/v3/writer.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Aserto.Directory.Writer.V3 {
  public static partial class Writer
  {
    static readonly string __ServiceName = "aserto.directory.writer.v3.Writer";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Writer.V3.SetObjectRequest> __Marshaller_aserto_directory_writer_v3_SetObjectRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Writer.V3.SetObjectRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Writer.V3.SetObjectResponse> __Marshaller_aserto_directory_writer_v3_SetObjectResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Writer.V3.SetObjectResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Writer.V3.DeleteObjectRequest> __Marshaller_aserto_directory_writer_v3_DeleteObjectRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Writer.V3.DeleteObjectRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Writer.V3.DeleteObjectResponse> __Marshaller_aserto_directory_writer_v3_DeleteObjectResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Writer.V3.DeleteObjectResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Writer.V3.SetRelationRequest> __Marshaller_aserto_directory_writer_v3_SetRelationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Writer.V3.SetRelationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Writer.V3.SetRelationResponse> __Marshaller_aserto_directory_writer_v3_SetRelationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Writer.V3.SetRelationResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Writer.V3.DeleteRelationRequest> __Marshaller_aserto_directory_writer_v3_DeleteRelationRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Writer.V3.DeleteRelationRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Writer.V3.DeleteRelationResponse> __Marshaller_aserto_directory_writer_v3_DeleteRelationResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Writer.V3.DeleteRelationResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Directory.Writer.V3.SetObjectRequest, global::Aserto.Directory.Writer.V3.SetObjectResponse> __Method_SetObject = new grpc::Method<global::Aserto.Directory.Writer.V3.SetObjectRequest, global::Aserto.Directory.Writer.V3.SetObjectResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetObject",
        __Marshaller_aserto_directory_writer_v3_SetObjectRequest,
        __Marshaller_aserto_directory_writer_v3_SetObjectResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Directory.Writer.V3.DeleteObjectRequest, global::Aserto.Directory.Writer.V3.DeleteObjectResponse> __Method_DeleteObject = new grpc::Method<global::Aserto.Directory.Writer.V3.DeleteObjectRequest, global::Aserto.Directory.Writer.V3.DeleteObjectResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteObject",
        __Marshaller_aserto_directory_writer_v3_DeleteObjectRequest,
        __Marshaller_aserto_directory_writer_v3_DeleteObjectResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Directory.Writer.V3.SetRelationRequest, global::Aserto.Directory.Writer.V3.SetRelationResponse> __Method_SetRelation = new grpc::Method<global::Aserto.Directory.Writer.V3.SetRelationRequest, global::Aserto.Directory.Writer.V3.SetRelationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SetRelation",
        __Marshaller_aserto_directory_writer_v3_SetRelationRequest,
        __Marshaller_aserto_directory_writer_v3_SetRelationResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Directory.Writer.V3.DeleteRelationRequest, global::Aserto.Directory.Writer.V3.DeleteRelationResponse> __Method_DeleteRelation = new grpc::Method<global::Aserto.Directory.Writer.V3.DeleteRelationRequest, global::Aserto.Directory.Writer.V3.DeleteRelationResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteRelation",
        __Marshaller_aserto_directory_writer_v3_DeleteRelationRequest,
        __Marshaller_aserto_directory_writer_v3_DeleteRelationResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Aserto.Directory.Writer.V3.WriterReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Writer</summary>
    [grpc::BindServiceMethod(typeof(Writer), "BindService")]
    public abstract partial class WriterBase
    {
      /// <summary>
      /// object methods
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Aserto.Directory.Writer.V3.SetObjectResponse> SetObject(global::Aserto.Directory.Writer.V3.SetObjectRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Aserto.Directory.Writer.V3.DeleteObjectResponse> DeleteObject(global::Aserto.Directory.Writer.V3.DeleteObjectRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// relation methods
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Aserto.Directory.Writer.V3.SetRelationResponse> SetRelation(global::Aserto.Directory.Writer.V3.SetRelationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Aserto.Directory.Writer.V3.DeleteRelationResponse> DeleteRelation(global::Aserto.Directory.Writer.V3.DeleteRelationRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Writer</summary>
    public partial class WriterClient : grpc::ClientBase<WriterClient>
    {
      /// <summary>Creates a new client for Writer</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WriterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Writer that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public WriterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WriterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected WriterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// object methods
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Writer.V3.SetObjectResponse SetObject(global::Aserto.Directory.Writer.V3.SetObjectRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetObject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// object methods
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Writer.V3.SetObjectResponse SetObject(global::Aserto.Directory.Writer.V3.SetObjectRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetObject, null, options, request);
      }
      /// <summary>
      /// object methods
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Writer.V3.SetObjectResponse> SetObjectAsync(global::Aserto.Directory.Writer.V3.SetObjectRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetObjectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// object methods
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Writer.V3.SetObjectResponse> SetObjectAsync(global::Aserto.Directory.Writer.V3.SetObjectRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetObject, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Writer.V3.DeleteObjectResponse DeleteObject(global::Aserto.Directory.Writer.V3.DeleteObjectRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteObject(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Writer.V3.DeleteObjectResponse DeleteObject(global::Aserto.Directory.Writer.V3.DeleteObjectRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteObject, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Writer.V3.DeleteObjectResponse> DeleteObjectAsync(global::Aserto.Directory.Writer.V3.DeleteObjectRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteObjectAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Writer.V3.DeleteObjectResponse> DeleteObjectAsync(global::Aserto.Directory.Writer.V3.DeleteObjectRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteObject, null, options, request);
      }
      /// <summary>
      /// relation methods
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Writer.V3.SetRelationResponse SetRelation(global::Aserto.Directory.Writer.V3.SetRelationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetRelation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// relation methods
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Writer.V3.SetRelationResponse SetRelation(global::Aserto.Directory.Writer.V3.SetRelationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SetRelation, null, options, request);
      }
      /// <summary>
      /// relation methods
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Writer.V3.SetRelationResponse> SetRelationAsync(global::Aserto.Directory.Writer.V3.SetRelationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetRelationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// relation methods
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Writer.V3.SetRelationResponse> SetRelationAsync(global::Aserto.Directory.Writer.V3.SetRelationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SetRelation, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Writer.V3.DeleteRelationResponse DeleteRelation(global::Aserto.Directory.Writer.V3.DeleteRelationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteRelation(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Writer.V3.DeleteRelationResponse DeleteRelation(global::Aserto.Directory.Writer.V3.DeleteRelationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteRelation, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Writer.V3.DeleteRelationResponse> DeleteRelationAsync(global::Aserto.Directory.Writer.V3.DeleteRelationRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteRelationAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Writer.V3.DeleteRelationResponse> DeleteRelationAsync(global::Aserto.Directory.Writer.V3.DeleteRelationRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteRelation, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override WriterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new WriterClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(WriterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SetObject, serviceImpl.SetObject)
          .AddMethod(__Method_DeleteObject, serviceImpl.DeleteObject)
          .AddMethod(__Method_SetRelation, serviceImpl.SetRelation)
          .AddMethod(__Method_DeleteRelation, serviceImpl.DeleteRelation).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, WriterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SetObject, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Aserto.Directory.Writer.V3.SetObjectRequest, global::Aserto.Directory.Writer.V3.SetObjectResponse>(serviceImpl.SetObject));
      serviceBinder.AddMethod(__Method_DeleteObject, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Aserto.Directory.Writer.V3.DeleteObjectRequest, global::Aserto.Directory.Writer.V3.DeleteObjectResponse>(serviceImpl.DeleteObject));
      serviceBinder.AddMethod(__Method_SetRelation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Aserto.Directory.Writer.V3.SetRelationRequest, global::Aserto.Directory.Writer.V3.SetRelationResponse>(serviceImpl.SetRelation));
      serviceBinder.AddMethod(__Method_DeleteRelation, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Aserto.Directory.Writer.V3.DeleteRelationRequest, global::Aserto.Directory.Writer.V3.DeleteRelationResponse>(serviceImpl.DeleteRelation));
    }

  }
}
#endregion