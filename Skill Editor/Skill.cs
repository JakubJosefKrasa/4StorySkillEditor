using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillEditor
{
    class Skill
    {
        private string strName;
		private UInt16 wSkillID;
		private UInt16 wActSkillID;
		private UInt16 wNeedItemID;
		private UInt32 dwClassID;
		private UInt16 wDefSkillID;
		private Byte bKind;
		private Byte bPositive;
		private Byte bLevel;
		private Byte bLevelInc;
		private Byte bMaxLevel;
		private float fPrice;
		private Byte bDuraSlot;
		private UInt32 dwWeaponID;
		private UInt16 wUseHP;
		private UInt32 dwNIU1;
		private UInt16 wUseMP;
		private Byte bHitInit;
		private	Byte	bHitInc;						
		private UInt32 dwSpellTick;
		private Byte bIsRide;
		private UInt32 dwDelay;
		private int nDelayInc;
		private UInt32 dwGroupTick;
		private UInt32 dwInterval;
		private Byte bDelayType;
		private UInt16 wModeID;
		private UInt32 dwNIU2;
		private Byte bTargetType;
		private Byte bRangeType;
		private float fMinRange;
		private float fMaxRange;
		private float fAtkRange;
		private UInt32 dwNIU3;
		private float fBufRange;
		private UInt32 dwDuration;
		private UInt32 dwDurationInc;
		private Byte bCanCancel;
		private Byte bContinue;
		private UInt32 dwNIU4;
		private UInt16 wIconID;
		private UInt16 wItemID0;
		private UInt16 wItemID1;
		private Byte bActive;
		private Byte bLoop;
		private Byte bACTION_SPELL;
		private Byte bACTION_ACTIVATE;
		private Byte bACTION_MOVEACTIVATE;
		private Byte bACTION_DEFEND;
		private UInt32 dwInfoID;
		private UInt32 dwNIU5;
		private UInt32 dwSFX_SPELL;
		private UInt32 dwSFX_ACT;
		private UInt32 dwSFX_DEFEND;
		private UInt32 dwSFX_DEFENDACT;
		private UInt32 dwSFX_LOOP;
		private UInt32 dwSFX_END;
		private UInt32 dwSFX_ARROW;
		private Byte bShowIcon;
		private Byte bShowTime;
		private Byte bShowCritical;
		private Byte bUseInHold;
		private Byte bStaticWhenDie;
		private float fMoveDist;
		private UInt32 dwNIU6;
		private UInt16 wUseMedals;
		private UInt16 wWORD;
		private Byte bPremIconID;

		public string Name 
		{ 
			get { return strName; }
			set { strName = value; }
		}

		public UInt16 SkillID
		{
			get { return wSkillID; }
			set { wSkillID = value; }
		}

		public UInt16 ActSkillID
		{
			get { return wActSkillID; }
			set { wActSkillID = value; }
		}

		public UInt16 NeedItemID
		{
			get { return wNeedItemID; }
			set { wNeedItemID = value; }
		}

		public UInt32 ClassID
		{
			get { return dwClassID; }
			set { dwClassID = value; }
		}

		public UInt16 DefSkillID
		{
			get { return wDefSkillID; }
			set { wDefSkillID = value; }
		}

		public Byte Kind
		{
			get { return bKind; }
			set { bKind = value; }
		}

		public Byte Positive
		{
			get { return bPositive; }
			set { bPositive = value; }
		}
		public Byte Level
		{
			get { return bLevel; }
			set { bLevel = value; }
		}

		public Byte LevelInc
		{
			get { return bLevelInc; }
			set { bLevelInc = value; }
		}

		public Byte MaxLevel
		{
			get { return bMaxLevel; }
			set { bMaxLevel = value; }
		}

		public float Price
		{
			get { return fPrice; }
			set { fPrice = value; }
		}

		public Byte DuraSlot
		{
			get { return bDuraSlot; }
			set { bDuraSlot = value; }
		}

		public UInt32 WeaponID
		{
			get { return dwWeaponID; }
			set { dwWeaponID = value; }
		}
		public UInt16 UseHP
		{
			get { return wUseHP; }
			set { wUseHP = value; }
		}
		public UInt32 NIU1
		{
			get { return dwNIU1; }
			set { dwNIU1 = value; }
		}

		public UInt16 UseMP
		{
			get { return wUseMP; }
			set { wUseMP = value; }
		}

		public Byte HitInit
		{
			get { return bHitInit; }
			set { bHitInit = value; }
		}

		public Byte HitInc
		{
			get { return bHitInc; }
			set { bHitInc = value; }
		}

		public UInt32 SpellTick
		{
			get { return dwSpellTick; }
			set { dwSpellTick = value; }
		}

		public Byte IsRide
		{
			get { return bIsRide; }
			set { bIsRide = value; }
		}

		public UInt32 Delay
		{
			get { return dwDelay; }
			set { dwDelay = value; }
		}

		public int DelayInc
		{
			get { return nDelayInc; }
			set { nDelayInc = value; }
		}

		public UInt32 GroupTick
		{
			get { return dwGroupTick; }
			set { dwGroupTick = value; }
		}

		public UInt32 Interval
		{
			get { return dwInterval; }
			set { dwInterval = value; }
		}

		public Byte DelayType
		{
			get { return bDelayType; }
			set { bDelayType = value; }
		}

		public UInt16 ModeID
		{
			get { return wModeID; }
			set { wModeID = value; }
		}
		public UInt32 NIU2
		{
			get { return dwNIU2; }
			set { dwNIU2 = value; }
		}

		public Byte TargetType
		{
			get { return bTargetType; }
			set { bTargetType = value; }
		}

		public Byte RangeType
		{
			get { return bRangeType; }
			set { bRangeType = value; }
		}

		public float MinRange
		{
			get { return fMinRange; }
			set { fMinRange = value; }
		}

		public float MaxRange
		{
			get { return fMaxRange; }
			set { fMaxRange = value; }
		}

		public float AtkRange
		{
			get { return fAtkRange; }
			set { fAtkRange = value; }
		}
		public UInt32 NIU3
		{
			get { return dwNIU3; }
			set { dwNIU3 = value; }
		}
		public float BufRange
		{
			get { return fBufRange; }
			set { fBufRange = value; }
		}

		public UInt32 Duration
		{
			get { return dwDuration; }
			set { dwDuration = value; }
		}

		public UInt32 DurationInc
		{
			get { return dwDurationInc; }
			set { dwDurationInc = value; }
		}

		public Byte CanCancel
		{
			get { return bCanCancel; }
			set { bCanCancel = value; }
		}

		public Byte Continue
		{
			get { return bContinue; }
			set { bContinue = value; }
		}

		public UInt32 NIU4
		{
			get { return dwNIU4; }
			set { dwNIU4 = value; }
		}
		public UInt16 IconID
		{
			get { return wIconID; }
			set { wIconID = value; }
		}

		public UInt16 ItemID0
		{
			get { return wItemID0; }
			set { wItemID0 = value; }
		}

		public UInt16 ItemID1
		{
			get { return wItemID1; }
			set { wItemID1 = value; }
		}

		public Byte Active
		{
			get { return bActive; }
			set { bActive = value; }
		}

		public Byte Loop
		{
			get { return bLoop; }
			set { bLoop = value; }
		}

		public Byte ACTION_SPELL
		{
			get { return bACTION_SPELL; }
			set { bACTION_SPELL = value; }
		}

		public Byte ACTION_ACTIVATE
		{
			get { return bACTION_ACTIVATE; }
			set { bACTION_ACTIVATE = value; }
		}

		public Byte ACTION_MOVEACTIVATE
		{
			get { return bACTION_MOVEACTIVATE; }
			set { bACTION_MOVEACTIVATE = value; }
		}

		public Byte ACTION_DEFEND
		{
			get { return bACTION_DEFEND; }
			set { bACTION_DEFEND = value; }
		}

		public UInt32 InfoID
		{
			get { return dwInfoID; }
			set { dwInfoID = value; }
		}
		public UInt32 NIU5
		{
			get { return dwNIU5; }
			set { dwNIU5 = value; }
		}
		public UInt32 SFX_SPELL
		{
			get { return dwSFX_SPELL; }
			set { dwSFX_SPELL = value; }
		}

		public UInt32 SFX_ACT
		{
			get { return dwSFX_ACT; }
			set { dwSFX_ACT = value; }
		}

		public UInt32 SFX_DEFEND
		{
			get { return dwSFX_DEFEND; }
			set { dwSFX_DEFEND = value; }
		}

		public UInt32 SFX_DEFENDACT
		{
			get { return dwSFX_DEFENDACT; }
			set { dwSFX_DEFENDACT = value; }
		}

		public UInt32 SFX_LOOP
		{
			get { return dwSFX_LOOP; }
			set { dwSFX_LOOP = value; }
		}

		public UInt32 SFX_END
		{
			get { return dwSFX_END; }
			set { dwSFX_END = value; }
		}

		public UInt32 SFX_ARROW
		{
			get { return dwSFX_ARROW; }
			set { dwSFX_ARROW = value; }
		}

		public Byte ShowIcon
		{
			get { return bShowIcon; }
			set { bShowIcon = value; }
		}

		public Byte ShowTime
		{
			get { return bShowTime; }
			set { bShowTime = value; }
		}

		public Byte ShowCritical
		{
			get { return bShowCritical; }
			set { bShowCritical = value; }
		}

		public Byte UseInHold
		{
			get { return bUseInHold; }
			set { bUseInHold = value; }
		}

		public Byte StaticWhenDie
		{
			get { return bStaticWhenDie; }
			set { bStaticWhenDie = value; }
		}

		public float MoveDist
		{
			get { return fMoveDist; }
			set { fMoveDist = value; }
		}

		public UInt32 NIU6
		{
			get { return dwNIU6; }
			set { dwNIU6 = value; }
		}

		public UInt16 UseMedals
		{
			get { return wUseMedals; }
			set { wUseMedals = value; }
		}

		public UInt16 WORD
		{
			get { return wWORD; }
			set { wWORD = value; }
		}

		public Byte PremIconID
		{
			get { return bPremIconID; }
			set { bPremIconID = value; }
		}

	}
}
