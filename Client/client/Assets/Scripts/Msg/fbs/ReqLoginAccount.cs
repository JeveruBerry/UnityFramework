// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace fbs
{

using global::System;
using global::FlatBuffers;

public struct ReqLoginAccount : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public const ulong HashID = 0x30526426CFB42CCF;
  public static ReqLoginAccount GetRootAsReqLoginAccount(ByteBuffer _bb) { return GetRootAsReqLoginAccount(_bb, new ReqLoginAccount()); }
  public static ReqLoginAccount GetRootAsReqLoginAccount(ByteBuffer _bb, ReqLoginAccount obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public ReqLoginAccount __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public string Account { get { int o = __p.__offset(4); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetAccountBytes() { return __p.__vector_as_span(4); }
#else
  public ArraySegment<byte>? GetAccountBytes() { return __p.__vector_as_arraysegment(4); }
#endif
  public byte[] GetAccountArray() { return __p.__vector_as_array<byte>(4); }
  public string Password { get { int o = __p.__offset(6); return o != 0 ? __p.__string(o + __p.bb_pos) : null; } }
#if ENABLE_SPAN_T
  public Span<byte> GetPasswordBytes() { return __p.__vector_as_span(6); }
#else
  public ArraySegment<byte>? GetPasswordBytes() { return __p.__vector_as_arraysegment(6); }
#endif
  public byte[] GetPasswordArray() { return __p.__vector_as_array<byte>(6); }

  public static Offset<ReqLoginAccount> CreateReqLoginAccount(FlatBufferBuilder builder,
      StringOffset accountOffset = default(StringOffset),
      StringOffset passwordOffset = default(StringOffset)) {
    builder.StartObject(2);
    ReqLoginAccount.AddPassword(builder, passwordOffset);
    ReqLoginAccount.AddAccount(builder, accountOffset);
    return ReqLoginAccount.EndReqLoginAccount(builder);
  }

  public static void StartReqLoginAccount(FlatBufferBuilder builder) { builder.StartObject(2); }
  public static void AddAccount(FlatBufferBuilder builder, StringOffset accountOffset) { builder.AddOffset(0, accountOffset.Value, 0); }
  public static void AddPassword(FlatBufferBuilder builder, StringOffset passwordOffset) { builder.AddOffset(1, passwordOffset.Value, 0); }
  public static Offset<ReqLoginAccount> EndReqLoginAccount(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<ReqLoginAccount>(o);
  }
};


}