// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/directory/schema/v2/identity.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aserto.Directory.Schema.V2 {

  /// <summary>Holder for reflection information generated from aserto/directory/schema/v2/identity.proto</summary>
  public static partial class IdentityReflection {

    #region Descriptor
    /// <summary>File descriptor for aserto/directory/schema/v2/identity.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static IdentityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilhc2VydG8vZGlyZWN0b3J5L3NjaGVtYS92Mi9pZGVudGl0eS5wcm90bxIa",
            "YXNlcnRvLmRpcmVjdG9yeS5zY2hlbWEudjIingEKEklkZW50aXR5UHJvcGVy",
            "dGllcxI2CgRraW5kGAEgASgOMiguYXNlcnRvLmRpcmVjdG9yeS5zY2hlbWEu",
            "djIuSWRlbnRpdHlLaW5kEhAKCHByb3ZpZGVyGAIgASgJEhAKCHZlcmlmaWVk",
            "GAMgASgIEhoKDWNvbm5lY3Rpb25faWQYBCABKAlIAIgBAUIQCg5fY29ubmVj",
            "dGlvbl9pZCq9AQoMSWRlbnRpdHlLaW5kEhkKFUlERU5USVRZX0tJTkRfVU5L",
            "Tk9XThAAEhUKEUlERU5USVRZX0tJTkRfUElEEAESFwoTSURFTlRJVFlfS0lO",
            "RF9FTUFJTBACEhoKFklERU5USVRZX0tJTkRfVVNFUk5BTUUQAxIUChBJREVO",
            "VElUWV9LSU5EX0ROEAQSFwoTSURFTlRJVFlfS0lORF9QSE9ORRAFEhcKE0lE",
            "RU5USVRZX0tJTkRfRU1QSUQQBkJGWkRnaXRodWIuY29tL2FzZXJ0by1kZXYv",
            "Z28tZGlyZWN0b3J5L2FzZXJ0by9kaXJlY3Rvcnkvc2NoZW1hL3YyO3NjaGVt",
            "YWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Aserto.Directory.Schema.V2.IdentityKind), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aserto.Directory.Schema.V2.IdentityProperties), global::Aserto.Directory.Schema.V2.IdentityProperties.Parser, new[]{ "Kind", "Provider", "Verified", "ConnectionId" }, new[]{ "ConnectionId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum IdentityKind {
    /// <summary>
    /// undefined state
    /// </summary>
    [pbr::OriginalName("IDENTITY_KIND_UNKNOWN")] Unknown = 0,
    /// <summary>
    /// provider unique identifier
    /// </summary>
    [pbr::OriginalName("IDENTITY_KIND_PID")] Pid = 1,
    /// <summary>
    /// email address
    /// </summary>
    [pbr::OriginalName("IDENTITY_KIND_EMAIL")] Email = 2,
    /// <summary>
    /// username
    /// </summary>
    [pbr::OriginalName("IDENTITY_KIND_USERNAME")] Username = 3,
    /// <summary>
    /// distinguished name format RFC1779
    /// </summary>
    [pbr::OriginalName("IDENTITY_KIND_DN")] Dn = 4,
    /// <summary>
    /// phone number using the format described in RFC3966, using the E.164 recommendation
    /// </summary>
    [pbr::OriginalName("IDENTITY_KIND_PHONE")] Phone = 5,
    /// <summary>
    /// employee identifier
    /// </summary>
    [pbr::OriginalName("IDENTITY_KIND_EMPID")] Empid = 6,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Properties of "identity" objects.
  /// </summary>
  public sealed partial class IdentityProperties : pb::IMessage<IdentityProperties>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<IdentityProperties> _parser = new pb::MessageParser<IdentityProperties>(() => new IdentityProperties());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdentityProperties> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aserto.Directory.Schema.V2.IdentityReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdentityProperties() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdentityProperties(IdentityProperties other) : this() {
      kind_ = other.kind_;
      provider_ = other.provider_;
      verified_ = other.verified_;
      connectionId_ = other.connectionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdentityProperties Clone() {
      return new IdentityProperties(this);
    }

    /// <summary>Field number for the "kind" field.</summary>
    public const int KindFieldNumber = 1;
    private global::Aserto.Directory.Schema.V2.IdentityKind kind_ = global::Aserto.Directory.Schema.V2.IdentityKind.Unknown;
    /// <summary>
    /// identity kind [email|username|uid|pid|dn|phone]
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Aserto.Directory.Schema.V2.IdentityKind Kind {
      get { return kind_; }
      set {
        kind_ = value;
      }
    }

    /// <summary>Field number for the "provider" field.</summary>
    public const int ProviderFieldNumber = 2;
    private string provider_ = "";
    /// <summary>
    /// identity provider name
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Provider {
      get { return provider_; }
      set {
        provider_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "verified" field.</summary>
    public const int VerifiedFieldNumber = 3;
    private bool verified_;
    /// <summary>
    /// identity has been verified (false when not explicitly specified)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Verified {
      get { return verified_; }
      set {
        verified_ = value;
      }
    }

    /// <summary>Field number for the "connection_id" field.</summary>
    public const int ConnectionIdFieldNumber = 4;
    private string connectionId_;
    /// <summary>
    /// IDP connection id which owns the object instance
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ConnectionId {
      get { return connectionId_ ?? ""; }
      set {
        connectionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "connection_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasConnectionId {
      get { return connectionId_ != null; }
    }
    /// <summary>Clears the value of the "connection_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearConnectionId() {
      connectionId_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IdentityProperties);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdentityProperties other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Kind != other.Kind) return false;
      if (Provider != other.Provider) return false;
      if (Verified != other.Verified) return false;
      if (ConnectionId != other.ConnectionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Kind != global::Aserto.Directory.Schema.V2.IdentityKind.Unknown) hash ^= Kind.GetHashCode();
      if (Provider.Length != 0) hash ^= Provider.GetHashCode();
      if (Verified != false) hash ^= Verified.GetHashCode();
      if (HasConnectionId) hash ^= ConnectionId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Kind != global::Aserto.Directory.Schema.V2.IdentityKind.Unknown) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Kind);
      }
      if (Provider.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Provider);
      }
      if (Verified != false) {
        output.WriteRawTag(24);
        output.WriteBool(Verified);
      }
      if (HasConnectionId) {
        output.WriteRawTag(34);
        output.WriteString(ConnectionId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Kind != global::Aserto.Directory.Schema.V2.IdentityKind.Unknown) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Kind);
      }
      if (Provider.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Provider);
      }
      if (Verified != false) {
        output.WriteRawTag(24);
        output.WriteBool(Verified);
      }
      if (HasConnectionId) {
        output.WriteRawTag(34);
        output.WriteString(ConnectionId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Kind != global::Aserto.Directory.Schema.V2.IdentityKind.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Kind);
      }
      if (Provider.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Provider);
      }
      if (Verified != false) {
        size += 1 + 1;
      }
      if (HasConnectionId) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConnectionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IdentityProperties other) {
      if (other == null) {
        return;
      }
      if (other.Kind != global::Aserto.Directory.Schema.V2.IdentityKind.Unknown) {
        Kind = other.Kind;
      }
      if (other.Provider.Length != 0) {
        Provider = other.Provider;
      }
      if (other.Verified != false) {
        Verified = other.Verified;
      }
      if (other.HasConnectionId) {
        ConnectionId = other.ConnectionId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Kind = (global::Aserto.Directory.Schema.V2.IdentityKind) input.ReadEnum();
            break;
          }
          case 18: {
            Provider = input.ReadString();
            break;
          }
          case 24: {
            Verified = input.ReadBool();
            break;
          }
          case 34: {
            ConnectionId = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Kind = (global::Aserto.Directory.Schema.V2.IdentityKind) input.ReadEnum();
            break;
          }
          case 18: {
            Provider = input.ReadString();
            break;
          }
          case 24: {
            Verified = input.ReadBool();
            break;
          }
          case 34: {
            ConnectionId = input.ReadString();
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
