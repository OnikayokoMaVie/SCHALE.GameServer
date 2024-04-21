// <auto-generated>
//  automatically generated by the FlatBuffers compiler, do not modify
// </auto-generated>

namespace SCHALE.Common.FlatData
{

using global::System;
using global::System.Collections.Generic;
using global::Google.FlatBuffers;

public struct CharacterPotentialExcel : IFlatbufferObject
{
  private Table __p;
  public ByteBuffer ByteBuffer { get { return __p.bb; } }
  public static void ValidateVersion() { FlatBufferConstants.FLATBUFFERS_24_3_25(); }
  public static CharacterPotentialExcel GetRootAsCharacterPotentialExcel(ByteBuffer _bb) { return GetRootAsCharacterPotentialExcel(_bb, new CharacterPotentialExcel()); }
  public static CharacterPotentialExcel GetRootAsCharacterPotentialExcel(ByteBuffer _bb, CharacterPotentialExcel obj) { return (obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public void __init(int _i, ByteBuffer _bb) { __p = new Table(_i, _bb); }
  public CharacterPotentialExcel __assign(int _i, ByteBuffer _bb) { __init(_i, _bb); return this; }

  public long Id { get { int o = __p.__offset(4); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public long PotentialStatGroupId { get { int o = __p.__offset(6); return o != 0 ? __p.bb.GetLong(o + __p.bb_pos) : (long)0; } }
  public SCHALE.Common.FlatData.PotentialStatBonusRateType PotentialStatBonusRateType { get { int o = __p.__offset(8); return o != 0 ? (SCHALE.Common.FlatData.PotentialStatBonusRateType)__p.bb.GetInt(o + __p.bb_pos) : SCHALE.Common.FlatData.PotentialStatBonusRateType.None; } }
  public bool IsUnnecessaryStat { get { int o = __p.__offset(10); return o != 0 ? 0!=__p.bb.Get(o + __p.bb_pos) : (bool)false; } }

  public static Offset<SCHALE.Common.FlatData.CharacterPotentialExcel> CreateCharacterPotentialExcel(FlatBufferBuilder builder,
      long Id = 0,
      long PotentialStatGroupId = 0,
      SCHALE.Common.FlatData.PotentialStatBonusRateType PotentialStatBonusRateType = SCHALE.Common.FlatData.PotentialStatBonusRateType.None,
      bool IsUnnecessaryStat = false) {
    builder.StartTable(4);
    CharacterPotentialExcel.AddPotentialStatGroupId(builder, PotentialStatGroupId);
    CharacterPotentialExcel.AddId(builder, Id);
    CharacterPotentialExcel.AddPotentialStatBonusRateType(builder, PotentialStatBonusRateType);
    CharacterPotentialExcel.AddIsUnnecessaryStat(builder, IsUnnecessaryStat);
    return CharacterPotentialExcel.EndCharacterPotentialExcel(builder);
  }

  public static void StartCharacterPotentialExcel(FlatBufferBuilder builder) { builder.StartTable(4); }
  public static void AddId(FlatBufferBuilder builder, long id) { builder.AddLong(0, id, 0); }
  public static void AddPotentialStatGroupId(FlatBufferBuilder builder, long potentialStatGroupId) { builder.AddLong(1, potentialStatGroupId, 0); }
  public static void AddPotentialStatBonusRateType(FlatBufferBuilder builder, SCHALE.Common.FlatData.PotentialStatBonusRateType potentialStatBonusRateType) { builder.AddInt(2, (int)potentialStatBonusRateType, 0); }
  public static void AddIsUnnecessaryStat(FlatBufferBuilder builder, bool isUnnecessaryStat) { builder.AddBool(3, isUnnecessaryStat, false); }
  public static Offset<SCHALE.Common.FlatData.CharacterPotentialExcel> EndCharacterPotentialExcel(FlatBufferBuilder builder) {
    int o = builder.EndTable();
    return new Offset<SCHALE.Common.FlatData.CharacterPotentialExcel>(o);
  }
}


static public class CharacterPotentialExcelVerify
{
  static public bool Verify(Google.FlatBuffers.Verifier verifier, uint tablePos)
  {
    return verifier.VerifyTableStart(tablePos)
      && verifier.VerifyField(tablePos, 4 /*Id*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 6 /*PotentialStatGroupId*/, 8 /*long*/, 8, false)
      && verifier.VerifyField(tablePos, 8 /*PotentialStatBonusRateType*/, 4 /*SCHALE.Common.FlatData.PotentialStatBonusRateType*/, 4, false)
      && verifier.VerifyField(tablePos, 10 /*IsUnnecessaryStat*/, 1 /*bool*/, 1, false)
      && verifier.VerifyTableEnd(tablePos);
  }
}

}