// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: mysqlx_notice.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mysqlx.Notice {

  /// <summary>Holder for reflection information generated from mysqlx_notice.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class MysqlxNoticeReflection {

    #region Descriptor
    /// <summary>File descriptor for mysqlx_notice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MysqlxNoticeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNteXNxbHhfbm90aWNlLnByb3RvEg1NeXNxbHguTm90aWNlGhZteXNxbHhf",
            "ZGF0YXR5cGVzLnByb3RvInsKBUZyYW1lEgwKBHR5cGUYASABKA0SKQoFc2Nv",
            "cGUYAiABKA4yGi5NeXNxbHguTm90aWNlLkZyYW1lLlNjb3BlEg8KB3BheWxv",
            "YWQYAyABKAwiKAoFU2NvcGUSCAoETk9ORRAAEgoKBkdMT0JBTBABEgkKBUxP",
            "Q0FMEAIihgEKB1dhcm5pbmcSKwoFbGV2ZWwYASABKA4yHC5NeXNxbHguTm90",
            "aWNlLldhcm5pbmcuTGV2ZWwSDAoEY29kZRgCIAEoDRILCgNtc2cYAyABKAki",
            "MwoFTGV2ZWwSCAoETk9ORRAAEggKBE5PVEUQARILCgdXQVJOSU5HEAISCQoF",
            "RVJST1IQAyJQChZTZXNzaW9uVmFyaWFibGVDaGFuZ2VkEg0KBXBhcmFtGAEg",
            "ASgJEicKBXZhbHVlGAIgASgLMhguTXlzcWx4LkRhdGF0eXBlcy5TY2FsYXIi",
            "3wIKE1Nlc3Npb25TdGF0ZUNoYW5nZWQSOwoFcGFyYW0YASABKA4yLC5NeXNx",
            "bHguTm90aWNlLlNlc3Npb25TdGF0ZUNoYW5nZWQuUGFyYW1ldGVyEicKBXZh",
            "bHVlGAIgASgLMhguTXlzcWx4LkRhdGF0eXBlcy5TY2FsYXIi4QEKCVBhcmFt",
            "ZXRlchIICgROT05FEAASEgoOQ1VSUkVOVF9TQ0hFTUEQARITCg9BQ0NPVU5U",
            "X0VYUElSRUQQAhIXChNHRU5FUkFURURfSU5TRVJUX0lEEAMSEQoNUk9XU19B",
            "RkZFQ1RFRBAEEg4KClJPV1NfRk9VTkQQBRIQCgxST1dTX01BVENIRUQQBhIR",
            "Cg1UUlhfQ09NTUlUVEVEEAcSEgoOVFJYX1JPTExFREJBQ0sQCRIUChBQUk9E",
            "VUNFRF9NRVNTQUdFEAoSFgoSQ0xJRU5UX0lEX0FTU0lHTkVEEAtCHgocY29t",
            "Lm15c3FsLmNqLm15c3FseC5wcm90b2J1ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mysqlx.Datatypes.MysqlxDatatypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Notice.Frame), global::Mysqlx.Notice.Frame.Parser, new[]{ "Type", "Scope", "Payload" }, null, new[]{ typeof(global::Mysqlx.Notice.Frame.Types.Scope) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Notice.Warning), global::Mysqlx.Notice.Warning.Parser, new[]{ "Level", "Code", "Msg" }, null, new[]{ typeof(global::Mysqlx.Notice.Warning.Types.Level) }, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Notice.SessionVariableChanged), global::Mysqlx.Notice.SessionVariableChanged.Parser, new[]{ "Param", "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Notice.SessionStateChanged), global::Mysqlx.Notice.SessionStateChanged.Parser, new[]{ "Param", "Value" }, null, new[]{ typeof(global::Mysqlx.Notice.SessionStateChanged.Types.Parameter) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  Common Frame for all Notices
  ///
  ///  ===================================================== =====
  ///  .type                                                 value
  ///  ===================================================== =====
  ///  :protobuf:msg:`Mysqlx.Notice::Warning`                1
  ///  :protobuf:msg:`Mysqlx.Notice::SessionVariableChanged` 2
  ///  :protobuf:msg:`Mysqlx.Notice::SessionStateChanged`    3
  ///  ===================================================== =====
  ///
  ///  :param type: the type of the payload
  ///  :param payload: the payload of the notification
  ///  :param scope: global or local notification
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Frame : pb::IMessage<Frame> {
    private static readonly pb::MessageParser<Frame> _parser = new pb::MessageParser<Frame>(() => new Frame());
    public static pb::MessageParser<Frame> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Notice.MysqlxNoticeReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Frame() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Frame(Frame other) : this() {
      type_ = other.type_;
      scope_ = other.scope_;
      payload_ = other.payload_;
    }

    public Frame Clone() {
      return new Frame(this);
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 1;
    private uint type_;
    /// <summary>
    /// required
    /// </summary>
    public uint Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "scope" field.</summary>
    public const int ScopeFieldNumber = 2;
    private global::Mysqlx.Notice.Frame.Types.Scope scope_ = 0;
    public global::Mysqlx.Notice.Frame.Types.Scope Scope {
      get { return scope_; }
      set {
        scope_ = value;
      }
    }

    /// <summary>Field number for the "payload" field.</summary>
    public const int PayloadFieldNumber = 3;
    private pb::ByteString payload_ = pb::ByteString.Empty;
    public pb::ByteString Payload {
      get { return payload_; }
      set {
        payload_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Frame);
    }

    public bool Equals(Frame other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Type != other.Type) return false;
      if (Scope != other.Scope) return false;
      if (Payload != other.Payload) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Type != 0) hash ^= Type.GetHashCode();
      if (Scope != 0) hash ^= Scope.GetHashCode();
      if (Payload.Length != 0) hash ^= Payload.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Type != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Type);
      }
      if (Scope != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Scope);
      }
      if (Payload.Length != 0) {
        output.WriteRawTag(26);
        output.WriteBytes(Payload);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Type);
      }
      if (Scope != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Scope);
      }
      if (Payload.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Payload);
      }
      return size;
    }

    public void MergeFrom(Frame other) {
      if (other == null) {
        return;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.Scope != 0) {
        Scope = other.Scope;
      }
      if (other.Payload.Length != 0) {
        Payload = other.Payload;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Type = input.ReadUInt32();
            break;
          }
          case 16: {
            scope_ = (global::Mysqlx.Notice.Frame.Types.Scope) input.ReadEnum();
            break;
          }
          case 26: {
            Payload = input.ReadBytes();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Frame message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Scope {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("GLOBAL")] Global = 1,
        [pbr::OriginalName("LOCAL")] Local = 2,
      }

    }
    #endregion

  }

  /// <summary>
  ///  Server-side warnings and notes
  ///
  ///  ``.scope`` == ``local``
  ///    ``.level``, ``.code`` and ``.msg`` map the content of
  ///
  ///    .. code-block:: sql
  ///
  ///      SHOW WARNINGS
  ///
  ///  ``.scope`` == ``global``
  ///    (undefined) will be used for global, unstructured messages like:
  ///
  ///    * server is shutting down
  ///    * a node disconnected from group
  ///    * schema or table dropped
  ///
  ///  ========================================== =======================
  ///  :protobuf:msg:`Mysqlx.Notice::Frame` field value
  ///  ========================================== =======================
  ///  ``.type``                                  1
  ///  ``.scope``                                 ``local`` or ``global``
  ///  ========================================== =======================
  ///
  ///  :param level: warning level: Note or Warning
  ///  :param code: warning code
  ///  :param msg: warning message
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Warning : pb::IMessage<Warning> {
    private static readonly pb::MessageParser<Warning> _parser = new pb::MessageParser<Warning>(() => new Warning());
    public static pb::MessageParser<Warning> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Notice.MysqlxNoticeReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Warning() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Warning(Warning other) : this() {
      level_ = other.level_;
      code_ = other.code_;
      msg_ = other.msg_;
    }

    public Warning Clone() {
      return new Warning(this);
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 1;
    private global::Mysqlx.Notice.Warning.Types.Level level_ = 0;
    public global::Mysqlx.Notice.Warning.Types.Level Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 2;
    private uint code_;
    /// <summary>
    /// required
    /// </summary>
    public uint Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 3;
    private string msg_ = "";
    /// <summary>
    /// required
    /// </summary>
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Warning);
    }

    public bool Equals(Warning other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Level != other.Level) return false;
      if (Code != other.Code) return false;
      if (Msg != other.Msg) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Level != 0) hash ^= Level.GetHashCode();
      if (Code != 0) hash ^= Code.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Level != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Level);
      }
      if (Code != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(Code);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Msg);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Level);
      }
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Code);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      return size;
    }

    public void MergeFrom(Warning other) {
      if (other == null) {
        return;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            level_ = (global::Mysqlx.Notice.Warning.Types.Level) input.ReadEnum();
            break;
          }
          case 16: {
            Code = input.ReadUInt32();
            break;
          }
          case 26: {
            Msg = input.ReadString();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Warning message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Level {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("NOTE")] Note = 1,
        [pbr::OriginalName("WARNING")] Warning = 2,
        [pbr::OriginalName("ERROR")] Error = 3,
      }

    }
    #endregion

  }

  /// <summary>
  ///  Notify clients about changes to the current session variables
  ///
  ///  Every change to a variable that is accessable through:
  ///
  ///  .. code-block:: sql
  ///
  ///    SHOW SESSION VARIABLES
  ///
  ///  ========================================== =========
  ///  :protobuf:msg:`Mysqlx.Notice::Frame` field value
  ///  ========================================== =========
  ///  ``.type``                                  2
  ///  ``.scope``                                 ``local``
  ///  ========================================== =========
  ///
  ///  :param namespace: namespace that param belongs to
  ///  :param param: name of the variable
  ///  :param value: the changed value of param
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SessionVariableChanged : pb::IMessage<SessionVariableChanged> {
    private static readonly pb::MessageParser<SessionVariableChanged> _parser = new pb::MessageParser<SessionVariableChanged>(() => new SessionVariableChanged());
    public static pb::MessageParser<SessionVariableChanged> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Notice.MysqlxNoticeReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SessionVariableChanged() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SessionVariableChanged(SessionVariableChanged other) : this() {
      param_ = other.param_;
      Value = other.value_ != null ? other.Value.Clone() : null;
    }

    public SessionVariableChanged Clone() {
      return new SessionVariableChanged(this);
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 1;
    private string param_ = "";
    /// <summary>
    /// required
    /// </summary>
    public string Param {
      get { return param_; }
      set {
        param_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::Mysqlx.Datatypes.Scalar value_;
    public global::Mysqlx.Datatypes.Scalar Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SessionVariableChanged);
    }

    public bool Equals(SessionVariableChanged other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Param != other.Param) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Param.Length != 0) hash ^= Param.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Param.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Param);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Param.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Param);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      return size;
    }

    public void MergeFrom(SessionVariableChanged other) {
      if (other == null) {
        return;
      }
      if (other.Param.Length != 0) {
        Param = other.Param;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          value_ = new global::Mysqlx.Datatypes.Scalar();
        }
        Value.MergeFrom(other.Value);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Param = input.ReadString();
            break;
          }
          case 18: {
            if (value_ == null) {
              value_ = new global::Mysqlx.Datatypes.Scalar();
            }
            input.ReadMessage(value_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Notify clients about changes to the internal session state
  ///
  ///  ========================================== =========
  ///  :protobuf:msg:`Mysqlx.Notice::Frame` field value
  ///  ========================================== =========
  ///  ``.type``                                  3
  ///  ``.scope``                                 ``local``
  ///  ========================================== =========
  ///
  ///  :param param: parameter key
  ///  :param value: updated value
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SessionStateChanged : pb::IMessage<SessionStateChanged> {
    private static readonly pb::MessageParser<SessionStateChanged> _parser = new pb::MessageParser<SessionStateChanged>(() => new SessionStateChanged());
    public static pb::MessageParser<SessionStateChanged> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Notice.MysqlxNoticeReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SessionStateChanged() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SessionStateChanged(SessionStateChanged other) : this() {
      param_ = other.param_;
      Value = other.value_ != null ? other.Value.Clone() : null;
    }

    public SessionStateChanged Clone() {
      return new SessionStateChanged(this);
    }

    /// <summary>Field number for the "param" field.</summary>
    public const int ParamFieldNumber = 1;
    private global::Mysqlx.Notice.SessionStateChanged.Types.Parameter param_ = 0;
    /// <summary>
    /// required
    /// </summary>
    public global::Mysqlx.Notice.SessionStateChanged.Types.Parameter Param {
      get { return param_; }
      set {
        param_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::Mysqlx.Datatypes.Scalar value_;
    public global::Mysqlx.Datatypes.Scalar Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SessionStateChanged);
    }

    public bool Equals(SessionStateChanged other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Param != other.Param) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Param != 0) hash ^= Param.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Param != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Param);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Param != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Param);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      return size;
    }

    public void MergeFrom(SessionStateChanged other) {
      if (other == null) {
        return;
      }
      if (other.Param != 0) {
        Param = other.Param;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          value_ = new global::Mysqlx.Datatypes.Scalar();
        }
        Value.MergeFrom(other.Value);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            param_ = (global::Mysqlx.Notice.SessionStateChanged.Types.Parameter) input.ReadEnum();
            break;
          }
          case 18: {
            if (value_ == null) {
              value_ = new global::Mysqlx.Datatypes.Scalar();
            }
            input.ReadMessage(value_);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the SessionStateChanged message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Parameter {
        [pbr::OriginalName("NONE")] None = 0,
        [pbr::OriginalName("CURRENT_SCHEMA")] CurrentSchema = 1,
        [pbr::OriginalName("ACCOUNT_EXPIRED")] AccountExpired = 2,
        [pbr::OriginalName("GENERATED_INSERT_ID")] GeneratedInsertId = 3,
        [pbr::OriginalName("ROWS_AFFECTED")] RowsAffected = 4,
        [pbr::OriginalName("ROWS_FOUND")] RowsFound = 5,
        [pbr::OriginalName("ROWS_MATCHED")] RowsMatched = 6,
        [pbr::OriginalName("TRX_COMMITTED")] TrxCommitted = 7,
        [pbr::OriginalName("TRX_ROLLEDBACK")] TrxRolledback = 9,
        [pbr::OriginalName("PRODUCED_MESSAGE")] ProducedMessage = 10,
        /// <summary>
        ///  .. more to be added
        /// </summary>
        [pbr::OriginalName("CLIENT_ID_ASSIGNED")] ClientIdAssigned = 11,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
