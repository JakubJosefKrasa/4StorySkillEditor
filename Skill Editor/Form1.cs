using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SkillEditor
{
    public partial class Form1 : Form
    {
        private List<Skill> l = new List<Skill>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "tcd files (*.tcd) | *.tcd";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                load(ofd.OpenFile());
            }
        }

        private void load(Stream s)
        {
            BinaryReader br = new BinaryReader(s);
            UInt16 count = br.ReadUInt16();

            for (int i = 0; i < count; i++) 
            {
                l.Add(new Skill());
                l[i].Name = br.ReadString();
                l[i].SkillID = br.ReadUInt16();
                l[i].ActSkillID = br.ReadUInt16();
                l[i].NeedItemID = br.ReadUInt16();
                l[i].ClassID = br.ReadUInt32();
                l[i].DefSkillID = br.ReadUInt16();
                l[i].Kind = br.ReadByte();
                l[i].Positive = br.ReadByte();
                l[i].Level = br.ReadByte();
                l[i].LevelInc = br.ReadByte();
                l[i].MaxLevel = br.ReadByte();
                l[i].Price = br.ReadSingle();
                l[i].DuraSlot = br.ReadByte();
                l[i].WeaponID = br.ReadUInt32();
                l[i].UseHP = br.ReadUInt16();
                l[i].NIU1 = br.ReadUInt32();
                l[i].UseMP = br.ReadUInt16();
                l[i].HitInit = br.ReadByte();
                l[i].HitInc = br.ReadByte();
                l[i].SpellTick = br.ReadUInt32();
                l[i].IsRide = br.ReadByte();
                l[i].Delay = br.ReadUInt32();
                l[i].DelayInc = br.ReadInt32();
                l[i].GroupTick = br.ReadUInt32();
                l[i].Interval = br.ReadUInt32();
                l[i].DelayType = br.ReadByte();
                l[i].ModeID = br.ReadUInt16();
                l[i].NIU2 = br.ReadUInt32();
                l[i].TargetType = br.ReadByte();
                l[i].RangeType = br.ReadByte();
                l[i].MinRange = br.ReadSingle();
                l[i].MaxRange = br.ReadSingle();
                l[i].AtkRange = br.ReadSingle();
                l[i].NIU3 = br.ReadUInt32();
                l[i].BufRange = br.ReadSingle();
                l[i].Duration = br.ReadUInt32();
                l[i].DurationInc = br.ReadUInt32();
                l[i].CanCancel = br.ReadByte();
                l[i].Continue = br.ReadByte();
                l[i].NIU4 = br.ReadUInt32();
                l[i].IconID = br.ReadUInt16();
                l[i].ItemID0 = br.ReadUInt16();
                l[i].ItemID1 = br.ReadUInt16();
                l[i].Active = br.ReadByte();
                l[i].Loop = br.ReadByte();
                l[i].ACTION_SPELL = br.ReadByte();
                l[i].ACTION_ACTIVATE = br.ReadByte();
                l[i].ACTION_MOVEACTIVATE = br.ReadByte();
                l[i].ACTION_DEFEND = br.ReadByte();
                l[i].InfoID = br.ReadUInt32();
                l[i].NIU5 = br.ReadUInt32();
                l[i].SFX_SPELL = br.ReadUInt32();
                l[i].SFX_ACT = br.ReadUInt32();
                l[i].SFX_DEFEND = br.ReadUInt32();
                l[i].SFX_DEFENDACT = br.ReadUInt32();
                l[i].SFX_LOOP = br.ReadUInt32();
                l[i].SFX_END = br.ReadUInt32();
                l[i].SFX_ARROW = br.ReadUInt32();
                l[i].ShowIcon = br.ReadByte();
                l[i].ShowTime = br.ReadByte();
                l[i].ShowCritical = br.ReadByte();
                l[i].UseInHold = br.ReadByte();
                l[i].StaticWhenDie = br.ReadByte();
                l[i].MoveDist = br.ReadSingle();
                l[i].NIU6 = br.ReadUInt32();
                l[i].UseMedals = br.ReadUInt16();
                l[i].WORD = br.ReadUInt16();
                l[i].PremIconID = br.ReadByte();
            }
            br.Close();
            loadListBox();
        }

        private void loadListBox()
        {
            int n = 0;
            listBox.Items.Clear();
            foreach (Skill k in l)
            {
                listBox.Items.Add(n + ":" + k.Name);
                n++;
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sli = listBox.SelectedIndex;
            tb_strName.Text = l[sli].Name.ToString();
            tb_wSkillID.Text = l[sli].SkillID.ToString();
            tb_wActSkillID.Text = l[sli].ActSkillID.ToString();
            tb_wNeedItemID.Text = l[sli].NeedItemID.ToString();
            tb_dwClassID.Text = l[sli].ClassID.ToString();
            tb_wDefSkillID.Text = l[sli].DefSkillID.ToString();
            tb_bKind.Text = l[sli].Kind.ToString();
            tb_bPositive.Text = l[sli].Positive.ToString();
            tb_bLevel.Text = l[sli].Level.ToString();
            tb_bLevelInc.Text = l[sli].LevelInc.ToString();
            tb_bMaxLevel.Text = l[sli].MaxLevel.ToString();
            tb_fPrice.Text = l[sli].Price.ToString();
            tb_bDuraSlot.Text = l[sli].DuraSlot.ToString();
            tb_dwWeaponID.Text = l[sli].WeaponID.ToString();
            tb_wUseHP.Text = l[sli].UseHP.ToString();
            tb_wUseMP.Text = l[sli].UseMP.ToString();
            tb_bHitInit.Text = l[sli].HitInit.ToString();
            tb_bHitInc.Text = l[sli].HitInc.ToString();
            tb_dwSpellTick.Text = l[sli].SpellTick.ToString();
            tb_bIsRide.Text = l[sli].IsRide.ToString();
            tb_dwDelay.Text = l[sli].Delay.ToString();
            tb_nDelayInc.Text = l[sli].DelayInc.ToString();
            tb_dwGroupTick.Text = l[sli].GroupTick.ToString();
            tb_dwInterval.Text = l[sli].Interval.ToString();
            tb_bDelayType.Text = l[sli].DelayType.ToString();
            tb_wModeID.Text = l[sli].ModeID.ToString();
            tb_bTargetType.Text = l[sli].TargetType.ToString();
            tb_bRangeType.Text = l[sli].RangeType.ToString();
            tb_fMinRange.Text = l[sli].MinRange.ToString();
            tb_fMaxRange.Text = l[sli].MaxRange.ToString();
            tb_fAtkRange.Text = l[sli].AtkRange.ToString();
            tb_fBufRange.Text = l[sli].BufRange.ToString();
            tb_dwDuration.Text = l[sli].Duration.ToString();
            tb_dwDurationInc.Text = l[sli].DurationInc.ToString();
            tb_bCanCancel.Text = l[sli].CanCancel.ToString();
            tb_bContinue.Text = l[sli].Continue.ToString();
            tb_wIconID.Text = l[sli].IconID.ToString();
            tb_wItemID0.Text = l[sli].ItemID0.ToString();
            tb_wItemID1.Text = l[sli].ItemID1.ToString();
            tb_bActive.Text = l[sli].Active.ToString();
            tb_bLoop.Text = l[sli].Loop.ToString();
            tb_ActionSpell.Text = l[sli].ACTION_SPELL.ToString();
            tb_ActionActivate.Text = l[sli].ACTION_ACTIVATE.ToString();
            tb_ActionMoveActive.Text = l[sli].ACTION_MOVEACTIVATE.ToString();
            tb_ActionDefend.Text = l[sli].ACTION_DEFEND.ToString();
            tb_dwInfoID.Text = l[sli].InfoID.ToString();
            tb_SFXSpell.Text = l[sli].SFX_SPELL.ToString();
            tb_SFXAct.Text = l[sli].SFX_ACT.ToString();
            tb_SFXDefend.Text = l[sli].SFX_DEFEND.ToString();
            tb_SFXDefendAct.Text = l[sli].SFX_DEFENDACT.ToString();
            tb_SFXLoop.Text = l[sli].SFX_LOOP.ToString();
            tb_SFXEnd.Text = l[sli].SFX_END.ToString();
            tb_SFXArrow.Text = l[sli].SFX_ARROW.ToString();
            tb_bShowIcon.Text = l[sli].ShowIcon.ToString();
            tb_bShowTime.Text = l[sli].ShowTime.ToString();
            tb_bShowCritical.Text = l[sli].ShowCritical.ToString();
            tb_bUseInHold.Text = l[sli].UseInHold.ToString();
            tb_bStaticWhenDie.Text = l[sli].StaticWhenDie.ToString();
            tb_fMoveDist.Text = l[sli].MoveDist.ToString();
            tb_wUseMedals.Text = l[sli].UseMedals.ToString();
            tb_bPremIconID.Text = l[sli].PremIconID.ToString();
        }

        private void b_Save_Click(object sender, EventArgs e)
        {
            try
            {
                int sli = listBox.SelectedIndex;
                l[sli].Name = tb_strName.Text;
                l[sli].SkillID = Convert.ToUInt16(tb_wSkillID.Text);
                l[sli].ActSkillID = Convert.ToUInt16(tb_wActSkillID.Text);
                l[sli].NeedItemID = Convert.ToUInt16(tb_wNeedItemID.Text);
                l[sli].ClassID = Convert.ToUInt32(tb_dwClassID.Text);
                l[sli].Kind = Convert.ToByte(tb_bKind.Text);
                l[sli].Positive = Convert.ToByte(tb_bPositive.Text);
                l[sli].Level = Convert.ToByte(tb_bLevel.Text);
                l[sli].LevelInc = Convert.ToByte(tb_bLevelInc.Text);
                l[sli].MaxLevel = Convert.ToByte(tb_bMaxLevel.Text);
                l[sli].Price = Convert.ToSingle(tb_fPrice.Text);
                l[sli].DuraSlot = Convert.ToByte(tb_bDuraSlot.Text);
                l[sli].WeaponID = Convert.ToUInt32(tb_dwWeaponID.Text);
                l[sli].UseHP = Convert.ToUInt16(tb_wUseHP.Text);
                l[sli].UseMP = Convert.ToUInt16(tb_wUseMP.Text);
                l[sli].HitInit = Convert.ToByte(tb_bHitInit.Text);
                l[sli].HitInc = Convert.ToByte(tb_bHitInc.Text);
                l[sli].SpellTick = Convert.ToUInt32(tb_dwSpellTick.Text);
                l[sli].IsRide = Convert.ToByte(tb_bIsRide.Text);
                l[sli].Delay = Convert.ToUInt32(tb_dwDelay.Text);
                l[sli].DelayInc = Convert.ToInt32(tb_nDelayInc.Text);
                l[sli].GroupTick = Convert.ToUInt32(tb_dwGroupTick.Text);
                l[sli].Interval = Convert.ToUInt32(tb_dwInterval.Text);
                l[sli].DelayType = Convert.ToByte(tb_bDelayType.Text);
                l[sli].ModeID = Convert.ToUInt16(tb_wModeID.Text);
                l[sli].TargetType = Convert.ToByte(tb_bTargetType.Text);
                l[sli].RangeType = Convert.ToByte(tb_bRangeType.Text);
                l[sli].MinRange = Convert.ToSingle(tb_fMinRange.Text);
                l[sli].MaxRange = Convert.ToSingle(tb_fMaxRange.Text);
                l[sli].AtkRange = Convert.ToSingle(tb_fAtkRange.Text);
                l[sli].BufRange = Convert.ToSingle(tb_fBufRange.Text);
                l[sli].Duration = Convert.ToUInt32(tb_dwDuration.Text);
                l[sli].DurationInc = Convert.ToUInt32(tb_dwDurationInc.Text);
                l[sli].CanCancel = Convert.ToByte(tb_bCanCancel.Text);
                l[sli].Continue = Convert.ToByte(tb_bContinue.Text);
                l[sli].IconID = Convert.ToUInt16(tb_wIconID.Text);
                l[sli].ItemID0 = Convert.ToUInt16(tb_wItemID0.Text);
                l[sli].ItemID1 = Convert.ToUInt16(tb_wItemID1.Text);
                l[sli].Active = Convert.ToByte(tb_bActive.Text);
                l[sli].Loop = Convert.ToByte(tb_bLoop.Text);
                l[sli].ACTION_SPELL = Convert.ToByte(tb_ActionSpell.Text);
                l[sli].ACTION_ACTIVATE = Convert.ToByte(tb_ActionActivate.Text);
                l[sli].ACTION_MOVEACTIVATE = Convert.ToByte(tb_ActionMoveActive.Text);
                l[sli].ACTION_DEFEND = Convert.ToByte(tb_ActionDefend.Text);
                l[sli].InfoID = Convert.ToUInt32(tb_dwInfoID.Text);
                l[sli].SFX_SPELL = Convert.ToUInt32(tb_SFXSpell.Text);
                l[sli].SFX_ACT = Convert.ToUInt32(tb_SFXAct.Text);
                l[sli].SFX_DEFEND = Convert.ToUInt32(tb_SFXDefend.Text);
                l[sli].SFX_DEFENDACT = Convert.ToUInt32(tb_SFXDefendAct.Text);
                l[sli].SFX_LOOP = Convert.ToUInt32(tb_SFXLoop.Text);
                l[sli].SFX_END = Convert.ToUInt32(tb_SFXEnd.Text);
                l[sli].SFX_ARROW = Convert.ToUInt32(tb_SFXArrow.Text);
                l[sli].ShowIcon = Convert.ToByte(tb_bShowIcon.Text);
                l[sli].ShowTime = Convert.ToByte(tb_bShowTime.Text);
                l[sli].ShowCritical = Convert.ToByte(tb_bShowCritical.Text);
                l[sli].UseInHold = Convert.ToByte(tb_bUseInHold.Text);
                l[sli].StaticWhenDie = Convert.ToByte(tb_bStaticWhenDie.Text);
                l[sli].MoveDist = Convert.ToSingle(tb_fMoveDist.Text);
                l[sli].UseMedals = Convert.ToUInt16(tb_wUseMedals.Text);
                l[sli].PremIconID = Convert.ToByte(tb_bPremIconID.Text);
                loadListBox();
            }

            catch 
            {
                MessageBox.Show("Wrong value");
            }
        }

        private void save(Stream s)
        {
            BinaryWriter bw = new BinaryWriter(s);
            bw.Write(Convert.ToUInt16(l.Count));

            for(int i = 0; i < l.Count; i++) 
            {
                bw.Write(l[i].Name);
                bw.Write(l[i].SkillID);
                bw.Write(l[i].ActSkillID);
                bw.Write(l[i].NeedItemID);
                bw.Write(l[i].ClassID);
                bw.Write(l[i].DefSkillID);
                bw.Write(l[i].Kind);
                bw.Write(l[i].Positive);
                bw.Write(l[i].Level);
                bw.Write(l[i].LevelInc);
                bw.Write(l[i].MaxLevel);
                bw.Write(l[i].Price);
                bw.Write(l[i].DuraSlot);
                bw.Write(l[i].WeaponID);
                bw.Write(l[i].NIU1);
                bw.Write(l[i].UseHP);
                bw.Write(l[i].UseMP);
                bw.Write(l[i].HitInit);
                bw.Write(l[i].HitInc);
                bw.Write(l[i].SpellTick);
                bw.Write(l[i].IsRide);
                bw.Write(l[i].Delay);
                bw.Write(l[i].DelayInc);
                bw.Write(l[i].GroupTick);
                bw.Write(l[i].Interval);
                bw.Write(l[i].DelayType);
                bw.Write(l[i].ModeID);
                bw.Write(l[i].NIU2);
                bw.Write(l[i].TargetType);
                bw.Write(l[i].RangeType);
                bw.Write(l[i].MinRange);
                bw.Write(l[i].MaxRange);
                bw.Write(l[i].AtkRange);
                bw.Write(l[i].NIU3);
                bw.Write(l[i].BufRange);
                bw.Write(l[i].Duration);
                bw.Write(l[i].DurationInc);
                bw.Write(l[i].CanCancel);
                bw.Write(l[i].Continue);
                bw.Write(l[i].NIU4);
                bw.Write(l[i].IconID);
                bw.Write(l[i].ItemID0);
                bw.Write(l[i].ItemID1);
                bw.Write(l[i].Active);
                bw.Write(l[i].Loop);
                bw.Write(l[i].ACTION_SPELL);
                bw.Write(l[i].ACTION_ACTIVATE);
                bw.Write(l[i].ACTION_MOVEACTIVATE);
                bw.Write(l[i].ACTION_DEFEND);
                bw.Write(l[i].InfoID);
                bw.Write(l[i].NIU5);
                bw.Write(l[i].SFX_SPELL);
                bw.Write(l[i].SFX_ACT);
                bw.Write(l[i].SFX_DEFEND);
                bw.Write(l[i].SFX_DEFENDACT);
                bw.Write(l[i].SFX_LOOP);
                bw.Write(l[i].SFX_END);
                bw.Write(l[i].SFX_ARROW);
                bw.Write(l[i].ShowIcon);
                bw.Write(l[i].ShowTime);
                bw.Write(l[i].ShowCritical);
                bw.Write(l[i].UseInHold);
                bw.Write(l[i].StaticWhenDie);
                bw.Write(l[i].MoveDist);
                bw.Write(l[i].NIU6);
                bw.Write(l[i].UseMedals);
                bw.Write(l[i].WORD);
                bw.Write(l[i].PremIconID);
            }
            bw.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "tcd file (*.tcd) | *.tcd";
            if(sfd.ShowDialog() == DialogResult.OK) 
            {
                save(sfd.OpenFile());
                MessageBox.Show("Saved");
            }
        }
    }
}
