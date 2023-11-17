// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: aserto/directory/schema/v3/user.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Aserto.Directory.Schema.V3 {

  /// <summary>Holder for reflection information generated from aserto/directory/schema/v3/user.proto</summary>
  public static partial class UserReflection {

    #region Descriptor
    /// <summary>File descriptor for aserto/directory/schema/v3/user.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static UserReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVhc2VydG8vZGlyZWN0b3J5L3NjaGVtYS92My91c2VyLnByb3RvEhphc2Vy",
            "dG8uZGlyZWN0b3J5LnNjaGVtYS52MyK/AQoOVXNlclByb3BlcnRpZXMSFAoF",
            "ZW1haWwYASABKAlSBWVtYWlsEhgKB3BpY3R1cmUYAiABKAlSB3BpY3R1cmUS",
            "PgoGc3RhdHVzGAMgASgOMiYuYXNlcnRvLmRpcmVjdG9yeS5zY2hlbWEudjMu",
            "VXNlclN0YXR1c1IGc3RhdHVzEhgKB2VuYWJsZWQYBCABKAhSB2VuYWJsZWQS",
            "IwoNY29ubmVjdGlvbl9pZBgFIAEoCVIMY29ubmVjdGlvbklkKoQCCgpVc2Vy",
            "U3RhdHVzEhcKE1VTRVJfU1RBVFVTX1VOS05PV04QABIWChJVU0VSX1NUQVRV",
            "U19TVEFHRUQQARIbChdVU0VSX1NUQVRVU19QUk9WSVNJT05FRBACEhYKElVT",
            "RVJfU1RBVFVTX0FDVElWRRADEhgKFFVTRVJfU1RBVFVTX1JFQ09WRVJZEAQS",
            "IAocVVNFUl9TVEFUVVNfUEFTU1dPUkRfRVhQSVJFRBAFEhoKFlVTRVJfU1RB",
            "VFVTX0xPQ0tFRF9PVVQQBhIZChVVU0VSX1NUQVRVU19TVVNQRU5ERUQQBxId",
            "ChlVU0VSX1NUQVRVU19ERVBST1ZJU0lPTkVEEAhC/gEKHmNvbS5hc2VydG8u",
            "ZGlyZWN0b3J5LnNjaGVtYS52M0IJVXNlclByb3RvUAFaRGdpdGh1Yi5jb20v",
            "YXNlcnRvLWRldi9nby1kaXJlY3RvcnkvYXNlcnRvL2RpcmVjdG9yeS9zY2hl",
            "bWEvdjM7c2NoZW1hogIDQURTqgIaQXNlcnRvLkRpcmVjdG9yeS5TY2hlbWEu",
            "VjPKAhtBc2VydG9cRGlyZWN0b3J5X1xTY2hlbWFcVjPiAidBc2VydG9cRGly",
            "ZWN0b3J5X1xTY2hlbWFcVjNcR1BCTWV0YWRhdGHqAh1Bc2VydG86OkRpcmVj",
            "dG9yeTo6U2NoZW1hOjpWM2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Aserto.Directory.Schema.V3.UserStatus), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Aserto.Directory.Schema.V3.UserProperties), global::Aserto.Directory.Schema.V3.UserProperties.Parser, new[]{ "Email", "Picture", "Status", "Enabled", "ConnectionId" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum UserStatus {
    /// <summary>
    /// User status undefined
    /// </summary>
    [pbr::OriginalName("USER_STATUS_UNKNOWN")] Unknown = 0,
    /// <summary>
    /// Staged status, is when the user object is first created, before the activation flow is initiated, or if there is a pending admin action.
    /// </summary>
    [pbr::OriginalName("USER_STATUS_STAGED")] Staged = 1,
    /// <summary>
    /// Provisioned status, is when the user object is provisioned, but the user has not provided verification by clicking through the activation email or provided a password.
    /// </summary>
    [pbr::OriginalName("USER_STATUS_PROVISIONED")] Provisioned = 2,
    /// <summary>
    /// Active status, is when:
    ///  * An admin adds a user and sets the user password without requiring email verification.
    ///  * An admin adds a user, sets the user password, and requires the user to set their password when they first sign-in.
    ///  * A user self-registers into a custom app or IDP and email verification is not required.
    ///  * An admin explicitly activates the user.
    /// </summary>
    [pbr::OriginalName("USER_STATUS_ACTIVE")] Active = 3,
    /// <summary>
    /// Recovery status, when the user requests a password reset or an admin initiates one on their behalf.
    /// </summary>
    [pbr::OriginalName("USER_STATUS_RECOVERY")] Recovery = 4,
    /// <summary>
    /// Password expired, status when the users' password has expired and the account requires an update to the password before a user is granted access.
    /// </summary>
    [pbr::OriginalName("USER_STATUS_PASSWORD_EXPIRED")] PasswordExpired = 5,
    /// <summary>
    /// Locked out status, is when the user exceeds the number of login attempts defined in the login policy.
    /// </summary>
    [pbr::OriginalName("USER_STATUS_LOCKED_OUT")] LockedOut = 6,
    /// <summary>
    /// Suspended status, when an admin explicitly suspends the user account.
    /// </summary>
    [pbr::OriginalName("USER_STATUS_SUSPENDED")] Suspended = 7,
    /// <summary>
    /// Deprovisioned status, is when an administrator explicitly deactivates or deprovisions/deletes the account.
    /// </summary>
    [pbr::OriginalName("USER_STATUS_DEPROVISIONED")] Deprovisioned = 8,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Properties of "user" objects.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class UserProperties : pb::IMessage<UserProperties>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<UserProperties> _parser = new pb::MessageParser<UserProperties>(() => new UserProperties());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<UserProperties> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Aserto.Directory.Schema.V3.UserReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserProperties() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserProperties(UserProperties other) : this() {
      email_ = other.email_;
      picture_ = other.picture_;
      status_ = other.status_;
      enabled_ = other.enabled_;
      connectionId_ = other.connectionId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public UserProperties Clone() {
      return new UserProperties(this);
    }

    /// <summary>Field number for the "email" field.</summary>
    public const int EmailFieldNumber = 1;
    private string email_ = "";
    /// <summary>
    /// main email address of user
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Email {
      get { return email_; }
      set {
        email_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "picture" field.</summary>
    public const int PictureFieldNumber = 2;
    private string picture_ = "";
    /// <summary>
    /// URL to user's picture
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Picture {
      get { return picture_; }
      set {
        picture_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 3;
    private global::Aserto.Directory.Schema.V3.UserStatus status_ = global::Aserto.Directory.Schema.V3.UserStatus.Unknown;
    /// <summary>
    /// user lifecycle status
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Aserto.Directory.Schema.V3.UserStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    /// <summary>Field number for the "enabled" field.</summary>
    public const int EnabledFieldNumber = 4;
    private bool enabled_;
    /// <summary>
    /// enabled (false prevents the user from accessing anything)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Enabled {
      get { return enabled_; }
      set {
        enabled_ = value;
      }
    }

    /// <summary>Field number for the "connection_id" field.</summary>
    public const int ConnectionIdFieldNumber = 5;
    private string connectionId_ = "";
    /// <summary>
    /// ID of the IDP connection the user instance is associated with.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ConnectionId {
      get { return connectionId_; }
      set {
        connectionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as UserProperties);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(UserProperties other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Email != other.Email) return false;
      if (Picture != other.Picture) return false;
      if (Status != other.Status) return false;
      if (Enabled != other.Enabled) return false;
      if (ConnectionId != other.ConnectionId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Email.Length != 0) hash ^= Email.GetHashCode();
      if (Picture.Length != 0) hash ^= Picture.GetHashCode();
      if (Status != global::Aserto.Directory.Schema.V3.UserStatus.Unknown) hash ^= Status.GetHashCode();
      if (Enabled != false) hash ^= Enabled.GetHashCode();
      if (ConnectionId.Length != 0) hash ^= ConnectionId.GetHashCode();
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
      if (Email.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Email);
      }
      if (Picture.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Picture);
      }
      if (Status != global::Aserto.Directory.Schema.V3.UserStatus.Unknown) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Enabled != false) {
        output.WriteRawTag(32);
        output.WriteBool(Enabled);
      }
      if (ConnectionId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ConnectionId);
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
      if (Email.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Email);
      }
      if (Picture.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Picture);
      }
      if (Status != global::Aserto.Directory.Schema.V3.UserStatus.Unknown) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Status);
      }
      if (Enabled != false) {
        output.WriteRawTag(32);
        output.WriteBool(Enabled);
      }
      if (ConnectionId.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ConnectionId);
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
      if (Email.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Email);
      }
      if (Picture.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Picture);
      }
      if (Status != global::Aserto.Directory.Schema.V3.UserStatus.Unknown) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (Enabled != false) {
        size += 1 + 1;
      }
      if (ConnectionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ConnectionId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(UserProperties other) {
      if (other == null) {
        return;
      }
      if (other.Email.Length != 0) {
        Email = other.Email;
      }
      if (other.Picture.Length != 0) {
        Picture = other.Picture;
      }
      if (other.Status != global::Aserto.Directory.Schema.V3.UserStatus.Unknown) {
        Status = other.Status;
      }
      if (other.Enabled != false) {
        Enabled = other.Enabled;
      }
      if (other.ConnectionId.Length != 0) {
        ConnectionId = other.ConnectionId;
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Email = input.ReadString();
            break;
          }
          case 18: {
            Picture = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Aserto.Directory.Schema.V3.UserStatus) input.ReadEnum();
            break;
          }
          case 32: {
            Enabled = input.ReadBool();
            break;
          }
          case 42: {
            ConnectionId = input.ReadString();
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Email = input.ReadString();
            break;
          }
          case 18: {
            Picture = input.ReadString();
            break;
          }
          case 24: {
            Status = (global::Aserto.Directory.Schema.V3.UserStatus) input.ReadEnum();
            break;
          }
          case 32: {
            Enabled = input.ReadBool();
            break;
          }
          case 42: {
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
