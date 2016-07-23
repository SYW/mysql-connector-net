// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: mysqlx_connection.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Mysqlx.Connection {

  /// <summary>Holder for reflection information generated from mysqlx_connection.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class MysqlxConnectionReflection {

    #region Descriptor
    /// <summary>File descriptor for mysqlx_connection.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MysqlxConnectionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdteXNxbHhfY29ubmVjdGlvbi5wcm90bxIRTXlzcWx4LkNvbm5lY3Rpb24a",
            "Fm15c3FseF9kYXRhdHlwZXMucHJvdG8iQAoKQ2FwYWJpbGl0eRIMCgRuYW1l",
            "GAEgASgJEiQKBXZhbHVlGAIgASgLMhUuTXlzcWx4LkRhdGF0eXBlcy5Bbnki",
            "QwoMQ2FwYWJpbGl0aWVzEjMKDGNhcGFiaWxpdGllcxgBIAMoCzIdLk15c3Fs",
            "eC5Db25uZWN0aW9uLkNhcGFiaWxpdHkiEQoPQ2FwYWJpbGl0aWVzR2V0IkgK",
            "D0NhcGFiaWxpdGllc1NldBI1CgxjYXBhYmlsaXRpZXMYASABKAsyHy5NeXNx",
            "bHguQ29ubmVjdGlvbi5DYXBhYmlsaXRpZXMiBwoFQ2xvc2VCHgocY29tLm15",
            "c3FsLmNqLm15c3FseC5wcm90b2J1ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Mysqlx.Datatypes.MysqlxDatatypesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Connection.Capability), global::Mysqlx.Connection.Capability.Parser, new[]{ "Name", "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Connection.Capabilities), global::Mysqlx.Connection.Capabilities.Parser, new[]{ "Capabilities_" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Connection.CapabilitiesGet), global::Mysqlx.Connection.CapabilitiesGet.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Connection.CapabilitiesSet), global::Mysqlx.Connection.CapabilitiesSet.Parser, new[]{ "Capabilities" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Mysqlx.Connection.Close), global::Mysqlx.Connection.Close.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  a Capability
  ///
  ///  a tuple of a ``name`` and a :protobuf:msg:`Mysqlx.Datatypes::Any`
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Capability : pb::IMessage<Capability> {
    private static readonly pb::MessageParser<Capability> _parser = new pb::MessageParser<Capability>(() => new Capability());
    public static pb::MessageParser<Capability> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Connection.MysqlxConnectionReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Capability() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Capability(Capability other) : this() {
      name_ = other.name_;
      Value = other.value_ != null ? other.Value.Clone() : null;
    }

    public Capability Clone() {
      return new Capability(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// required
    /// </summary>
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::Mysqlx.Datatypes.Any value_;
    /// <summary>
    /// required
    /// </summary>
    public global::Mysqlx.Datatypes.Any Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as Capability);
    }

    public bool Equals(Capability other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      return size;
    }

    public void MergeFrom(Capability other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.value_ != null) {
        if (value_ == null) {
          value_ = new global::Mysqlx.Datatypes.Any();
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (value_ == null) {
              value_ = new global::Mysqlx.Datatypes.Any();
            }
            input.ReadMessage(value_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  Capabilities
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Capabilities : pb::IMessage<Capabilities> {
    private static readonly pb::MessageParser<Capabilities> _parser = new pb::MessageParser<Capabilities>(() => new Capabilities());
    public static pb::MessageParser<Capabilities> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Connection.MysqlxConnectionReflection.Descriptor.MessageTypes[1]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Capabilities() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Capabilities(Capabilities other) : this() {
      capabilities_ = other.capabilities_.Clone();
    }

    public Capabilities Clone() {
      return new Capabilities(this);
    }

    /// <summary>Field number for the "capabilities" field.</summary>
    public const int Capabilities_FieldNumber = 1;
    private static readonly pb::FieldCodec<global::Mysqlx.Connection.Capability> _repeated_capabilities_codec
        = pb::FieldCodec.ForMessage(10, global::Mysqlx.Connection.Capability.Parser);
    private readonly pbc::RepeatedField<global::Mysqlx.Connection.Capability> capabilities_ = new pbc::RepeatedField<global::Mysqlx.Connection.Capability>();
    public pbc::RepeatedField<global::Mysqlx.Connection.Capability> Capabilities_ {
      get { return capabilities_; }
    }

    public override bool Equals(object other) {
      return Equals(other as Capabilities);
    }

    public bool Equals(Capabilities other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!capabilities_.Equals(other.capabilities_)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      hash ^= capabilities_.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      capabilities_.WriteTo(output, _repeated_capabilities_codec);
    }

    public int CalculateSize() {
      int size = 0;
      size += capabilities_.CalculateSize(_repeated_capabilities_codec);
      return size;
    }

    public void MergeFrom(Capabilities other) {
      if (other == null) {
        return;
      }
      capabilities_.Add(other.capabilities_);
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            capabilities_.AddEntriesFrom(input, _repeated_capabilities_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  get supported connection capabilities and their current state
  ///
  ///    :returns: :protobuf:msg:`Mysqlx.Connection::Capabilities` or :protobuf:msg:`Mysqlx::Error`
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CapabilitiesGet : pb::IMessage<CapabilitiesGet> {
    private static readonly pb::MessageParser<CapabilitiesGet> _parser = new pb::MessageParser<CapabilitiesGet>(() => new CapabilitiesGet());
    public static pb::MessageParser<CapabilitiesGet> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Connection.MysqlxConnectionReflection.Descriptor.MessageTypes[2]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CapabilitiesGet() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CapabilitiesGet(CapabilitiesGet other) : this() {
    }

    public CapabilitiesGet Clone() {
      return new CapabilitiesGet(this);
    }

    public override bool Equals(object other) {
      return Equals(other as CapabilitiesGet);
    }

    public bool Equals(CapabilitiesGet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(CapabilitiesGet other) {
      if (other == null) {
        return;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  /// <summary>
  ///  sets connection capabilities atomically
  ///
  ///  only provided values are changed, other values are left unchanged.
  ///  If any of the changes fails, all changes are discarded.
  ///
  ///  :precond: active sessions == 0
  ///  :returns: :protobuf:msg:`Mysqlx::Ok` or :protobuf:msg:`Mysqlx::Error`
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CapabilitiesSet : pb::IMessage<CapabilitiesSet> {
    private static readonly pb::MessageParser<CapabilitiesSet> _parser = new pb::MessageParser<CapabilitiesSet>(() => new CapabilitiesSet());
    public static pb::MessageParser<CapabilitiesSet> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Connection.MysqlxConnectionReflection.Descriptor.MessageTypes[3]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CapabilitiesSet() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CapabilitiesSet(CapabilitiesSet other) : this() {
      Capabilities = other.capabilities_ != null ? other.Capabilities.Clone() : null;
    }

    public CapabilitiesSet Clone() {
      return new CapabilitiesSet(this);
    }

    /// <summary>Field number for the "capabilities" field.</summary>
    public const int CapabilitiesFieldNumber = 1;
    private global::Mysqlx.Connection.Capabilities capabilities_;
    /// <summary>
    /// required
    /// </summary>
    public global::Mysqlx.Connection.Capabilities Capabilities {
      get { return capabilities_; }
      set {
        capabilities_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CapabilitiesSet);
    }

    public bool Equals(CapabilitiesSet other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Capabilities, other.Capabilities)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (capabilities_ != null) hash ^= Capabilities.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (capabilities_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Capabilities);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (capabilities_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Capabilities);
      }
      return size;
    }

    public void MergeFrom(CapabilitiesSet other) {
      if (other == null) {
        return;
      }
      if (other.capabilities_ != null) {
        if (capabilities_ == null) {
          capabilities_ = new global::Mysqlx.Connection.Capabilities();
        }
        Capabilities.MergeFrom(other.Capabilities);
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
            if (capabilities_ == null) {
              capabilities_ = new global::Mysqlx.Connection.Capabilities();
            }
            input.ReadMessage(capabilities_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  announce to the server that the client wants to close the connection
  ///
  ///  it discards any session state of the server
  ///
  ///  :Returns: :protobuf:msg:`Mysqlx::Ok`
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class Close : pb::IMessage<Close> {
    private static readonly pb::MessageParser<Close> _parser = new pb::MessageParser<Close>(() => new Close());
    public static pb::MessageParser<Close> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Mysqlx.Connection.MysqlxConnectionReflection.Descriptor.MessageTypes[4]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public Close() {
      OnConstruction();
    }

    partial void OnConstruction();

    public Close(Close other) : this() {
    }

    public Close Clone() {
      return new Close(this);
    }

    public override bool Equals(object other) {
      return Equals(other as Close);
    }

    public bool Equals(Close other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
    }

    public int CalculateSize() {
      int size = 0;
      return size;
    }

    public void MergeFrom(Close other) {
      if (other == null) {
        return;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
