// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: protoc-gen-openapiv2/options/annotations.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Grpc.Gateway.ProtocGenOpenapiv2.Options {

  /// <summary>Holder for reflection information generated from protoc-gen-openapiv2/options/annotations.proto</summary>
  public static partial class AnnotationsReflection {

    #region Descriptor
    /// <summary>File descriptor for protoc-gen-openapiv2/options/annotations.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AnnotationsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci5wcm90b2MtZ2VuLW9wZW5hcGl2Mi9vcHRpb25zL2Fubm90YXRpb25zLnBy",
            "b3RvEilncnBjLmdhdGV3YXkucHJvdG9jX2dlbl9vcGVuYXBpdjIub3B0aW9u",
            "cxogZ29vZ2xlL3Byb3RvYnVmL2Rlc2NyaXB0b3IucHJvdG8aLHByb3RvYy1n",
            "ZW4tb3BlbmFwaXYyL29wdGlvbnMvb3BlbmFwaXYyLnByb3RvOn4KEW9wZW5h",
            "cGl2Ml9zd2FnZ2VyEhwuZ29vZ2xlLnByb3RvYnVmLkZpbGVPcHRpb25zGJII",
            "IAEoCzIyLmdycGMuZ2F0ZXdheS5wcm90b2NfZ2VuX29wZW5hcGl2Mi5vcHRp",
            "b25zLlN3YWdnZXJSEG9wZW5hcGl2MlN3YWdnZXI6hgEKE29wZW5hcGl2Ml9v",
            "cGVyYXRpb24SHi5nb29nbGUucHJvdG9idWYuTWV0aG9kT3B0aW9ucxiSCCAB",
            "KAsyNC5ncnBjLmdhdGV3YXkucHJvdG9jX2dlbl9vcGVuYXBpdjIub3B0aW9u",
            "cy5PcGVyYXRpb25SEm9wZW5hcGl2Mk9wZXJhdGlvbjp+ChBvcGVuYXBpdjJf",
            "c2NoZW1hEh8uZ29vZ2xlLnByb3RvYnVmLk1lc3NhZ2VPcHRpb25zGJIIIAEo",
            "CzIxLmdycGMuZ2F0ZXdheS5wcm90b2NfZ2VuX29wZW5hcGl2Mi5vcHRpb25z",
            "LlNjaGVtYVIPb3BlbmFwaXYyU2NoZW1hOnsKDm9wZW5hcGl2Ml9lbnVtEhwu",
            "Z29vZ2xlLnByb3RvYnVmLkVudW1PcHRpb25zGJIIIAEoCzI1LmdycGMuZ2F0",
            "ZXdheS5wcm90b2NfZ2VuX29wZW5hcGl2Mi5vcHRpb25zLkVudW1TY2hlbWFS",
            "DW9wZW5hcGl2MkVudW06dQoNb3BlbmFwaXYyX3RhZxIfLmdvb2dsZS5wcm90",
            "b2J1Zi5TZXJ2aWNlT3B0aW9ucxiSCCABKAsyLi5ncnBjLmdhdGV3YXkucHJv",
            "dG9jX2dlbl9vcGVuYXBpdjIub3B0aW9ucy5UYWdSDG9wZW5hcGl2MlRhZzp+",
            "Cg9vcGVuYXBpdjJfZmllbGQSHS5nb29nbGUucHJvdG9idWYuRmllbGRPcHRp",
            "b25zGJIIIAEoCzI1LmdycGMuZ2F0ZXdheS5wcm90b2NfZ2VuX29wZW5hcGl2",
            "Mi5vcHRpb25zLkpTT05TY2hlbWFSDm9wZW5hcGl2MkZpZWxkQskCCi1jb20u",
            "Z3JwYy5nYXRld2F5LnByb3RvY19nZW5fb3BlbmFwaXYyLm9wdGlvbnNCEEFu",
            "bm90YXRpb25zUHJvdG9QAVpGZ2l0aHViLmNvbS9ncnBjLWVjb3N5c3RlbS9n",
            "cnBjLWdhdGV3YXkvdjIvcHJvdG9jLWdlbi1vcGVuYXBpdjIvb3B0aW9uc6IC",
            "BEdHUE+qAidHcnBjLkdhdGV3YXkuUHJvdG9jR2VuT3BlbmFwaXYyLk9wdGlv",
            "bnPKAidHcnBjXEdhdGV3YXlcUHJvdG9jR2VuT3BlbmFwaXYyXE9wdGlvbnPi",
            "AjNHcnBjXEdhdGV3YXlcUHJvdG9jR2VuT3BlbmFwaXYyXE9wdGlvbnNcR1BC",
            "TWV0YWRhdGHqAipHcnBjOjpHYXRld2F5OjpQcm90b2NHZW5PcGVuYXBpdjI6",
            "Ok9wdGlvbnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Openapiv2Reflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pb::Extension[] { AnnotationsExtensions.Openapiv2Swagger, AnnotationsExtensions.Openapiv2Operation, AnnotationsExtensions.Openapiv2Schema, AnnotationsExtensions.Openapiv2Enum, AnnotationsExtensions.Openapiv2Tag, AnnotationsExtensions.Openapiv2Field }, null));
    }
    #endregion

  }
  /// <summary>Holder for extension identifiers generated from the top level of protoc-gen-openapiv2/options/annotations.proto</summary>
  public static partial class AnnotationsExtensions {
    /// <summary>
    /// ID assigned by protobuf-global-extension-registry@google.com for gRPC-Gateway project.
    ///
    /// All IDs are the same, as assigned. It is okay that they are the same, as they extend
    /// different descriptor messages.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FileOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Swagger> Openapiv2Swagger =
      new pb::Extension<global::Google.Protobuf.Reflection.FileOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Swagger>(1042, pb::FieldCodec.ForMessage(8338, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Swagger.Parser));
    /// <summary>
    /// ID assigned by protobuf-global-extension-registry@google.com for gRPC-Gateway project.
    ///
    /// All IDs are the same, as assigned. It is okay that they are the same, as they extend
    /// different descriptor messages.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Operation> Openapiv2Operation =
      new pb::Extension<global::Google.Protobuf.Reflection.MethodOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Operation>(1042, pb::FieldCodec.ForMessage(8338, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Operation.Parser));
    /// <summary>
    /// ID assigned by protobuf-global-extension-registry@google.com for gRPC-Gateway project.
    ///
    /// All IDs are the same, as assigned. It is okay that they are the same, as they extend
    /// different descriptor messages.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Schema> Openapiv2Schema =
      new pb::Extension<global::Google.Protobuf.Reflection.MessageOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Schema>(1042, pb::FieldCodec.ForMessage(8338, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Schema.Parser));
    /// <summary>
    /// ID assigned by protobuf-global-extension-registry@google.com for gRPC-Gateway project.
    ///
    /// All IDs are the same, as assigned. It is okay that they are the same, as they extend
    /// different descriptor messages.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.EnumSchema> Openapiv2Enum =
      new pb::Extension<global::Google.Protobuf.Reflection.EnumOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.EnumSchema>(1042, pb::FieldCodec.ForMessage(8338, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.EnumSchema.Parser));
    /// <summary>
    /// ID assigned by protobuf-global-extension-registry@google.com for gRPC-Gateway project.
    ///
    /// All IDs are the same, as assigned. It is okay that they are the same, as they extend
    /// different descriptor messages.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.ServiceOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Tag> Openapiv2Tag =
      new pb::Extension<global::Google.Protobuf.Reflection.ServiceOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Tag>(1042, pb::FieldCodec.ForMessage(8338, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.Tag.Parser));
    /// <summary>
    /// ID assigned by protobuf-global-extension-registry@google.com for gRPC-Gateway project.
    ///
    /// All IDs are the same, as assigned. It is okay that they are the same, as they extend
    /// different descriptor messages.
    /// </summary>
    public static readonly pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.JSONSchema> Openapiv2Field =
      new pb::Extension<global::Google.Protobuf.Reflection.FieldOptions, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.JSONSchema>(1042, pb::FieldCodec.ForMessage(8338, global::Grpc.Gateway.ProtocGenOpenapiv2.Options.JSONSchema.Parser));
  }

}

#endregion Designer generated code
