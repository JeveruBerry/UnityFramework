// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace fbs
{

using global::System;
using global::FlatBuffers;

public struct RspLogin : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static RspLogin GetRootAsRspLogin(ByteBuffer _bb) { return GetRootAsRspLogin(_bb, new RspLogin()); }
  public static RspLogin GetRootAsRspLogin(ByteBuffer _bb, RspLogin obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p.bb_pos = _i; __p.bb = _bb; }
  public RspLogin __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public bool Isok { get { int o = __p.__offset(4); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<RspLogin> CreateRspLogin(FlatBufferBuilder builder,
      bool isok = false) {
    builder.StartObject(1);
    RspLogin.AddIsok(builder, isok);
    return RspLogin.EndRspLogin(builder);
  }

  public static void StartRspLogin(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddIsok(FlatBufferBuilder builder, bool isok) { builder.AddBool(0, isok, false); }
  public static Offset<RspLogin> EndRspLogin(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<RspLogin>(o);
  }
};


}
