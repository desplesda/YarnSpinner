// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: yarn_spinner.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Yarn {

  /// <summary>Holder for reflection information generated from yarn_spinner.proto</summary>
  public static partial class YarnSpinnerReflection {

    #region Descriptor
    /// <summary>File descriptor for yarn_spinner.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static YarnSpinnerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJ5YXJuX3NwaW5uZXIucHJvdG8SBFlhcm4iegoHUHJvZ3JhbRIMCgRuYW1l",
            "GAEgASgJEicKBW5vZGVzGAIgAygLMhguWWFybi5Qcm9ncmFtLk5vZGVzRW50",
            "cnkaOAoKTm9kZXNFbnRyeRILCgNrZXkYASABKAkSGQoFdmFsdWUYAiABKAsy",
            "Ci5ZYXJuLk5vZGU6AjgBIr4BCgROb2RlEgwKBG5hbWUYASABKAkSJwoMaW5z",
            "dHJ1Y3Rpb25zGAIgAygLMhEuWWFybi5JbnN0cnVjdGlvbhImCgZsYWJlbHMY",
            "AyADKAsyFi5ZYXJuLk5vZGUuTGFiZWxzRW50cnkSDAoEdGFncxgEIAMoCRIa",
            "ChJzb3VyY2VUZXh0U3RyaW5nSUQYBSABKAkaLQoLTGFiZWxzRW50cnkSCwoD",
            "a2V5GAEgASgJEg0KBXZhbHVlGAIgASgFOgI4ASLkAgoLSW5zdHJ1Y3Rpb24S",
            "KAoGb3Bjb2RlGAEgASgOMhguWWFybi5JbnN0cnVjdGlvbi5PcENvZGUSHwoI",
            "b3BlcmFuZHMYAiADKAsyDS5ZYXJuLk9wZXJhbmQiiQIKBk9wQ29kZRILCgdK",
            "VU1QX1RPEAASCAoESlVNUBABEgwKCFJVTl9MSU5FEAISDwoLUlVOX0NPTU1B",
            "TkQQAxIOCgpBRERfT1BUSU9OEAQSEAoMU0hPV19PUFRJT05TEAUSDwoLUFVT",
            "SF9TVFJJTkcQBhIOCgpQVVNIX0ZMT0FUEAcSDQoJUFVTSF9CT09MEAgSDQoJ",
            "UFVTSF9OVUxMEAkSEQoNSlVNUF9JRl9GQUxTRRAKEgcKA1BPUBALEg0KCUNB",
            "TExfRlVOQxAMEhEKDVBVU0hfVkFSSUFCTEUQDRISCg5TVE9SRV9WQVJJQUJM",
            "RRAOEggKBFNUT1AQDxIMCghSVU5fTk9ERRAQIlcKB09wZXJhbmQSFgoMc3Ry",
            "aW5nX3ZhbHVlGAEgASgJSAASFAoKYm9vbF92YWx1ZRgCIAEoCEgAEhUKC2Zs",
            "b2F0X3ZhbHVlGAMgASgCSABCBwoFdmFsdWViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Yarn.Program), global::Yarn.Program.Parser, new[]{ "Name", "Nodes" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yarn.Node), global::Yarn.Node.Parser, new[]{ "Name", "Instructions", "Labels", "Tags", "SourceTextStringID" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yarn.Instruction), global::Yarn.Instruction.Parser, new[]{ "Opcode", "Operands" }, null, new[]{ typeof(global::Yarn.Instruction.Types.OpCode) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Yarn.Operand), global::Yarn.Operand.Parser, new[]{ "StringValue", "BoolValue", "FloatValue" }, new[]{ "Value" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Program : pb::IMessage<Program> {
    private static readonly pb::MessageParser<Program> _parser = new pb::MessageParser<Program>(() => new Program());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Program> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yarn.YarnSpinnerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Program() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Program(Program other) : this() {
      name_ = other.name_;
      nodes_ = other.nodes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Program Clone() {
      return new Program(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "nodes" field.</summary>
    public const int NodesFieldNumber = 2;
    private static readonly pbc::MapField<string, global::Yarn.Node>.Codec _map_nodes_codec
        = new pbc::MapField<string, global::Yarn.Node>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Yarn.Node.Parser), 18);
    private readonly pbc::MapField<string, global::Yarn.Node> nodes_ = new pbc::MapField<string, global::Yarn.Node>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, global::Yarn.Node> Nodes {
      get { return nodes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Program);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Program other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!Nodes.Equals(other.Nodes)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= Nodes.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      nodes_.WriteTo(output, _map_nodes_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += nodes_.CalculateSize(_map_nodes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Program other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      nodes_.Add(other.nodes_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            nodes_.AddEntriesFrom(input, _map_nodes_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Node : pb::IMessage<Node> {
    private static readonly pb::MessageParser<Node> _parser = new pb::MessageParser<Node>(() => new Node());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Node> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yarn.YarnSpinnerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Node() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Node(Node other) : this() {
      name_ = other.name_;
      instructions_ = other.instructions_.Clone();
      labels_ = other.labels_.Clone();
      tags_ = other.tags_.Clone();
      sourceTextStringID_ = other.sourceTextStringID_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Node Clone() {
      return new Node(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The name of this node.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "instructions" field.</summary>
    public const int InstructionsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Yarn.Instruction> _repeated_instructions_codec
        = pb::FieldCodec.ForMessage(18, global::Yarn.Instruction.Parser);
    private readonly pbc::RepeatedField<global::Yarn.Instruction> instructions_ = new pbc::RepeatedField<global::Yarn.Instruction>();
    /// <summary>
    /// The list of instructions in this node.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yarn.Instruction> Instructions {
      get { return instructions_; }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 3;
    private static readonly pbc::MapField<string, int>.Codec _map_labels_codec
        = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt32(16, 0), 26);
    private readonly pbc::MapField<string, int> labels_ = new pbc::MapField<string, int>();
    /// <summary>
    /// A jump table, mapping the names of labels to positions in the
    /// instructions list.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, int> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "tags" field.</summary>
    public const int TagsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_tags_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> tags_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Tags {
      get { return tags_; }
    }

    /// <summary>Field number for the "sourceTextStringID" field.</summary>
    public const int SourceTextStringIDFieldNumber = 5;
    private string sourceTextStringID_ = "";
    /// <summary>
    /// the entry in the program's string table that contains the original
    /// text of this node; null if this is not available    
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SourceTextStringID {
      get { return sourceTextStringID_; }
      set {
        sourceTextStringID_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Node);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Node other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if(!instructions_.Equals(other.instructions_)) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if(!tags_.Equals(other.tags_)) return false;
      if (SourceTextStringID != other.SourceTextStringID) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      hash ^= instructions_.GetHashCode();
      hash ^= Labels.GetHashCode();
      hash ^= tags_.GetHashCode();
      if (SourceTextStringID.Length != 0) hash ^= SourceTextStringID.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      instructions_.WriteTo(output, _repeated_instructions_codec);
      labels_.WriteTo(output, _map_labels_codec);
      tags_.WriteTo(output, _repeated_tags_codec);
      if (SourceTextStringID.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SourceTextStringID);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      size += instructions_.CalculateSize(_repeated_instructions_codec);
      size += labels_.CalculateSize(_map_labels_codec);
      size += tags_.CalculateSize(_repeated_tags_codec);
      if (SourceTextStringID.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SourceTextStringID);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Node other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      instructions_.Add(other.instructions_);
      labels_.Add(other.labels_);
      tags_.Add(other.tags_);
      if (other.SourceTextStringID.Length != 0) {
        SourceTextStringID = other.SourceTextStringID;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            instructions_.AddEntriesFrom(input, _repeated_instructions_codec);
            break;
          }
          case 26: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 34: {
            tags_.AddEntriesFrom(input, _repeated_tags_codec);
            break;
          }
          case 42: {
            SourceTextStringID = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Instruction : pb::IMessage<Instruction> {
    private static readonly pb::MessageParser<Instruction> _parser = new pb::MessageParser<Instruction>(() => new Instruction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Instruction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yarn.YarnSpinnerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Instruction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Instruction(Instruction other) : this() {
      opcode_ = other.opcode_;
      operands_ = other.operands_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Instruction Clone() {
      return new Instruction(this);
    }

    /// <summary>Field number for the "opcode" field.</summary>
    public const int OpcodeFieldNumber = 1;
    private global::Yarn.Instruction.Types.OpCode opcode_ = global::Yarn.Instruction.Types.OpCode.JumpTo;
    /// <summary>
    /// The operation that this instruction will perform.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Yarn.Instruction.Types.OpCode Opcode {
      get { return opcode_; }
      set {
        opcode_ = value;
      }
    }

    /// <summary>Field number for the "operands" field.</summary>
    public const int OperandsFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Yarn.Operand> _repeated_operands_codec
        = pb::FieldCodec.ForMessage(18, global::Yarn.Operand.Parser);
    private readonly pbc::RepeatedField<global::Yarn.Operand> operands_ = new pbc::RepeatedField<global::Yarn.Operand>();
    /// <summary>
    /// The list of operands, if any, that this instruction uses.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Yarn.Operand> Operands {
      get { return operands_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Instruction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Instruction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Opcode != other.Opcode) return false;
      if(!operands_.Equals(other.operands_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Opcode != global::Yarn.Instruction.Types.OpCode.JumpTo) hash ^= Opcode.GetHashCode();
      hash ^= operands_.GetHashCode();
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
      if (Opcode != global::Yarn.Instruction.Types.OpCode.JumpTo) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Opcode);
      }
      operands_.WriteTo(output, _repeated_operands_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Opcode != global::Yarn.Instruction.Types.OpCode.JumpTo) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Opcode);
      }
      size += operands_.CalculateSize(_repeated_operands_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Instruction other) {
      if (other == null) {
        return;
      }
      if (other.Opcode != global::Yarn.Instruction.Types.OpCode.JumpTo) {
        Opcode = other.Opcode;
      }
      operands_.Add(other.operands_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Opcode = (global::Yarn.Instruction.Types.OpCode) input.ReadEnum();
            break;
          }
          case 18: {
            operands_.AddEntriesFrom(input, _repeated_operands_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the Instruction message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum OpCode {
        /// <summary>
        /// Jumps to a named position in the node.
        /// opA = string: label name
        /// </summary>
        [pbr::OriginalName("JUMP_TO")] JumpTo = 0,
        /// <summary>
        /// Peeks a string from stack, and jumps to that named position in
        /// the node. 
        /// No operands.
        /// </summary>
        [pbr::OriginalName("JUMP")] Jump = 1,
        /// <summary>
        /// Delivers a string ID to the client.
        /// opA = string: string ID
        /// </summary>
        [pbr::OriginalName("RUN_LINE")] RunLine = 2,
        /// <summary>
        /// Delivers a command to the client.
        /// opA = string: command text
        /// </summary>
        [pbr::OriginalName("RUN_COMMAND")] RunCommand = 3,
        /// <summary>
        /// Adds an entry to the option list (see ShowOptions).
        /// opA = string: string ID for option to add
        /// </summary>
        [pbr::OriginalName("ADD_OPTION")] AddOption = 4,
        /// <summary>
        /// Presents the current list of options to the client, then clears
        /// the list. The most recently selected option will be on the top
        /// of the stack when execution resumes.
        /// No operands.
        /// </summary>
        [pbr::OriginalName("SHOW_OPTIONS")] ShowOptions = 5,
        /// <summary>
        /// Pushes a string onto the stack.
        /// opA = string: the string to push to the stack.
        /// </summary>
        [pbr::OriginalName("PUSH_STRING")] PushString = 6,
        /// <summary>
        /// Pushes a floating point number onto the stack.
        /// opA = float: number to push to stack
        /// </summary>
        [pbr::OriginalName("PUSH_FLOAT")] PushFloat = 7,
        /// <summary>
        /// Pushes a boolean onto the stack.
        /// opA = bool: the bool to push to stack
        /// </summary>
        [pbr::OriginalName("PUSH_BOOL")] PushBool = 8,
        /// <summary>
        /// Pushes a null value onto the stack.
        /// No operands.
        /// </summary>
        [pbr::OriginalName("PUSH_NULL")] PushNull = 9,
        /// <summary>
        /// Jumps to the named position in the the node, if the top of the
        /// stack is not null, zero or false.
        /// opA = string: label name 
        /// </summary>
        [pbr::OriginalName("JUMP_IF_FALSE")] JumpIfFalse = 10,
        /// <summary>
        /// Discards top of stack.
        /// No operands.
        /// </summary>
        [pbr::OriginalName("POP")] Pop = 11,
        /// <summary>
        /// opA = string: name of the function
        /// </summary>
        [pbr::OriginalName("CALL_FUNC")] CallFunc = 12,
        /// <summary>
        /// Pushes the contents of a variable onto the stack.
        /// opA = name of variable 
        /// </summary>
        [pbr::OriginalName("PUSH_VARIABLE")] PushVariable = 13,
        /// <summary>
        /// Stores the contents of the top of the stack in the named
        /// variable. 
        /// opA = name of variable
        /// </summary>
        [pbr::OriginalName("STORE_VARIABLE")] StoreVariable = 14,
        /// <summary>
        /// Stops execution of the program.
        /// No operands.
        /// </summary>
        [pbr::OriginalName("STOP")] Stop = 15,
        /// <summary>
        /// Run the node whose name is at the top of the stack.
        /// No operands.
        /// </summary>
        [pbr::OriginalName("RUN_NODE")] RunNode = 16,
      }

    }
    #endregion

  }

  /// <summary>
  /// A value used by an Instruction.
  /// </summary>
  public sealed partial class Operand : pb::IMessage<Operand> {
    private static readonly pb::MessageParser<Operand> _parser = new pb::MessageParser<Operand>(() => new Operand());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Operand> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Yarn.YarnSpinnerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Operand() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Operand(Operand other) : this() {
      switch (other.ValueCase) {
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
        case ValueOneofCase.BoolValue:
          BoolValue = other.BoolValue;
          break;
        case ValueOneofCase.FloatValue:
          FloatValue = other.FloatValue;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Operand Clone() {
      return new Operand(this);
    }

    /// <summary>Field number for the "string_value" field.</summary>
    public const int StringValueFieldNumber = 1;
    /// <summary>
    /// A string.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string StringValue {
      get { return valueCase_ == ValueOneofCase.StringValue ? (string) value_ : ""; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
        valueCase_ = ValueOneofCase.StringValue;
      }
    }

    /// <summary>Field number for the "bool_value" field.</summary>
    public const int BoolValueFieldNumber = 2;
    /// <summary>
    /// A boolean (true or false).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool BoolValue {
      get { return valueCase_ == ValueOneofCase.BoolValue ? (bool) value_ : false; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.BoolValue;
      }
    }

    /// <summary>Field number for the "float_value" field.</summary>
    public const int FloatValueFieldNumber = 3;
    /// <summary>
    /// A floating point number.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float FloatValue {
      get { return valueCase_ == ValueOneofCase.FloatValue ? (float) value_ : 0F; }
      set {
        value_ = value;
        valueCase_ = ValueOneofCase.FloatValue;
      }
    }

    private object value_;
    /// <summary>Enum of possible cases for the "value" oneof.</summary>
    public enum ValueOneofCase {
      None = 0,
      StringValue = 1,
      BoolValue = 2,
      FloatValue = 3,
    }
    private ValueOneofCase valueCase_ = ValueOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ValueOneofCase ValueCase {
      get { return valueCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearValue() {
      valueCase_ = ValueOneofCase.None;
      value_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Operand);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Operand other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StringValue != other.StringValue) return false;
      if (BoolValue != other.BoolValue) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(FloatValue, other.FloatValue)) return false;
      if (ValueCase != other.ValueCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (valueCase_ == ValueOneofCase.StringValue) hash ^= StringValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.BoolValue) hash ^= BoolValue.GetHashCode();
      if (valueCase_ == ValueOneofCase.FloatValue) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(FloatValue);
      hash ^= (int) valueCase_;
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
      if (valueCase_ == ValueOneofCase.StringValue) {
        output.WriteRawTag(10);
        output.WriteString(StringValue);
      }
      if (valueCase_ == ValueOneofCase.BoolValue) {
        output.WriteRawTag(16);
        output.WriteBool(BoolValue);
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        output.WriteRawTag(29);
        output.WriteFloat(FloatValue);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (valueCase_ == ValueOneofCase.StringValue) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
      }
      if (valueCase_ == ValueOneofCase.BoolValue) {
        size += 1 + 1;
      }
      if (valueCase_ == ValueOneofCase.FloatValue) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Operand other) {
      if (other == null) {
        return;
      }
      switch (other.ValueCase) {
        case ValueOneofCase.StringValue:
          StringValue = other.StringValue;
          break;
        case ValueOneofCase.BoolValue:
          BoolValue = other.BoolValue;
          break;
        case ValueOneofCase.FloatValue:
          FloatValue = other.FloatValue;
          break;
      }

      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            StringValue = input.ReadString();
            break;
          }
          case 16: {
            BoolValue = input.ReadBool();
            break;
          }
          case 29: {
            FloatValue = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
