// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: MsgID.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Protobuf {

  /// <summary>Holder for reflection information generated from MsgID.proto</summary>
  public static partial class MsgIDReflection {

    #region Descriptor
    /// <summary>File descriptor for MsgID.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MsgIDReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgtNc2dJRC5wcm90bxIPR29vZ2xlLlByb3RvYnVmIgkKB1BCX05vbmUq7gsK",
            "BU1zZ0lEEg4KCk1zZ0lEX05PTkUQABIPCgtIZWFydGJlYXRJRBABEg8KC1Rl",
            "c3RQcm90b0lEEAISDgoKSEVST19MT0dJThBlEhMKD1BMQVlFUl9MT0dJTk9V",
            "VBBmEhQKEEFMTF9IRVJPX0xJU1RfSUQQZxIMCghFUlJPUl9JRBBoEhgKFFMy",
            "Q19FTlRFUl9HQU1FX19GTEFHEGkSEQoNVEVBTV9DUkVBVF9JRBBqEhAKDEMy",
            "U19UZWFtSm9pbhBrEhEKDUMyU19UZWFtTGVhdmUQbBITCg9TMkNfQ2hhbm5l",
            "bENoYXQQbRIXChNDMlNfVGVhbUFwcGx5SGFuZGxlEG4SEgoOQzJTX0hlcm9D",
            "cmVhdGUQbxIYChRTMkNfSGVyb09mZmluZU5vdGljZRBwEhMKDkMyU19MT0dJ",
            "Tl9JTkZPEKcDEhMKDlMyQ19MT0dJTl9JTkZPEKgDEg4KCUMyU19NQVRDSBDI",
            "ARIOCglTMkNfTUFUQ0gQyQESFAoPQzJTX0xPR0lOX0hFTExPEJEDEhoKFUMy",
            "U19GSUdIVF9MT0FESU5HX0VORBCSAxIUCg9TMkNfRklHSFRfU1RBUlQQkwMS",
            "EwoOQzJTX0lOUFVUX0lORk8QlAMSEwoOUzJDX0ZSQU1FX0lORk8QlQMSEgoN",
            "QzJTX0ZJR0hUX09VVBCWAxISCg1DMlNfRklHSFRfRU5EEJcDEhIKDVMyQ19G",
            "SUdIVF9FTkQQmAMSGAoTRklHSFRfTE9BRElOR19BR0FJThCZAxIXChJTMkNf",
            "Tk9USUZZX01FU1NBR0UQ9AMSDgoJQzJTX1NDRU5FEOcEEg4KCVMyQ19TQ0VO",
            "RRDoBBIQCgtDMlNfQUNDT1VOVBDYBBIQCgtTMkNfQUNDT1VOVBDZBBIPCgpD",
            "MlNfQ0hBUkdFEPsEEg8KClMyQ19DSEFSR0UQ/AQSDAoHQzJTX0JBRxDaBBIM",
            "CgdTMkNfQkFHENsEEg8KCkMyU19DT01CQVQQ3AQSDwoKUzJDX0NPTUJBVBDd",
            "BBIOCglDMlNfUEFORUwQ3gQSDgoJUzJDX1BBTkVMEN8EEhMKDkMyU19HTV9D",
            "T01NQU5EEOAEEg8KCkMyU19DT01NT04Q4QQSDwoKUzJDX0NPTU1PThDiBBIX",
            "ChJHUzJDX0NPTlRJTlVPU19XQVIQ4wQSDQoIR1MyQ19XQVIQ5AQSDQoIQzJT",
            "X1RBU0sQ5QQSDQoIUzJDX1RBU0sQ5gQSDwoKQzJTX05PVElGWRDpBBIPCgpT",
            "MkNfTk9USUZZEOoEEgwKB0MyU19OUEMQ6wQSDAoHUzJDX05QQxDsBBIQCgtD",
            "MlNfSFVPRE9ORxDtBBIQCgtTMkNfSFVPRE9ORxDuBBIPCgpDMlNfU1VNTU9O",
            "EO8EEg8KClMyQ19TVU1NT04Q8AQSEAoLQzJTX0NIQU5ORUwQ8QQSEAoLUzJD",
            "X0NIQU5ORUwQ8gQSDwoKQzJTX0ZSSUVORBDzBBIPCgpTMkNfRlJJRU5EEPQE",
            "EhEKDEMyU19BTExJQU5DRRD1BBIRCgxTMkNfQUxMSUFOQ0UQ9gQSDQoIQzJT",
            "X01BSUwQ9wQSDQoIUzJDX01BSUwQ+AQSDgoJQzJHU19TSE9QEPkEEg4KCUdT",
            "MkNfU0hPUBD6BBIWChFDMlNfSFVPRE9OR19PVEhFUhD/BBIWChFTMkNfSFVP",
            "RE9OR19PVEhFUhCABRIOCglDMlNfU1RPUkUQ/QQSDgoJUzJDX1NUT1JFEP4E",
            "Eg0KCEMyU19SQU5LEIEFEg0KCFMyQ19SQU5LEIIFEhEKDEMyU19BQ1RJVklU",
            "WRCDBRIRCgxTMkNfQUNUSVZJVFkQhAUSDgoJQzJTX0VRVUlQEIUFEg4KCVMy",
            "Q19FUVVJUBCGBRISCg1DMlNfTFVDS1lTSE9QEIcFEhIKDVMyQ19MVUNLWVNI",
            "T1AQiAUSDwoKQzJTX1BST01QVBCJBRIPCgpTMkNfUFJPTVBUEIoFEhEKDEMy",
            "U19FWENIQU5HRRCLBRIRCgxTMkNfRVhDSEFOR0UQjAViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Protobuf.MsgID), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Protobuf.PB_None), global::Google.Protobuf.PB_None.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum MsgID {
    [pbr::OriginalName("MsgID_NONE")] None = 0,
    [pbr::OriginalName("HeartbeatID")] HeartbeatId = 1,
    [pbr::OriginalName("TestProtoID")] TestProtoId = 2,
    /// <summary>
    ///英雄登录
    /// </summary>
    [pbr::OriginalName("HERO_LOGIN")] HeroLogin = 101,
    /// <summary>
    ///英雄登出
    /// </summary>
    [pbr::OriginalName("PLAYER_LOGINOUT")] PlayerLoginout = 102,
    /// <summary>
    ///玩家角色信息
    /// </summary>
    [pbr::OriginalName("ALL_HERO_LIST_ID")] AllHeroListId = 103,
    /// <summary>
    ///错误信息
    /// </summary>
    [pbr::OriginalName("ERROR_ID")] ErrorId = 104,
    /// <summary>
    ///通知客户端登录可以显示主界面
    /// </summary>
    [pbr::OriginalName("S2C_ENTER_GAME__FLAG")] S2CEnterGameFlag = 105,
    /// <summary>
    ///创建队伍
    /// </summary>
    [pbr::OriginalName("TEAM_CREAT_ID")] TeamCreatId = 106,
    /// <summary>
    ///加入队伍
    /// </summary>
    [pbr::OriginalName("C2S_TeamJoin")] C2STeamJoin = 107,
    /// <summary>
    ///离开队伍
    /// </summary>
    [pbr::OriginalName("C2S_TeamLeave")] C2STeamLeave = 108,
    /// <summary>
    ///频道信息
    /// </summary>
    [pbr::OriginalName("S2C_ChannelChat")] S2CChannelChat = 109,
    /// <summary>
    ///处理入队申请
    /// </summary>
    [pbr::OriginalName("C2S_TeamApplyHandle")] C2STeamApplyHandle = 110,
    /// <summary>
    ///申请创建英雄
    /// </summary>
    [pbr::OriginalName("C2S_HeroCreate")] C2SHeroCreate = 111,
    /// <summary>
    ///英雄被其他玩家挤下线
    /// </summary>
    [pbr::OriginalName("S2C_HeroOffineNotice")] S2CHeroOffineNotice = 112,
    [pbr::OriginalName("C2S_LOGIN_INFO")] C2SLoginInfo = 423,
    [pbr::OriginalName("S2C_LOGIN_INFO")] S2CLoginInfo = 424,
    /// <summary>
    ///匹配系统MatchMsgID
    /// </summary>
    [pbr::OriginalName("C2S_MATCH")] C2SMatch = 200,
    [pbr::OriginalName("S2C_MATCH")] S2CMatch = 201,
    /// <summary>
    ///战斗系统消息协议	
    /// </summary>
    [pbr::OriginalName("C2S_LOGIN_HELLO")] C2SLoginHello = 401,
    /// <summary>
    ///客户端资源加载完成	//PB_C2SFightLoadingEnd
    /// </summary>
    [pbr::OriginalName("C2S_FIGHT_LOADING_END")] C2SFightLoadingEnd = 402,
    /// <summary>
    ///副本战斗开始		//PB_S2CFightStart
    /// </summary>
    [pbr::OriginalName("S2C_FIGHT_START")] S2CFightStart = 403,
    /// <summary>
    ///玩家输入信息		//PB_C2SClientInput
    /// </summary>
    [pbr::OriginalName("C2S_INPUT_INFO")] C2SInputInfo = 404,
    /// <summary>
    ///帧同步信息			//PB_FrameInfo
    /// </summary>
    [pbr::OriginalName("S2C_FRAME_INFO")] S2CFrameInfo = 405,
    /// <summary>
    ///玩家中途强制退出战斗
    /// </summary>
    [pbr::OriginalName("C2S_FIGHT_OUT")] C2SFightOut = 406,
    /// <summary>
    ///客户端结束战斗逻辑
    /// </summary>
    [pbr::OriginalName("C2S_FIGHT_END")] C2SFightEnd = 407,
    /// <summary>
    ///战斗失败/胜利后退出战斗,及结算信息
    /// </summary>
    [pbr::OriginalName("S2C_FIGHT_END")] S2CFightEnd = 408,
    /// <summary>
    ///客户端战斗中资源加载协议
    /// </summary>
    [pbr::OriginalName("FIGHT_LOADING_AGAIN")] FightLoadingAgain = 409,
    /// <summary>
    ///各个模块的公用的协议
    /// </summary>
    [pbr::OriginalName("S2C_NOTIFY_MESSAGE")] S2CNotifyMessage = 500,
    /// <summary>
    ///H5协议
    ///地图协议相关SceneMsgID
    /// </summary>
    [pbr::OriginalName("C2S_SCENE")] C2SScene = 615,
    [pbr::OriginalName("S2C_SCENE")] S2CScene = 616,
    /// <summary>
    ///登录部分AccountMsgID       
    /// </summary>
    [pbr::OriginalName("C2S_ACCOUNT")] C2SAccount = 600,
    [pbr::OriginalName("S2C_ACCOUNT")] S2CAccount = 601,
    /// <summary>
    ///充值系统ChargeMsgID
    /// </summary>
    [pbr::OriginalName("C2S_CHARGE")] C2SCharge = 635,
    [pbr::OriginalName("S2C_CHARGE")] S2CCharge = 636,
    /// <summary>
    ///背包部分BagMsgID
    /// </summary>
    [pbr::OriginalName("C2S_BAG")] C2SBag = 602,
    [pbr::OriginalName("S2C_BAG")] S2CBag = 603,
    /// <summary>
    ///战斗部分CombatMsgID
    /// </summary>
    [pbr::OriginalName("C2S_COMBAT")] C2SCombat = 604,
    [pbr::OriginalName("S2C_COMBAT")] S2CCombat = 605,
    /// <summary>
    ///人物面板PanelMsgID
    /// </summary>
    [pbr::OriginalName("C2S_PANEL")] C2SPanel = 606,
    [pbr::OriginalName("S2C_PANEL")] S2CPanel = 607,
    /// <summary>
    ///GM接口GmMsgID
    /// </summary>
    [pbr::OriginalName("C2S_GM_COMMAND")] C2SGmCommand = 608,
    /// <summary>
    ///获取其他玩家数据显示CommomMsgID
    /// </summary>
    [pbr::OriginalName("C2S_COMMON")] C2SCommon = 609,
    [pbr::OriginalName("S2C_COMMON")] S2CCommon = 610,
    /// <summary>
    ///战局相关协议WarContinuousMsgID
    /// </summary>
    [pbr::OriginalName("GS2C_CONTINUOS_WAR")] Gs2CContinuosWar = 611,
    /// <summary>
    ///战斗相关协议WarMsgID
    /// </summary>
    [pbr::OriginalName("GS2C_WAR")] Gs2CWar = 612,
    /// <summary>
    ///任务相关TaskMsgID
    /// </summary>
    [pbr::OriginalName("C2S_TASK")] C2STask = 613,
    [pbr::OriginalName("S2C_TASK")] S2CTask = 614,
    /// <summary>
    ///提示通知/对白框相关系统消息协议NotifyMsgID
    /// </summary>
    [pbr::OriginalName("C2S_NOTIFY")] C2SNotify = 617,
    [pbr::OriginalName("S2C_NOTIFY")] S2CNotify = 618,
    /// <summary>
    ///NPC系统消息协议NpcMsgID
    /// </summary>
    [pbr::OriginalName("C2S_NPC")] C2SNpc = 619,
    [pbr::OriginalName("S2C_NPC")] S2CNpc = 620,
    /// <summary>
    ///活动相关协议HuodongMsgID
    /// </summary>
    [pbr::OriginalName("C2S_HUODONG")] C2SHuodong = 621,
    [pbr::OriginalName("S2C_HUODONG")] S2CHuodong = 622,
    /// <summary>
    ///summon相关SummonMsgID
    /// </summary>
    [pbr::OriginalName("C2S_SUMMON")] C2SSummon = 623,
    [pbr::OriginalName("S2C_SUMMON")] S2CSummon = 624,
    /// <summary>
    ///聊天系统ChannelMsgID
    /// </summary>
    [pbr::OriginalName("C2S_CHANNEL")] C2SChannel = 625,
    [pbr::OriginalName("S2C_CHANNEL")] S2CChannel = 626,
    /// <summary>
    ///好友系统FriendMsgID
    /// </summary>
    [pbr::OriginalName("C2S_FRIEND")] C2SFriend = 627,
    [pbr::OriginalName("S2C_FRIEND")] S2CFriend = 628,
    /// <summary>
    ///帮派
    /// </summary>
    [pbr::OriginalName("C2S_ALLIANCE")] C2SAlliance = 629,
    [pbr::OriginalName("S2C_ALLIANCE")] S2CAlliance = 630,
    /// <summary>
    ///邮件MailMsgID
    /// </summary>
    [pbr::OriginalName("C2S_MAIL")] C2SMail = 631,
    [pbr::OriginalName("S2C_MAIL")] S2CMail = 632,
    /// <summary>
    ///商店
    /// </summary>
    [pbr::OriginalName("C2GS_SHOP")] C2GsShop = 633,
    [pbr::OriginalName("GS2C_SHOP")] Gs2CShop = 634,
    /// <summary>
    ///和之前活动导表不同的活动HuodongMsgID
    /// </summary>
    [pbr::OriginalName("C2S_HUODONG_OTHER")] C2SHuodongOther = 639,
    [pbr::OriginalName("S2C_HUODONG_OTHER")] S2CHuodongOther = 640,
    /// <summary>
    ///商城StoreMsgID
    /// </summary>
    [pbr::OriginalName("C2S_STORE")] C2SStore = 637,
    [pbr::OriginalName("S2C_STORE")] S2CStore = 638,
    /// <summary>
    /// 排行榜
    /// </summary>
    [pbr::OriginalName("C2S_RANK")] C2SRank = 641,
    [pbr::OriginalName("S2C_RANK")] S2CRank = 642,
    /// <summary>
    /// 活动
    /// </summary>
    [pbr::OriginalName("C2S_ACTIVITY")] C2SActivity = 643,
    [pbr::OriginalName("S2C_ACTIVITY")] S2CActivity = 644,
    /// <summary>
    ///装备
    /// </summary>
    [pbr::OriginalName("C2S_EQUIP")] C2SEquip = 645,
    [pbr::OriginalName("S2C_EQUIP")] S2CEquip = 646,
    /// <summary>
    ///幸运商店
    /// </summary>
    [pbr::OriginalName("C2S_LUCKYSHOP")] C2SLuckyshop = 647,
    [pbr::OriginalName("S2C_LUCKYSHOP")] S2CLuckyshop = 648,
    /// <summary>
    ///红点功能
    /// </summary>
    [pbr::OriginalName("C2S_PROMPT")] C2SPrompt = 649,
    [pbr::OriginalName("S2C_PROMPT")] S2CPrompt = 650,
    /// <summary>
    ///金币兑换水晶
    /// </summary>
    [pbr::OriginalName("C2S_EXCHANGE")] C2SExchange = 651,
    [pbr::OriginalName("S2C_EXCHANGE")] S2CExchange = 652,
  }

  #endregion

  #region Messages
  /// <summary>
  ///提供给所有无内容的消息使用
  /// </summary>
  public sealed partial class PB_None : pb::IMessage<PB_None> {
    private static readonly pb::MessageParser<PB_None> _parser = new pb::MessageParser<PB_None>(() => new PB_None());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PB_None> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Protobuf.MsgIDReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PB_None() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PB_None(PB_None other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PB_None Clone() {
      return new PB_None(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PB_None);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PB_None other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PB_None other) {
      if (other == null) {
        return;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
