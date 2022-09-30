// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/datastore/v1/aggregation_result.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Datastore.V1 {

  /// <summary>Holder for reflection information generated from google/datastore/v1/aggregation_result.proto</summary>
  public static partial class AggregationResultReflection {

    #region Descriptor
    /// <summary>File descriptor for google/datastore/v1/aggregation_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AggregationResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cixnb29nbGUvZGF0YXN0b3JlL3YxL2FnZ3JlZ2F0aW9uX3Jlc3VsdC5wcm90",
            "bxITZ29vZ2xlLmRhdGFzdG9yZS52MRogZ29vZ2xlL2RhdGFzdG9yZS92MS9l",
            "bnRpdHkucHJvdG8aH2dvb2dsZS9kYXRhc3RvcmUvdjEvcXVlcnkucHJvdG8a",
            "H2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8iygEKEUFnZ3JlZ2F0",
            "aW9uUmVzdWx0El0KFGFnZ3JlZ2F0ZV9wcm9wZXJ0aWVzGAIgAygLMj8uZ29v",
            "Z2xlLmRhdGFzdG9yZS52MS5BZ2dyZWdhdGlvblJlc3VsdC5BZ2dyZWdhdGVQ",
            "cm9wZXJ0aWVzRW50cnkaVgoYQWdncmVnYXRlUHJvcGVydGllc0VudHJ5EgsK",
            "A2tleRgBIAEoCRIpCgV2YWx1ZRgCIAEoCzIaLmdvb2dsZS5kYXRhc3RvcmUu",
            "djEuVmFsdWU6AjgBItkBChZBZ2dyZWdhdGlvblJlc3VsdEJhdGNoEkMKE2Fn",
            "Z3JlZ2F0aW9uX3Jlc3VsdHMYASADKAsyJi5nb29nbGUuZGF0YXN0b3JlLnYx",
            "LkFnZ3JlZ2F0aW9uUmVzdWx0EksKDG1vcmVfcmVzdWx0cxgCIAEoDjI1Lmdv",
            "b2dsZS5kYXRhc3RvcmUudjEuUXVlcnlSZXN1bHRCYXRjaC5Nb3JlUmVzdWx0",
            "c1R5cGUSLQoJcmVhZF90aW1lGAMgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRp",
            "bWVzdGFtcELIAQoXY29tLmdvb2dsZS5kYXRhc3RvcmUudjFCFkFnZ3JlZ2F0",
            "aW9uUmVzdWx0UHJvdG9QAVo8Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9kYXRhc3RvcmUvdjE7ZGF0YXN0b3JlqgIZR29vZ2xlLkNs",
            "b3VkLkRhdGFzdG9yZS5WMcoCGUdvb2dsZVxDbG91ZFxEYXRhc3RvcmVcVjHq",
            "AhxHb29nbGU6OkNsb3VkOjpEYXRhc3RvcmU6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Cloud.Datastore.V1.EntityReflection.Descriptor, global::Google.Cloud.Datastore.V1.QueryReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Datastore.V1.AggregationResult), global::Google.Cloud.Datastore.V1.AggregationResult.Parser, new[]{ "AggregateProperties" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Datastore.V1.AggregationResultBatch), global::Google.Cloud.Datastore.V1.AggregationResultBatch.Parser, new[]{ "AggregationResults", "MoreResults", "ReadTime" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The result of a single bucket from a Datastore aggregation query.
  ///
  /// The keys of `aggregate_properties` are the same for all results in an
  /// aggregation query, unlike entity queries which can have different fields
  /// present for each result.
  /// </summary>
  public sealed partial class AggregationResult : pb::IMessage<AggregationResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AggregationResult> _parser = new pb::MessageParser<AggregationResult>(() => new AggregationResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AggregationResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Datastore.V1.AggregationResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AggregationResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AggregationResult(AggregationResult other) : this() {
      aggregateProperties_ = other.aggregateProperties_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AggregationResult Clone() {
      return new AggregationResult(this);
    }

    /// <summary>Field number for the "aggregate_properties" field.</summary>
    public const int AggregatePropertiesFieldNumber = 2;
    private static readonly pbc::MapField<string, global::Google.Cloud.Datastore.V1.Value>.Codec _map_aggregateProperties_codec
        = new pbc::MapField<string, global::Google.Cloud.Datastore.V1.Value>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::Google.Cloud.Datastore.V1.Value.Parser), 18);
    private readonly pbc::MapField<string, global::Google.Cloud.Datastore.V1.Value> aggregateProperties_ = new pbc::MapField<string, global::Google.Cloud.Datastore.V1.Value>();
    /// <summary>
    /// The result of the aggregation functions, ex: `COUNT(*) AS total_entities`.
    ///
    /// The key is the [alias][google.datastore.v1.AggregationQuery.Aggregation.alias]
    /// assigned to the aggregation function on input and the size of this map
    /// equals the number of aggregation functions in the query.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::MapField<string, global::Google.Cloud.Datastore.V1.Value> AggregateProperties {
      get { return aggregateProperties_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AggregationResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AggregationResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!AggregateProperties.Equals(other.AggregateProperties)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= AggregateProperties.GetHashCode();
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
      aggregateProperties_.WriteTo(output, _map_aggregateProperties_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      aggregateProperties_.WriteTo(ref output, _map_aggregateProperties_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      size += aggregateProperties_.CalculateSize(_map_aggregateProperties_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AggregationResult other) {
      if (other == null) {
        return;
      }
      aggregateProperties_.Add(other.aggregateProperties_);
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
          case 18: {
            aggregateProperties_.AddEntriesFrom(input, _map_aggregateProperties_codec);
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
          case 18: {
            aggregateProperties_.AddEntriesFrom(ref input, _map_aggregateProperties_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// A batch of aggregation results produced by an aggregation query.
  /// </summary>
  public sealed partial class AggregationResultBatch : pb::IMessage<AggregationResultBatch>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AggregationResultBatch> _parser = new pb::MessageParser<AggregationResultBatch>(() => new AggregationResultBatch());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AggregationResultBatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Datastore.V1.AggregationResultReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AggregationResultBatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AggregationResultBatch(AggregationResultBatch other) : this() {
      aggregationResults_ = other.aggregationResults_.Clone();
      moreResults_ = other.moreResults_;
      readTime_ = other.readTime_ != null ? other.readTime_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AggregationResultBatch Clone() {
      return new AggregationResultBatch(this);
    }

    /// <summary>Field number for the "aggregation_results" field.</summary>
    public const int AggregationResultsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.Datastore.V1.AggregationResult> _repeated_aggregationResults_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.Datastore.V1.AggregationResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Datastore.V1.AggregationResult> aggregationResults_ = new pbc::RepeatedField<global::Google.Cloud.Datastore.V1.AggregationResult>();
    /// <summary>
    /// The aggregation results for this batch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.Datastore.V1.AggregationResult> AggregationResults {
      get { return aggregationResults_; }
    }

    /// <summary>Field number for the "more_results" field.</summary>
    public const int MoreResultsFieldNumber = 2;
    private global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType moreResults_ = global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType.Unspecified;
    /// <summary>
    /// The state of the query after the current batch.
    /// Only COUNT(*) aggregations are supported in the initial launch. Therefore,
    /// expected result type is limited to `NO_MORE_RESULTS`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType MoreResults {
      get { return moreResults_; }
      set {
        moreResults_ = value;
      }
    }

    /// <summary>Field number for the "read_time" field.</summary>
    public const int ReadTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp readTime_;
    /// <summary>
    /// Read timestamp this batch was returned from.
    ///
    /// In a single transaction, subsequent query result batches for the same query
    /// can have a greater timestamp. Each batch's read timestamp
    /// is valid for all preceding batches.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ReadTime {
      get { return readTime_; }
      set {
        readTime_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AggregationResultBatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AggregationResultBatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!aggregationResults_.Equals(other.aggregationResults_)) return false;
      if (MoreResults != other.MoreResults) return false;
      if (!object.Equals(ReadTime, other.ReadTime)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= aggregationResults_.GetHashCode();
      if (MoreResults != global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType.Unspecified) hash ^= MoreResults.GetHashCode();
      if (readTime_ != null) hash ^= ReadTime.GetHashCode();
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
      aggregationResults_.WriteTo(output, _repeated_aggregationResults_codec);
      if (MoreResults != global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) MoreResults);
      }
      if (readTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ReadTime);
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
      aggregationResults_.WriteTo(ref output, _repeated_aggregationResults_codec);
      if (MoreResults != global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType.Unspecified) {
        output.WriteRawTag(16);
        output.WriteEnum((int) MoreResults);
      }
      if (readTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ReadTime);
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
      size += aggregationResults_.CalculateSize(_repeated_aggregationResults_codec);
      if (MoreResults != global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MoreResults);
      }
      if (readTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ReadTime);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AggregationResultBatch other) {
      if (other == null) {
        return;
      }
      aggregationResults_.Add(other.aggregationResults_);
      if (other.MoreResults != global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType.Unspecified) {
        MoreResults = other.MoreResults;
      }
      if (other.readTime_ != null) {
        if (readTime_ == null) {
          ReadTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ReadTime.MergeFrom(other.ReadTime);
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
            aggregationResults_.AddEntriesFrom(input, _repeated_aggregationResults_codec);
            break;
          }
          case 16: {
            MoreResults = (global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType) input.ReadEnum();
            break;
          }
          case 26: {
            if (readTime_ == null) {
              ReadTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ReadTime);
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
            aggregationResults_.AddEntriesFrom(ref input, _repeated_aggregationResults_codec);
            break;
          }
          case 16: {
            MoreResults = (global::Google.Cloud.Datastore.V1.QueryResultBatch.Types.MoreResultsType) input.ReadEnum();
            break;
          }
          case 26: {
            if (readTime_ == null) {
              ReadTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ReadTime);
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