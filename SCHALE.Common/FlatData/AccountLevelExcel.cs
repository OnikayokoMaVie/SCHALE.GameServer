// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct AccountLevelExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static AccountLevelExcel GetRootAsAccountLevelExcel(ByteBuffer _bb) { return GetRootAsAccountLevelExcel(_bb, new AccountLevelExcel()); }
  public static AccountLevelExcel GetRootAsAccountLevelExcel(ByteBuffer _bb, AccountLevelExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public AccountLevelExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Level { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long Exp { get { int o = __p.__offset(8); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long APAutoChargeMax { get { int o = __p.__offset(10); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public bool NeedReportEvent { get { int o = __p.__offset(12); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<SCHALE.Common.FlatData.AccountLevelExcel> CreateAccountLevelExcel(FlatBufferBuilder builder,
      long Id = 0,
      long Level = 0,
      long Exp = 0,
      long APAutoChargeMax = 0,
      bool NeedReportEvent = false) {
    builder.StartTable(5);
    AccountLevelExcel.AddAPAutoChargeMax(builder, APAutoChargeMax);
    AccountLevelExcel.AddExp(builder, Exp);
    AccountLevelExcel.AddLevel(builder, Level);
    AccountLevelExcel.AddId(builder, Id);
    AccountLevelExcel.AddNeedReportEvent(builder, NeedReportEvent);
    return AccountLevelExcel.EndAccountLevelExcel(builder);
  }

  public static void StartAccountLevelExcel(FlatBufferBuilder builder) { builder.StartTable(5); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddLevel(FlatBufferBuilder builder, long level) { builder.AddLong(1, level, 0); }
  public static void AddExp(FlatBufferBuilder builder, long exp) { builder.AddLong(2, exp, 0); }
  public static void AddAPAutoChargeMax(FlatBufferBuilder builder, long aPAutoChargeMax) { builder.AddLong(3, aPAutoChargeMax, 0); }
  public static void AddNeedReportEvent(FlatBufferBuilder builder, bool needReportEvent) { builder.AddBool(4, needReportEvent, false); }
  public static Offset<SCHALE.Common.FlatData.AccountLevelExcel> EndAccountLevelExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.AccountLevelExcel>(o);
  }
}


static public class AccountLevelExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*Level*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*Exp*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 10 /*APAutoChargeMax*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 12 /*NeedReportEvent*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}