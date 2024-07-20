// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/directory/model/v3/model.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981, 0612
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Aserto.Directory.Model.V3 {
  public static partial class Model
  {
    static readonly string __ServiceName = "aserto.directory.model.v3.Model";

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
    static readonly grpc::Marshaller<global::Aserto.Directory.Model.V3.GetManifestRequest> __Marshaller_aserto_directory_model_v3_GetManifestRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Model.V3.GetManifestRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Model.V3.GetManifestResponse> __Marshaller_aserto_directory_model_v3_GetManifestResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Model.V3.GetManifestResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Model.V3.SetManifestRequest> __Marshaller_aserto_directory_model_v3_SetManifestRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Model.V3.SetManifestRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Model.V3.SetManifestResponse> __Marshaller_aserto_directory_model_v3_SetManifestResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Model.V3.SetManifestResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Model.V3.DeleteManifestRequest> __Marshaller_aserto_directory_model_v3_DeleteManifestRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Model.V3.DeleteManifestRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Aserto.Directory.Model.V3.DeleteManifestResponse> __Marshaller_aserto_directory_model_v3_DeleteManifestResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Aserto.Directory.Model.V3.DeleteManifestResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Directory.Model.V3.GetManifestRequest, global::Aserto.Directory.Model.V3.GetManifestResponse> __Method_GetManifest = new grpc::Method<global::Aserto.Directory.Model.V3.GetManifestRequest, global::Aserto.Directory.Model.V3.GetManifestResponse>(
        grpc::MethodType.ServerStreaming,
        __ServiceName,
        "GetManifest",
        __Marshaller_aserto_directory_model_v3_GetManifestRequest,
        __Marshaller_aserto_directory_model_v3_GetManifestResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Directory.Model.V3.SetManifestRequest, global::Aserto.Directory.Model.V3.SetManifestResponse> __Method_SetManifest = new grpc::Method<global::Aserto.Directory.Model.V3.SetManifestRequest, global::Aserto.Directory.Model.V3.SetManifestResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "SetManifest",
        __Marshaller_aserto_directory_model_v3_SetManifestRequest,
        __Marshaller_aserto_directory_model_v3_SetManifestResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Aserto.Directory.Model.V3.DeleteManifestRequest, global::Aserto.Directory.Model.V3.DeleteManifestResponse> __Method_DeleteManifest = new grpc::Method<global::Aserto.Directory.Model.V3.DeleteManifestRequest, global::Aserto.Directory.Model.V3.DeleteManifestResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteManifest",
        __Marshaller_aserto_directory_model_v3_DeleteManifestRequest,
        __Marshaller_aserto_directory_model_v3_DeleteManifestResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Aserto.Directory.Model.V3.ModelReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Model</summary>
    [grpc::BindServiceMethod(typeof(Model), "BindService")]
    public abstract partial class ModelBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task GetManifest(global::Aserto.Directory.Model.V3.GetManifestRequest request, grpc::IServerStreamWriter<global::Aserto.Directory.Model.V3.GetManifestResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Aserto.Directory.Model.V3.SetManifestResponse> SetManifest(grpc::IAsyncStreamReader<global::Aserto.Directory.Model.V3.SetManifestRequest> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Aserto.Directory.Model.V3.DeleteManifestResponse> DeleteManifest(global::Aserto.Directory.Model.V3.DeleteManifestRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Model</summary>
    public partial class ModelClient : grpc::ClientBase<ModelClient>
    {
      /// <summary>Creates a new client for Model</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ModelClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Model that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ModelClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ModelClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ModelClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Aserto.Directory.Model.V3.GetManifestResponse> GetManifest(global::Aserto.Directory.Model.V3.GetManifestRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetManifest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncServerStreamingCall<global::Aserto.Directory.Model.V3.GetManifestResponse> GetManifest(global::Aserto.Directory.Model.V3.GetManifestRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncServerStreamingCall(__Method_GetManifest, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Aserto.Directory.Model.V3.SetManifestRequest, global::Aserto.Directory.Model.V3.SetManifestResponse> SetManifest(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SetManifest(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncClientStreamingCall<global::Aserto.Directory.Model.V3.SetManifestRequest, global::Aserto.Directory.Model.V3.SetManifestResponse> SetManifest(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_SetManifest, null, options);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Model.V3.DeleteManifestResponse DeleteManifest(global::Aserto.Directory.Model.V3.DeleteManifestRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteManifest(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::Aserto.Directory.Model.V3.DeleteManifestResponse DeleteManifest(global::Aserto.Directory.Model.V3.DeleteManifestRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteManifest, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Model.V3.DeleteManifestResponse> DeleteManifestAsync(global::Aserto.Directory.Model.V3.DeleteManifestRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteManifestAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::Aserto.Directory.Model.V3.DeleteManifestResponse> DeleteManifestAsync(global::Aserto.Directory.Model.V3.DeleteManifestRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteManifest, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ModelClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ModelClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ModelBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetManifest, serviceImpl.GetManifest)
          .AddMethod(__Method_SetManifest, serviceImpl.SetManifest)
          .AddMethod(__Method_DeleteManifest, serviceImpl.DeleteManifest).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ModelBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetManifest, serviceImpl == null ? null : new grpc::ServerStreamingServerMethod<global::Aserto.Directory.Model.V3.GetManifestRequest, global::Aserto.Directory.Model.V3.GetManifestResponse>(serviceImpl.GetManifest));
      serviceBinder.AddMethod(__Method_SetManifest, serviceImpl == null ? null : new grpc::ClientStreamingServerMethod<global::Aserto.Directory.Model.V3.SetManifestRequest, global::Aserto.Directory.Model.V3.SetManifestResponse>(serviceImpl.SetManifest));
      serviceBinder.AddMethod(__Method_DeleteManifest, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Aserto.Directory.Model.V3.DeleteManifestRequest, global::Aserto.Directory.Model.V3.DeleteManifestResponse>(serviceImpl.DeleteManifest));
    }

  }
}
#endregion