// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/directory/exporter/v3/exporter.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aserto.Directory.Exporter.V3 {

  /// <summary>Holder for reflection information generated from aserto/directory/exporter/v3/exporter.proto</summary>
  public static partial class ExporterReflection {

    #region Descriptor
    /// <summary>File descriptor for aserto/directory/exporter/v3/exporter.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExporterReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cithc2VydG8vZGlyZWN0b3J5L2V4cG9ydGVyL3YzL2V4cG9ydGVyLnByb3Rv",
            "Ehxhc2VydG8uZGlyZWN0b3J5LmV4cG9ydGVyLnYzGidhc2VydG8vZGlyZWN0",
            "b3J5L2NvbW1vbi92My9jb21tb24ucHJvdG8aHGdvb2dsZS9wcm90b2J1Zi9z",
            "dHJ1Y3QucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8i",
            "ZAoNRXhwb3J0UmVxdWVzdBIYCgdvcHRpb25zGAEgASgNUgdvcHRpb25zEjkK",
            "CnN0YXJ0X2Zyb20YFCABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1w",
            "UglzdGFydEZyb20iygEKDkV4cG9ydFJlc3BvbnNlEjwKBm9iamVjdBgCIAEo",
            "CzIiLmFzZXJ0by5kaXJlY3RvcnkuY29tbW9uLnYzLk9iamVjdEgAUgZvYmpl",
            "Y3QSQgoIcmVsYXRpb24YBCABKAsyJC5hc2VydG8uZGlyZWN0b3J5LmNvbW1v",
            "bi52My5SZWxhdGlvbkgAUghyZWxhdGlvbhIvCgVzdGF0cxgIIAEoCzIXLmdv",
            "b2dsZS5wcm90b2J1Zi5TdHJ1Y3RIAFIFc3RhdHNCBQoDbXNnKnMKBk9wdGlv",
            "bhISCg5PUFRJT05fVU5LTk9XThAAEhcKE09QVElPTl9EQVRBX09CSkVDVFMQ",
            "CBIZChVPUFRJT05fREFUQV9SRUxBVElPTlMQEBIPCgtPUFRJT05fREFUQRAY",
            "EhAKDE9QVElPTl9TVEFUUxBAMnMKCEV4cG9ydGVyEmcKBkV4cG9ydBIrLmFz",
            "ZXJ0by5kaXJlY3RvcnkuZXhwb3J0ZXIudjMuRXhwb3J0UmVxdWVzdBosLmFz",
            "ZXJ0by5kaXJlY3RvcnkuZXhwb3J0ZXIudjMuRXhwb3J0UmVzcG9uc2UiADAB",
            "QpACCiBjb20uYXNlcnRvLmRpcmVjdG9yeS5leHBvcnRlci52M0INRXhwb3J0",
            "ZXJQcm90b1ABWkhnaXRodWIuY29tL2FzZXJ0by1kZXYvZ28tZGlyZWN0b3J5",
            "L2FzZXJ0by9kaXJlY3RvcnkvZXhwb3J0ZXIvdjM7ZXhwb3J0ZXKiAgNBREWq",
            "AhxBc2VydG8uRGlyZWN0b3J5LkV4cG9ydGVyLlYzygIdQXNlcnRvXERpcmVj",
            "dG9yeV9cRXhwb3J0ZXJcVjPiAilBc2VydG9cRGlyZWN0b3J5X1xFeHBvcnRl",
            "clxWM1xHUEJNZXRhZGF0YeoCH0FzZXJ0bzo6RGlyZWN0b3J5OjpFeHBvcnRl",
            "cjo6VjNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Aserto.Directory.Common.V3.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.StructReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Aserto.Directory.Exporter.V3.Option), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aserto.Directory.Exporter.V3.ExportRequest), global::Aserto.Directory.Exporter.V3.ExportRequest.Parser, new[]{ "Options", "StartFrom" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Aserto.Directory.Exporter.V3.ExportResponse), global::Aserto.Directory.Exporter.V3.ExportResponse.Parser, new[]{ "Object", "Relation", "Stats" }, new[]{ "Msg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum Option {
    /// <summary>
    /// nothing selected (default initialization value)
    /// </summary>
    [pbr::OriginalName("OPTION_UNKNOWN")] Unknown = 0,
    /// <summary>
    /// object instances
    /// </summary>
    [pbr::OriginalName("OPTION_DATA_OBJECTS")] DataObjects = 8,
    /// <summary>
    /// relation instances
    /// </summary>
    [pbr::OriginalName("OPTION_DATA_RELATIONS")] DataRelations = 16,
    /// <summary>
    /// all data = OPTION_DATA_OBJECTS | OPTION_DATA_RELATIONS
    /// </summary>
    [pbr::OriginalName("OPTION_DATA")] Data = 24,
    /// <summary>
    /// stats
    /// </summary>
    [pbr::OriginalName("OPTION_STATS")] Stats = 64,
  }

  #endregion

  #region Messages
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
      get { return global::Aserto.Directory.Exporter.V3.ExporterReflection.Descriptor.MessageTypes[0]; }
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
      get { return global::Aserto.Directory.Exporter.V3.ExporterReflection.Descriptor.MessageTypes[1]; }
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
        case MsgOneofCase.Relation:
          Relation = other.Relation.Clone();
          break;
        case MsgOneofCase.Stats:
          Stats = other.Stats.Clone();
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
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aserto.Directory.Common.V3.Object Object {
      get { return msgCase_ == MsgOneofCase.Object ? (global::Aserto.Directory.Common.V3.Object) msg_ : null; }
      set {
        msg_ = value;
        msgCase_ = value == null ? MsgOneofCase.None : MsgOneofCase.Object;
      }
    }

    /// <summary>Field number for the "relation" field.</summary>
    public const int RelationFieldNumber = 4;
    /// <summary>
    /// relation instance (data)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aserto.Directory.Common.V3.Relation Relation {
      get { return msgCase_ == MsgOneofCase.Relation ? (global::Aserto.Directory.Common.V3.Relation) msg_ : null; }
      set {
        msg_ = value;
        msgCase_ = value == null ? MsgOneofCase.None : MsgOneofCase.Relation;
      }
    }

    /// <summary>Field number for the "stats" field.</summary>
    public const int StatsFieldNumber = 8;
    /// <summary>
    /// object and/or relation stats (no data)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Struct Stats {
      get { return msgCase_ == MsgOneofCase.Stats ? (global::Google.Protobuf.WellKnownTypes.Struct) msg_ : null; }
      set {
        msg_ = value;
        msgCase_ = value == null ? MsgOneofCase.None : MsgOneofCase.Stats;
      }
    }

    private object msg_;
    /// <summary>Enum of possible cases for the "msg" oneof.</summary>
    public enum MsgOneofCase {
      None = 0,
      Object = 2,
      Relation = 4,
      Stats = 8,
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
      if (!object.Equals(Relation, other.Relation)) return false;
      if (!object.Equals(Stats, other.Stats)) return false;
      if (MsgCase != other.MsgCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (msgCase_ == MsgOneofCase.Object) hash ^= Object.GetHashCode();
      if (msgCase_ == MsgOneofCase.Relation) hash ^= Relation.GetHashCode();
      if (msgCase_ == MsgOneofCase.Stats) hash ^= Stats.GetHashCode();
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
      if (msgCase_ == MsgOneofCase.Relation) {
        output.WriteRawTag(34);
        output.WriteMessage(Relation);
      }
      if (msgCase_ == MsgOneofCase.Stats) {
        output.WriteRawTag(66);
        output.WriteMessage(Stats);
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
      if (msgCase_ == MsgOneofCase.Relation) {
        output.WriteRawTag(34);
        output.WriteMessage(Relation);
      }
      if (msgCase_ == MsgOneofCase.Stats) {
        output.WriteRawTag(66);
        output.WriteMessage(Stats);
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
      if (msgCase_ == MsgOneofCase.Relation) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Relation);
      }
      if (msgCase_ == MsgOneofCase.Stats) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stats);
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
            Object = new global::Aserto.Directory.Common.V3.Object();
          }
          Object.MergeFrom(other.Object);
          break;
        case MsgOneofCase.Relation:
          if (Relation == null) {
            Relation = new global::Aserto.Directory.Common.V3.Relation();
          }
          Relation.MergeFrom(other.Relation);
          break;
        case MsgOneofCase.Stats:
          if (Stats == null) {
            Stats = new global::Google.Protobuf.WellKnownTypes.Struct();
          }
          Stats.MergeFrom(other.Stats);
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
            global::Aserto.Directory.Common.V3.Object subBuilder = new global::Aserto.Directory.Common.V3.Object();
            if (msgCase_ == MsgOneofCase.Object) {
              subBuilder.MergeFrom(Object);
            }
            input.ReadMessage(subBuilder);
            Object = subBuilder;
            break;
          }
          case 34: {
            global::Aserto.Directory.Common.V3.Relation subBuilder = new global::Aserto.Directory.Common.V3.Relation();
            if (msgCase_ == MsgOneofCase.Relation) {
              subBuilder.MergeFrom(Relation);
            }
            input.ReadMessage(subBuilder);
            Relation = subBuilder;
            break;
          }
          case 66: {
            global::Google.Protobuf.WellKnownTypes.Struct subBuilder = new global::Google.Protobuf.WellKnownTypes.Struct();
            if (msgCase_ == MsgOneofCase.Stats) {
              subBuilder.MergeFrom(Stats);
            }
            input.ReadMessage(subBuilder);
            Stats = subBuilder;
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
            global::Aserto.Directory.Common.V3.Object subBuilder = new global::Aserto.Directory.Common.V3.Object();
            if (msgCase_ == MsgOneofCase.Object) {
              subBuilder.MergeFrom(Object);
            }
            input.ReadMessage(subBuilder);
            Object = subBuilder;
            break;
          }
          case 34: {
            global::Aserto.Directory.Common.V3.Relation subBuilder = new global::Aserto.Directory.Common.V3.Relation();
            if (msgCase_ == MsgOneofCase.Relation) {
              subBuilder.MergeFrom(Relation);
            }
            input.ReadMessage(subBuilder);
            Relation = subBuilder;
            break;
          }
          case 66: {
            global::Google.Protobuf.WellKnownTypes.Struct subBuilder = new global::Google.Protobuf.WellKnownTypes.Struct();
            if (msgCase_ == MsgOneofCase.Stats) {
              subBuilder.MergeFrom(Stats);
            }
            input.ReadMessage(subBuilder);
            Stats = subBuilder;
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
