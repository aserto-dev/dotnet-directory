// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/directory/exporter/v2/exporter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aserto.Directory.Exporter.V2 {

  /// <summary>Holder for reflection information generated from aserto/directory/exporter/v2/exporter.proto</summary>
  public static partial class ExporterReflection {

    #region Descriptor
    /// <summary>File descriptor for aserto/directory/exporter/v2/exporter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExporterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cithc2VydG8vZGlyZWN0b3J5L2V4cG9ydGVyL3YyL2V4cG9ydGVyLnByb3Rv",
            "Ehxhc2VydG8uZGlyZWN0b3J5LmV4cG9ydGVyLnYyGidhc2VydG8vZGlyZWN0",
            "b3J5L2NvbW1vbi92Mi9jb21tb24ucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90",
            "aW1lc3RhbXAucHJvdG8iaAoNRXhwb3J0UmVxdWVzdBIYCgdvcHRpb25zGAEg",
            "ASgNUgdvcHRpb25zEjkKCnN0YXJ0X2Zyb20YFCABKAsyGi5nb29nbGUucHJv",
            "dG9idWYuVGltZXN0YW1wUglzdGFydEZyb206AhgBIoMDCg5FeHBvcnRSZXNw",
            "b25zZRI8CgZvYmplY3QYAiABKAsyIi5hc2VydG8uZGlyZWN0b3J5LmNvbW1v",
            "bi52Mi5PYmplY3RIAFIGb2JqZWN0EkkKC29iamVjdF90eXBlGAMgASgLMiYu",
            "YXNlcnRvLmRpcmVjdG9yeS5jb21tb24udjIuT2JqZWN0VHlwZUgAUgpvYmpl",
            "Y3RUeXBlEkIKCHJlbGF0aW9uGAQgASgLMiQuYXNlcnRvLmRpcmVjdG9yeS5j",
            "b21tb24udjIuUmVsYXRpb25IAFIIcmVsYXRpb24STwoNcmVsYXRpb25fdHlw",
            "ZRgFIAEoCzIoLmFzZXJ0by5kaXJlY3RvcnkuY29tbW9uLnYyLlJlbGF0aW9u",
            "VHlwZUgAUgxyZWxhdGlvblR5cGUSSAoKcGVybWlzc2lvbhgGIAEoCzImLmFz",
            "ZXJ0by5kaXJlY3RvcnkuY29tbW9uLnYyLlBlcm1pc3Npb25IAFIKcGVybWlz",
            "c2lvbjoCGAFCBQoDbXNnKssCCgZPcHRpb24SEgoOT1BUSU9OX1VOS05PV04Q",
            "ABIgChxPUFRJT05fTUVUQURBVEFfT0JKRUNUX1RZUEVTEAESIgoeT1BUSU9O",
            "X01FVEFEQVRBX1JFTEFUSU9OX1RZUEVTEAISHwobT1BUSU9OX01FVEFEQVRB",
            "X1BFUk1JU1NJT05TEAQSEwoPT1BUSU9OX01FVEFEQVRBEAcSFwoTT1BUSU9O",
            "X0RBVEFfT0JKRUNUUxAIEhkKFU9QVElPTl9EQVRBX1JFTEFUSU9OUxAQEiMK",
            "H09QVElPTl9EQVRBX1JFTEFUSU9OU19XSVRIX0tFWVMQIBIPCgtPUFRJT05f",
            "REFUQRAYEhkKFU9QVElPTl9EQVRBX1dJVEhfS0VZUxAoEg4KCk9QVElPTl9B",
            "TEwQHxIYChRPUFRJT05fQUxMX1dJVEhfS0VZUxAvGgIYATJ2CghFeHBvcnRl",
            "chJqCgZFeHBvcnQSKy5hc2VydG8uZGlyZWN0b3J5LmV4cG9ydGVyLnYyLkV4",
            "cG9ydFJlcXVlc3QaLC5hc2VydG8uZGlyZWN0b3J5LmV4cG9ydGVyLnYyLkV4",
            "cG9ydFJlc3BvbnNlIgOIAgEwAUKQAgogY29tLmFzZXJ0by5kaXJlY3Rvcnku",
            "ZXhwb3J0ZXIudjJCDUV4cG9ydGVyUHJvdG9QAVpIZ2l0aHViLmNvbS9hc2Vy",
            "dG8tZGV2L2dvLWRpcmVjdG9yeS9hc2VydG8vZGlyZWN0b3J5L2V4cG9ydGVy",
            "L3YyO2V4cG9ydGVyogIDQURFqgIcQXNlcnRvLkRpcmVjdG9yeS5FeHBvcnRl",
            "ci5WMsoCHUFzZXJ0b1xEaXJlY3RvcnlfXEV4cG9ydGVyXFYy4gIpQXNlcnRv",
            "XERpcmVjdG9yeV9cRXhwb3J0ZXJcVjJcR1BCTWV0YWRhdGHqAh9Bc2VydG86",
            "OkRpcmVjdG9yeTo6RXhwb3J0ZXI6OlYyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Aserto.Directory.Common.V2.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Aserto.Directory.Exporter.V2.Option), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aserto.Directory.Exporter.V2.ExportRequest), global::Aserto.Directory.Exporter.V2.ExportRequest.Parser, new[]{ "Options", "StartFrom" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Aserto.Directory.Exporter.V2.ExportResponse), global::Aserto.Directory.Exporter.V2.ExportResponse.Parser, new[]{ "Object", "ObjectType", "Relation", "RelationType", "Permission" }, new[]{ "Msg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  [global::System.ObsoleteAttribute]
  public enum Option {
    /// <summary>
    /// nothing selected (default initialization value)
    /// </summary>
    [pbr::OriginalName("OPTION_UNKNOWN")] Unknown = 0,
    /// <summary>
    /// object type metadata
    /// </summary>
    [pbr::OriginalName("OPTION_METADATA_OBJECT_TYPES")] MetadataObjectTypes = 1,
    /// <summary>
    /// relation type metadata
    /// </summary>
    [pbr::OriginalName("OPTION_METADATA_RELATION_TYPES")] MetadataRelationTypes = 2,
    /// <summary>
    /// permission metadata
    /// </summary>
    [pbr::OriginalName("OPTION_METADATA_PERMISSIONS")] MetadataPermissions = 4,
    /// <summary>
    /// all metadata = OPTION_METADATA_OBJECT_TYPES | OPTION_METADATA_RELATION_TYPES | OPTION_METADATA_PERMISSIONS
    /// </summary>
    [pbr::OriginalName("OPTION_METADATA")] Metadata = 7,
    /// <summary>
    /// object instances
    /// </summary>
    [pbr::OriginalName("OPTION_DATA_OBJECTS")] DataObjects = 8,
    /// <summary>
    /// relation instances
    /// </summary>
    [pbr::OriginalName("OPTION_DATA_RELATIONS")] DataRelations = 16,
    /// <summary>
    /// relation instances with key values
    /// </summary>
    [pbr::OriginalName("OPTION_DATA_RELATIONS_WITH_KEYS")] DataRelationsWithKeys = 32,
    /// <summary>
    /// all data = OPTION_DATA_OBJECTS | OPTION_DATA_RELATIONS
    /// </summary>
    [pbr::OriginalName("OPTION_DATA")] Data = 24,
    /// <summary>
    /// all data with keys = OPTION_DATA_OBJECTS | OPTION_DATA_RELATIONS_WITH_KEYS
    /// </summary>
    [pbr::OriginalName("OPTION_DATA_WITH_KEYS")] DataWithKeys = 40,
    /// <summary>
    /// all metadata and data = OPTION_METADATA | OPTION_DATA
    /// </summary>
    [pbr::OriginalName("OPTION_ALL")] All = 31,
    /// <summary>
    /// all metadata and data with keys = OPTION_METADATA | OPTION_DATA_WITH_KEYS
    /// </summary>
    [pbr::OriginalName("OPTION_ALL_WITH_KEYS")] AllWithKeys = 47,
  }

  #endregion

  #region Messages
  [global::System.ObsoleteAttribute]
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ExportRequest : pb::IMessage<ExportRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExportRequest> _parser = new pb::MessageParser<ExportRequest>(() => new ExportRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExportRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aserto.Directory.Exporter.V2.ExporterReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExportRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExportRequest(ExportRequest other) : this() {
      options_ = other.options_;
      startFrom_ = other.startFrom_ != null ? other.startFrom_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExportRequest Clone() {
      return new ExportRequest(this);
    }

    /// <summary>Field number for the "options" field.</summary>
    public const int OptionsFieldNumber = 1;
    private uint options_;
    /// <summary>
    /// data export options mask
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public uint Options {
      get { return options_; }
      set {
        options_ = value;
      }
    }

    /// <summary>Field number for the "start_from" field.</summary>
    public const int StartFromFieldNumber = 20;
    private global::Google.Protobuf.WellKnownTypes.Timestamp startFrom_;
    /// <summary>
    /// start export from timestamp (UTC)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp StartFrom {
      get { return startFrom_; }
      set {
        startFrom_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExportRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExportRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Options != other.Options) return false;
      if (!object.Equals(StartFrom, other.StartFrom)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Options != 0) hash ^= Options.GetHashCode();
      if (startFrom_ != null) hash ^= StartFrom.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Options != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Options);
      }
      if (startFrom_ != null) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(StartFrom);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Options != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Options);
      }
      if (startFrom_ != null) {
        output.WriteRawTag(162, 1);
        output.WriteMessage(StartFrom);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Options != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Options);
      }
      if (startFrom_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(StartFrom);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExportRequest other) {
      if (other == null) {
        return;
      }
      if (other.Options != 0) {
        Options = other.Options;
      }
      if (other.startFrom_ != null) {
        if (startFrom_ == null) {
          StartFrom = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        StartFrom.MergeFrom(other.StartFrom);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Options = input.ReadUInt32();
            break;
          }
          case 162: {
            if (startFrom_ == null) {
              StartFrom = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartFrom);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Options = input.ReadUInt32();
            break;
          }
          case 162: {
            if (startFrom_ == null) {
              StartFrom = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(StartFrom);
            break;
          }
        }
      }
    }
    #endif

  }

  [global::System.ObsoleteAttribute]
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ExportResponse : pb::IMessage<ExportResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExportResponse> _parser = new pb::MessageParser<ExportResponse>(() => new ExportResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExportResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aserto.Directory.Exporter.V2.ExporterReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExportResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExportResponse(ExportResponse other) : this() {
      switch (other.MsgCase) {
        case MsgOneofCase.Object:
          Object = other.Object.Clone();
          break;
        case MsgOneofCase.ObjectType:
          ObjectType = other.ObjectType.Clone();
          break;
        case MsgOneofCase.Relation:
          Relation = other.Relation.Clone();
          break;
        case MsgOneofCase.RelationType:
          RelationType = other.RelationType.Clone();
          break;
        case MsgOneofCase.Permission:
          Permission = other.Permission.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExportResponse Clone() {
      return new ExportResponse(this);
    }

    /// <summary>Field number for the "object" field.</summary>
    public const int ObjectFieldNumber = 2;
    /// <summary>
    /// object instance (data)
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aserto.Directory.Common.V2.Object Object {
      get { return msgCase_ == MsgOneofCase.Object ? (global::Aserto.Directory.Common.V2.Object) msg_ : null; }
      set {
        msg_ = value;
        msgCase_ = value == null ? MsgOneofCase.None : MsgOneofCase.Object;
      }
    }

    /// <summary>Field number for the "object_type" field.</summary>
    public const int ObjectTypeFieldNumber = 3;
    /// <summary>
    /// object type instance (metadata)
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aserto.Directory.Common.V2.ObjectType ObjectType {
      get { return msgCase_ == MsgOneofCase.ObjectType ? (global::Aserto.Directory.Common.V2.ObjectType) msg_ : null; }
      set {
        msg_ = value;
        msgCase_ = value == null ? MsgOneofCase.None : MsgOneofCase.ObjectType;
      }
    }

    /// <summary>Field number for the "relation" field.</summary>
    public const int RelationFieldNumber = 4;
    /// <summary>
    /// relation instance (data)
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aserto.Directory.Common.V2.Relation Relation {
      get { return msgCase_ == MsgOneofCase.Relation ? (global::Aserto.Directory.Common.V2.Relation) msg_ : null; }
      set {
        msg_ = value;
        msgCase_ = value == null ? MsgOneofCase.None : MsgOneofCase.Relation;
      }
    }

    /// <summary>Field number for the "relation_type" field.</summary>
    public const int RelationTypeFieldNumber = 5;
    /// <summary>
    /// relation type instance (metadata)
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aserto.Directory.Common.V2.RelationType RelationType {
      get { return msgCase_ == MsgOneofCase.RelationType ? (global::Aserto.Directory.Common.V2.RelationType) msg_ : null; }
      set {
        msg_ = value;
        msgCase_ = value == null ? MsgOneofCase.None : MsgOneofCase.RelationType;
      }
    }

    /// <summary>Field number for the "permission" field.</summary>
    public const int PermissionFieldNumber = 6;
    /// <summary>
    /// permission instance (metadata)
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aserto.Directory.Common.V2.Permission Permission {
      get { return msgCase_ == MsgOneofCase.Permission ? (global::Aserto.Directory.Common.V2.Permission) msg_ : null; }
      set {
        msg_ = value;
        msgCase_ = value == null ? MsgOneofCase.None : MsgOneofCase.Permission;
      }
    }

    private object msg_;
    /// <summary>Enum of possible cases for the "msg" oneof.</summary>
    public enum MsgOneofCase {
      None = 0,
      Object = 2,
      ObjectType = 3,
      Relation = 4,
      RelationType = 5,
      Permission = 6,
    }
    private MsgOneofCase msgCase_ = MsgOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MsgOneofCase MsgCase {
      get { return msgCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMsg() {
      msgCase_ = MsgOneofCase.None;
      msg_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExportResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExportResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Object, other.Object)) return false;
      if (!object.Equals(ObjectType, other.ObjectType)) return false;
      if (!object.Equals(Relation, other.Relation)) return false;
      if (!object.Equals(RelationType, other.RelationType)) return false;
      if (!object.Equals(Permission, other.Permission)) return false;
      if (MsgCase != other.MsgCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (msgCase_ == MsgOneofCase.Object) hash ^= Object.GetHashCode();
      if (msgCase_ == MsgOneofCase.ObjectType) hash ^= ObjectType.GetHashCode();
      if (msgCase_ == MsgOneofCase.Relation) hash ^= Relation.GetHashCode();
      if (msgCase_ == MsgOneofCase.RelationType) hash ^= RelationType.GetHashCode();
      if (msgCase_ == MsgOneofCase.Permission) hash ^= Permission.GetHashCode();
      hash ^= (int) msgCase_;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (msgCase_ == MsgOneofCase.Object) {
        output.WriteRawTag(18);
        output.WriteMessage(Object);
      }
      if (msgCase_ == MsgOneofCase.ObjectType) {
        output.WriteRawTag(26);
        output.WriteMessage(ObjectType);
      }
      if (msgCase_ == MsgOneofCase.Relation) {
        output.WriteRawTag(34);
        output.WriteMessage(Relation);
      }
      if (msgCase_ == MsgOneofCase.RelationType) {
        output.WriteRawTag(42);
        output.WriteMessage(RelationType);
      }
      if (msgCase_ == MsgOneofCase.Permission) {
        output.WriteRawTag(50);
        output.WriteMessage(Permission);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (msgCase_ == MsgOneofCase.Object) {
        output.WriteRawTag(18);
        output.WriteMessage(Object);
      }
      if (msgCase_ == MsgOneofCase.ObjectType) {
        output.WriteRawTag(26);
        output.WriteMessage(ObjectType);
      }
      if (msgCase_ == MsgOneofCase.Relation) {
        output.WriteRawTag(34);
        output.WriteMessage(Relation);
      }
      if (msgCase_ == MsgOneofCase.RelationType) {
        output.WriteRawTag(42);
        output.WriteMessage(RelationType);
      }
      if (msgCase_ == MsgOneofCase.Permission) {
        output.WriteRawTag(50);
        output.WriteMessage(Permission);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (msgCase_ == MsgOneofCase.Object) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Object);
      }
      if (msgCase_ == MsgOneofCase.ObjectType) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ObjectType);
      }
      if (msgCase_ == MsgOneofCase.Relation) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Relation);
      }
      if (msgCase_ == MsgOneofCase.RelationType) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(RelationType);
      }
      if (msgCase_ == MsgOneofCase.Permission) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Permission);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExportResponse other) {
      if (other == null) {
        return;
      }
      switch (other.MsgCase) {
        case MsgOneofCase.Object:
          if (Object == null) {
            Object = new global::Aserto.Directory.Common.V2.Object();
          }
          Object.MergeFrom(other.Object);
          break;
        case MsgOneofCase.ObjectType:
          if (ObjectType == null) {
            ObjectType = new global::Aserto.Directory.Common.V2.ObjectType();
          }
          ObjectType.MergeFrom(other.ObjectType);
          break;
        case MsgOneofCase.Relation:
          if (Relation == null) {
            Relation = new global::Aserto.Directory.Common.V2.Relation();
          }
          Relation.MergeFrom(other.Relation);
          break;
        case MsgOneofCase.RelationType:
          if (RelationType == null) {
            RelationType = new global::Aserto.Directory.Common.V2.RelationType();
          }
          RelationType.MergeFrom(other.RelationType);
          break;
        case MsgOneofCase.Permission:
          if (Permission == null) {
            Permission = new global::Aserto.Directory.Common.V2.Permission();
          }
          Permission.MergeFrom(other.Permission);
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            global::Aserto.Directory.Common.V2.Object subBuilder = new global::Aserto.Directory.Common.V2.Object();
            if (msgCase_ == MsgOneofCase.Object) {
              subBuilder.MergeFrom(Object);
            }
            input.ReadMessage(subBuilder);
            Object = subBuilder;
            break;
          }
          case 26: {
            global::Aserto.Directory.Common.V2.ObjectType subBuilder = new global::Aserto.Directory.Common.V2.ObjectType();
            if (msgCase_ == MsgOneofCase.ObjectType) {
              subBuilder.MergeFrom(ObjectType);
            }
            input.ReadMessage(subBuilder);
            ObjectType = subBuilder;
            break;
          }
          case 34: {
            global::Aserto.Directory.Common.V2.Relation subBuilder = new global::Aserto.Directory.Common.V2.Relation();
            if (msgCase_ == MsgOneofCase.Relation) {
              subBuilder.MergeFrom(Relation);
            }
            input.ReadMessage(subBuilder);
            Relation = subBuilder;
            break;
          }
          case 42: {
            global::Aserto.Directory.Common.V2.RelationType subBuilder = new global::Aserto.Directory.Common.V2.RelationType();
            if (msgCase_ == MsgOneofCase.RelationType) {
              subBuilder.MergeFrom(RelationType);
            }
            input.ReadMessage(subBuilder);
            RelationType = subBuilder;
            break;
          }
          case 50: {
            global::Aserto.Directory.Common.V2.Permission subBuilder = new global::Aserto.Directory.Common.V2.Permission();
            if (msgCase_ == MsgOneofCase.Permission) {
              subBuilder.MergeFrom(Permission);
            }
            input.ReadMessage(subBuilder);
            Permission = subBuilder;
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 18: {
            global::Aserto.Directory.Common.V2.Object subBuilder = new global::Aserto.Directory.Common.V2.Object();
            if (msgCase_ == MsgOneofCase.Object) {
              subBuilder.MergeFrom(Object);
            }
            input.ReadMessage(subBuilder);
            Object = subBuilder;
            break;
          }
          case 26: {
            global::Aserto.Directory.Common.V2.ObjectType subBuilder = new global::Aserto.Directory.Common.V2.ObjectType();
            if (msgCase_ == MsgOneofCase.ObjectType) {
              subBuilder.MergeFrom(ObjectType);
            }
            input.ReadMessage(subBuilder);
            ObjectType = subBuilder;
            break;
          }
          case 34: {
            global::Aserto.Directory.Common.V2.Relation subBuilder = new global::Aserto.Directory.Common.V2.Relation();
            if (msgCase_ == MsgOneofCase.Relation) {
              subBuilder.MergeFrom(Relation);
            }
            input.ReadMessage(subBuilder);
            Relation = subBuilder;
            break;
          }
          case 42: {
            global::Aserto.Directory.Common.V2.RelationType subBuilder = new global::Aserto.Directory.Common.V2.RelationType();
            if (msgCase_ == MsgOneofCase.RelationType) {
              subBuilder.MergeFrom(RelationType);
            }
            input.ReadMessage(subBuilder);
            RelationType = subBuilder;
            break;
          }
          case 50: {
            global::Aserto.Directory.Common.V2.Permission subBuilder = new global::Aserto.Directory.Common.V2.Permission();
            if (msgCase_ == MsgOneofCase.Permission) {
              subBuilder.MergeFrom(Permission);
            }
            input.ReadMessage(subBuilder);
            Permission = subBuilder;
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
