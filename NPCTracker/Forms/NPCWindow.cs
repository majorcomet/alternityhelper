/*
 * Alternity RPG NPC Tracker/Helper
 * By Andrew Barber.
 *
 * Licensed: CC BY-NC 3.0
 * http://creativecommons.org/licenses/by-nc/3.0/
 *
 * More info at my blog: http://www.andrewbarber.com/post.aspx?id=e9252c9b-8ee0-4faa-b144-9f516dfd457a
 */

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;

namespace Alternity {

  public partial class MainForm : Form {
    private const int Max_ResistMod = 6;
    private TextBox[] actionBoxes;
    private TextBox[] ControlsToReadOnly;
    private string LoadedFileName = "";
    private Regex NotValidFileName = new Regex("[^a-zA-Z0-9_.,' -]");
    private Regex NumbersAndSigns = new Regex("^[-+0-9]*$");
    private Regex NumbersOnly = new Regex("^[0-9]*$");
    public MainForm() {
      InitializeComponent();
      this.Load += MainForm_Load;
      actionBoxes = new TextBox[] { ActionCheckAmazingBox, ActionCheckBox, ActionCheckGoodBox, ActionCheckPlusBox };
      foreach (var box in actionBoxes) {
        box.Tag = box.BackColor;
      }
      ControlsToReadOnly = new TextBox[] { STRBox, DEXBox, CONBox, INTBox, WILBox, PERBox, ActionCheckBox, ActionCheckAdjustmentBox,
      StunBox, FatigueBox, WoundBox, MortalBox};
      this.Tool = new Tool();
    }

    public MainForm(string fileName)
      : this() {
      LoadedFileName = fileName;
      try {
        XmlSerializer xmlser = new XmlSerializer(typeof(NPC));
        NPC npc = null;
        using (Stream st = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None)) {
          npc = (NPC)xmlser.Deserialize(st);
        }
        FixDeserializedNPC(npc);
        SetNPC(npc);
      } catch {
        try {
          var formatter = new SoapFormatter();
          NPC npc = null;
          using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None)) {
            npc = (NPC)formatter.Deserialize(fs);
          }
          SetNPC(npc);
          XmlSerializer xmlser = new XmlSerializer(typeof(NPC));
          using (Stream st = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None)) {
            xmlser.Serialize(st, npc);
          }
        } catch (Exception ex) {
          MessageBox.Show(ex.Message, "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          SetNPC(new NPC());
          LoadedFileName = "";
        }
      }
    }

    public MainForm(NPC npc)
      : this() {
      SetNPC(npc);
    }

    public int ChosenNumber { get; set; }

    public Phase ChosenPhase {
      set {
        switch (value) {
          case Phase.Marginal:
            ActionCheckBox_Click(ActionCheckPlusBox, null);
            break;
          case Phase.Ordinary:
            ActionCheckBox_Click(ActionCheckBox, null);
            break;
          case Phase.Good:
            ActionCheckBox_Click(ActionCheckGoodBox, null);
            break;
          case Phase.Amazing:
            ActionCheckBox_Click(ActionCheckAmazingBox, null);
            break;
          case Phase.Number:
            try {
              TextBox[] boxen = new TextBox[] { ActionCheckAmazingBox, ActionCheckGoodBox, ActionCheckBox };
              foreach (var box in boxen) {
                int val = int.Parse(box.Text);
                if (ChosenNumber <= val) {
                  ActionCheckBox_Click(box, null);
                  return;
                }
              }
            } catch { }
            ActionCheckBox_Click(ActionCheckPlusBox, null);
            break;
        }
      }
    }

    public bool EditingLocked {
      get { return LockedButton.Visible; }
      set { LockedButton.Visible = value; }
    }

    public Tool Tool { get; set; }
    public NPC YankNPCObject() {
      NPC npc = new NPC();
      try {
        npc.Locked = LockedButton.Visible;
        npc.ActionCheck = int.Parse(ActionCheckBox.Text);
        npc.Actions = int.Parse(ActionsBox.Text);
        npc.Armor = ArmorBox.Text;
        npc.Constitution = int.Parse(CONBox.Text);
        npc.Dexterity = int.Parse(DEXBox.Text);
        npc.FatigueMax = int.Parse(FatigueBox.Text);
        npc.FatigueTaken = CountChecked(FatiguePanel);
        npc.Intelligence = int.Parse(INTBox.Text);
        npc.MortalMax = int.Parse(MortalBox.Text);
        npc.MortalTaken = CountChecked(MortalPanel);
        npc.Name = this.NPCNameBox.Text;
        npc.Other = this.OtherBox.Text;
        npc.Weapons = this.SkillsBox.Text;
        npc.Personality = int.Parse(PERBox.Text);
        npc.Strength = int.Parse(STRBox.Text);
        npc.StunMax = int.Parse(StunBox.Text);
        npc.StunTaken = CountChecked(StunPanel);
        npc.Will = int.Parse(WILBox.Text);
        npc.WoundMax = int.Parse(WoundBox.Text);
        npc.WoundTaken = CountChecked(WoundPanel);
        npc.StrengthResistMod = (int)STRResistLabel.Tag;
        npc.DexterityResistMod = (int)DEXResistLabel.Tag;
        npc.IntelligenceResistMod = (int)INTResistLabel.Tag;
        npc.WillResistMod = (int)WILResistLabel.Tag;
        npc.ActionCheckAdjustment = int.Parse(this.ActionCheckAdjustmentBox.Text);
        npc.ExtraActions = (int)ActionsLabel.Tag;
        npc.ToolTitle = this.Tool.Title;
        npc.ToolPath = this.Tool.Path;
        npc.ToolArgs = this.Tool.Args;
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
      return npc;
    }

    private void ActionCheckAdjustmentBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersAndSigns.IsMatch(box.Text)) {
        MessageBox.Show("Numbers and +/- only, please");
        return;
      }
      if (box.Text.Length > 0 && !box.Text.StartsWith("-") && !box.Text.StartsWith("+")) {
        box.Text = "+" + box.Text;
      }
    }

    private void ActionCheckBox_Click(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (box != null) {
        TurnRed(box);
      }
    }

    private void ActionCheckBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      try {
        int val = int.Parse(box.Text);
        ActionCheckPlusBox.Text = (val + 1).ToString() + "+";
        ActionCheckGoodBox.Text = (val / 2).ToString();
        ActionCheckAmazingBox.Text = (val / 2 / 2).ToString();
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void ActionsLabel_Click(object sender, MouseEventArgs e) {
      if (EditingLocked) return;
      int adj = (int)ActionsLabel.Tag;
      if (e.Button == System.Windows.Forms.MouseButtons.Left) {
        adj++;
      } else if (e.Button == System.Windows.Forms.MouseButtons.Right) {
        adj--;
      }
      if (adj < 0) adj = 0;
      if (adj > 3) adj = 3;
      ActionsLabel.Tag = adj;
      RecalcActions();
    }

    private void ArmorSetButton_Click(object sender, EventArgs e) {
      using (ChooseArmor win = new ChooseArmor()) {
        if (win.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
          if (win.ChosenArmor != null) {
            ArmorBox.Text = win.ChosenArmor.Data;
          }
        }
      }
    }

    private void Box_(object sender, MouseEventArgs e) {
      Box_Enter(sender, null);
    }

    private void Box_Enter(object sender, EventArgs e) {
      if (EditingLocked) return;
      TextBox o = sender as TextBox;
      o.SelectAll();
    }

    private void CheckBox_CheckChanged(object sender, EventArgs e) {
      SetWindowName();
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e) {
      this.SetWindowName();
    }

    private void CONBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      RecalcActions();
    }

    private int CountChecked(Panel panel) {
      int ret = 0;
      foreach (var control in panel.Controls) {
        var check = control as CheckBox;
        if (check != null && check.Visible && check.Checked) {
          ret++;
        }
      }
      return ret;
    }

    private void DecreaseCheckByOne(Panel panel) {
      Dictionary<string, CheckBox> boxes = new Dictionary<string, CheckBox>();
      foreach (var box in panel.Controls) {
        CheckBox cbox = box as CheckBox;
        if (cbox != null) {
          boxes.Add(cbox.Name, cbox);
        }
      }
      foreach (var key in boxes.Keys.OrderByDescending(k => k).ToList()) {
        var box = boxes[key];
        if (box.Visible && box.Checked) {
          box.Checked = false;
          return;
        }
      }
    }

    private void DEXBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      try {
        int val = int.Parse(DEXBox.Text);
        DEXResistLabel.Text = GetResistMod(val, DEXResistLabel);
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void FatigueBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      try {
        int val = int.Parse(box.Text);
        if (val > 0 && val < 21) {
          HowManyCheckBoxes(FatiguePanel, val);
        }
        SetWindowName();
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void FixDeserializedNPC(NPC npc) {
      npc.Other = npc.Other.Replace("\n", "\r\n");
      npc.Weapons = npc.Weapons.Replace("\n", "\r\n");
    }
    private string FixFileName(string name) {
      return NotValidFileName.Replace(name, "");
    }

    private string GetResistMod(int value, Label label) {
      int val = 0;
      switch (value) {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
          val = -2;
          break;

        case 5:
        case 6:
          val = -1;
          break;

        case 11:
        case 12:
          val = 1;
          break;

        case 13:
        case 14:
          val = 2;
          break;

        case 15:
        case 16:
          val = 3;
          break;

        case 17:
        case 18:
          val = 4;
          break;
      }
      if (value >= 19) val = 5;
      int adj = (int)label.Tag;
      val += adj;
      if (val >= 0) {
        return "+" + val.ToString();
      } else {
        return val.ToString();
      }
    }

    private void HowManyCheckBoxes(Panel panel, int number) {
      Dictionary<string, CheckBox> boxes = new Dictionary<string, CheckBox>();
      foreach (var item in panel.Controls) {
        var checkBox = item as CheckBox;
        if (checkBox != null) {
          boxes.Add(checkBox.Name, checkBox);
        }
      }
      int done = 0;
      foreach (var key in boxes.Keys.OrderBy(k => k).ToList()) {
        var box = boxes[key];
        box.Visible = done < number;
        done++;
      }
    }

    private void IncreaseCheckByOne(Panel panel) {
      Dictionary<string, CheckBox> boxes = new Dictionary<string, CheckBox>();
      foreach (var box in panel.Controls) {
        CheckBox cbox = box as CheckBox;
        if (cbox != null) {
          boxes.Add(cbox.Name, cbox);
        }
      }
      foreach (var key in boxes.Keys.OrderBy(k => k).ToList()) {
        var box = boxes[key];
        if (box.Visible && !box.Checked) {
          box.Checked = true;
          return;
        }
      }
      SetTaken(panel, 0);
    }

    private void INTBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      try {
        int val = int.Parse(INTBox.Text);
        INTResistLabel.Text = GetResistMod(val, INTResistLabel);
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void LockedButton_Click(object sender, EventArgs e) {
      LockedButton.Visible = !LockedButton.Visible;
    }

    private void LockedButton_VisibleChanged(object sender, EventArgs e) {
      bool locked = LockedButton.Visible;
      UnlockedButton.Visible = !locked;
      foreach (var control in ControlsToReadOnly) {
        control.ReadOnly = locked;
      }
      if (locked) {
        foreach (var control in ControlsToReadOnly) {
          control.BackColor = SystemColors.Window;
        }
      }
    }

    private void MainForm_KeyUp(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.K && e.Modifiers == Keys.Control) {
        KOCheckBox.Checked = !KOCheckBox.Checked;
        e.Handled = true;
      } else if (e.KeyCode == Keys.L && e.Modifiers == Keys.Control) {
        LockedButton_Click(LockedButton, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control) {
        SaveButton_Click(SaveButton, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.W && e.Modifiers == Keys.Control) {
        WeaponAddButton_Click(WeaponAddButton, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.I && e.Modifiers == Keys.Control) {
        OtherInfoButton_Click(OtherInfoButton, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.F5 && e.Modifiers == Keys.Shift) {
        DecreaseCheckByOne(StunPanel);
        e.Handled = true;
      } else if (e.KeyCode == Keys.F6 && e.Modifiers == Keys.Shift) {
        DecreaseCheckByOne(WoundPanel);
        e.Handled = true;
      } else if (e.KeyCode == Keys.F7 && e.Modifiers == Keys.Shift) {
        DecreaseCheckByOne(MortalPanel);
        e.Handled = true;
      } else if (e.KeyCode == Keys.F5) {
        IncreaseCheckByOne(StunPanel);
        e.Handled = true;
      } else if (e.KeyCode == Keys.F6) {
        IncreaseCheckByOne(WoundPanel);
        e.Handled = true;
      } else if (e.KeyCode == Keys.F7) {
        IncreaseCheckByOne(MortalPanel);
        e.Handled = true;
      }
    }

    private void MainForm_Load(object sender, EventArgs e) {
      SetWindowName();
    }

    private void MortalBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      try {
        int val = int.Parse(box.Text);
        if (val > 0 && val < 21) {
          HowManyCheckBoxes(MortalPanel, val);
        }
        SetWindowName();
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void NPCNameBox_TextChanged(object sender, EventArgs e) {
      SetWindowName();
    }

    private void NumberBox_KeyUp(object sender, KeyEventArgs e) {
      if (EditingLocked) return;
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract) {
        TextBox box = sender as TextBox;
        if (box != null) {
          try {
            string boxText = box.Text;
            if (boxText == "") boxText = "0";
            int value = int.Parse(boxText);
            switch (e.KeyCode) {
              case Keys.Subtract:
              case Keys.Down:
                value--;
                break;

              case Keys.Add:
              case Keys.Up:
                value++;
                break;
            }
            if (box.Name == ActionCheckAdjustmentBox.Name) {
              if (value < -9) value = -9;
              if (value > 9) value = 9;
            } else {
              if (value < 1) value = 1;
              if (value > 10 && (box.Name == FatigueBox.Name || box.Name == MortalBox.Name)) value = 10;
              if (value > 20 && (box.Name == WoundBox.Name || box.Name == StunBox.Name)) value = 20;
            }
            box.Text = value.ToString();
          } catch { }
        }
      }
    }

    private void OtherInfoButton_Click(object sender, EventArgs e) {
      OtherBox.BringToFront();
      if (OtherBox.Visible = !OtherBox.Visible) {
        OtherBox.Focus();
        SetTopBoxesEnabled(false);
        OtherBox.Select(0, 0);
      } else {
        SetTopBoxesEnabled(true);
        OtherBox.Text = OtherBox.Text.Trim();
        if (OtherBox.Text.Length > 0) {
          OtherBox.Text += "\r\n";
        }
      }
    }

    private void PERBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
    }

    private void RecalcActions() {
      try {
        int conwil = int.Parse(CONBox.Text) + int.Parse(WILBox.Text);
        int acts = 0;
        if (conwil <= 15) {
          acts = 1;
        } else if (conwil <= 23) {
          acts = 2;
        } else if (conwil <= 31) {
          acts = 3;
        } else if (conwil > 31) {
          acts = 4;
        }
        int adj = (int)ActionsLabel.Tag;
        acts += adj;
        ActionsBox.Text = acts.ToString();
        toolTip1.SetToolTip(ActionsLabel, string.Format("Number of Actions ({0} extra)", adj));
      } catch {
      }
    }

    private void ResistModLabels_Click(object sender, MouseEventArgs e) {
      if (EditingLocked) return;
      Label label = sender as Label;
      if (label != null) {
        int val = (int)label.Tag;
        if (e.Button == System.Windows.Forms.MouseButtons.Left) {
          val++;
        } else if (e.Button == System.Windows.Forms.MouseButtons.Right) {
          val--;
        }
        int negMRM = -1 * Max_ResistMod;
        if (val > Max_ResistMod) val = Max_ResistMod;
        if (val < negMRM) val = negMRM;
        label.Tag = val;
        STRBox_TextChanged(STRBox, null);
        DEXBox_TextChanged(DEXBox, null);
        INTBox_TextChanged(INTBox, null);
        WILBox_TextChanged(WILBox, null);
        SetResistModLabelToolTip(label);
      }
    }

    private void SaveButton_Click(object sender, EventArgs e) {
      saveFileDialog1.InitialDirectory = Alternity.SaveLocation.Location;
      if (!string.IsNullOrWhiteSpace(LoadedFileName)) {
        string dir = Path.GetDirectoryName(LoadedFileName);
        if (Directory.Exists(dir)) {
          saveFileDialog1.InitialDirectory = dir;
          saveFileDialog1.FileName = LoadedFileName;
        }
      } else {
        saveFileDialog1.FileName = FixFileName(NPCNameBox.Text);
      }
      if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        NPC npc = YankNPCObject();
        string fileName = saveFileDialog1.FileName;
        try {
          XmlSerializer xmlser = new XmlSerializer(typeof(NPC));
          using (Stream st = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None)) {
            xmlser.Serialize(st, npc);
          }
          LoadedFileName = fileName;
        } catch (Exception ex) {
          MessageBox.Show(ex.Message, "Error Saving");
        }
      }
    }
    private void SetNPC(NPC npc) {
      STRResistLabel.Tag = npc.StrengthResistMod;
      DEXResistLabel.Tag = npc.DexterityResistMod;
      INTResistLabel.Tag = npc.IntelligenceResistMod;
      WILResistLabel.Tag = npc.WillResistMod;
      ActionsLabel.Tag = npc.ExtraActions;
      LockedButton.Visible = npc.Locked;
      SetResistModLabelToolTip(STRResistLabel);
      SetResistModLabelToolTip(DEXResistLabel);
      SetResistModLabelToolTip(INTResistLabel);
      SetResistModLabelToolTip(WILResistLabel);
      ActionCheckAdjustmentBox.Text = npc.ActionCheckAdjustment.ToString();
      ActionCheckBox.Text = npc.ActionCheck.ToString();
      ActionsBox.Text = npc.Actions.ToString();
      ArmorBox.Text = npc.Armor;
      CONBox.Text = npc.Constitution.ToString();
      DEXBox.Text = npc.Dexterity.ToString();
      FatigueBox.Text = npc.FatigueMax.ToString();
      SetTaken(FatiguePanel, npc.FatigueTaken);
      INTBox.Text = npc.Intelligence.ToString();
      MortalBox.Text = npc.MortalMax.ToString();
      SetTaken(MortalPanel, npc.MortalTaken);
      NPCNameBox.Text = npc.Name;
      SkillsBox.Text = npc.Weapons;
      OtherBox.Text = npc.Other;
      PERBox.Text = npc.Personality.ToString();
      STRBox.Text = npc.Strength.ToString();
      StunBox.Text = npc.StunMax.ToString();
      SetTaken(StunPanel, npc.StunTaken);
      WILBox.Text = npc.Will.ToString();
      WoundBox.Text = npc.WoundMax.ToString();
      SetTaken(WoundPanel, npc.WoundTaken);
      this.Tool.Title = npc.ToolTitle;
      this.Tool.Path = npc.ToolPath;
      this.Tool.Args = npc.ToolArgs;
      SetToolLinkToolTip();
    }
    private void SetToolLinkToolTip() {
      if (string.IsNullOrEmpty(this.Tool.Title) || string.IsNullOrEmpty(this.Tool.Path)) {
        toolTip1.SetToolTip(ToolLink, "No tool set.");
      } else {
        toolTip1.SetToolTip(ToolLink, this.Tool.Title);
      }
    }

    private void SetResistModLabelToolTip(Label label) {
      int val = (int)label.Tag;
      string text = "Resist Mod Adjustment: " + val.ToString() + "\r\nClick to increase; right-click to decrease";
      toolTip1.SetToolTip(label, text);
    }

    private void SetTaken(Panel panel, int taken) {
      Dictionary<string, CheckBox> boxes = new Dictionary<string, CheckBox>();
      foreach (var item in panel.Controls) {
        var checkBox = item as CheckBox;
        if (checkBox != null) {
          boxes.Add(checkBox.Name, checkBox);
        }
      }
      int done = 0;
      foreach (var key in boxes.Keys.OrderBy(k => k).ToList()) {
        var box = boxes[key];
        box.Checked = done < taken;
        done++;
      }
    }

    private void SetTopBoxesEnabled(bool enabled) {
      Control[] boxes = new Control[] {
        NPCNameBox, ActionCheckBox, STRBox, INTBox, DEXBox, PERBox, WILBox, CONBox, ArmorBox, ArmorSetButton, ActionCheckAdjustmentBox
      };
      foreach (var box in boxes) {
        box.Enabled = enabled;
      }
    }

    private void SetWindowName() {
      this.Text = (NPCNameBox.Text.Length == 0 ? "NPC" : NPCNameBox.Text)
        + " - " +
        string.Format("({1}/{0}s)", StunBox.Text, CountChecked(StunPanel)) +
        " " +
        string.Format("({1}/{0}w)", WoundBox.Text, CountChecked(WoundPanel)) +
        " " +
        string.Format("({1}/{0}m)", MortalBox.Text, CountChecked(MortalPanel))
        + (KOCheckBox.Checked ? " **KO**" : "");
    }

    private void STRBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      try {
        int val = int.Parse(STRBox.Text);
        STRResistLabel.Text = GetResistMod(val, STRResistLabel);
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void StunBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      try {
        int val = int.Parse(box.Text);
        if (val > 0 && val < 21) {
          HowManyCheckBoxes(StunPanel, val);
        }
        SetWindowName();
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void TextBox_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control) {
        TextBox box = sender as TextBox;
        if (box != null) {
          box.SelectAll();
          e.Handled = true;
        }
      }
    }

    private void ToolLink_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == System.Windows.Forms.MouseButtons.Left) {
        if (!string.IsNullOrEmpty(this.Tool.Path)) {
          try {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = this.Tool.Path;
            if (!string.IsNullOrEmpty(this.Tool.Args)) {
              psi.Arguments = this.Tool.Args;
            }
            Process.Start(psi);
          } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          }
        } else {
          MessageBox.Show("No tool set. Right-Click to set one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
      } else if (e.Button == System.Windows.Forms.MouseButtons.Right) {
        using (ToolDetailForm win = new ToolDetailForm(this.Tool)) {
          if (win.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
            this.Tool = win.Tool;
            SetToolLinkToolTip();
          }
        }
      }
    }

    private void TurnRed(TextBox box) {
      foreach (var bx in actionBoxes) {
        bx.BackColor = (Color)bx.Tag;
      }
      box.BackColor = System.Drawing.Color.Pink;
    }

    private void WeaponAddButton_Click(object sender, EventArgs e) {
      using (ChooseWeapon win = new ChooseWeapon()) {
        if (win.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
          if (win.ChosenWeapon != null) {
            SkillsBox.Text = (SkillsBox.Text.Trim() + "\r\n" + win.ChosenWeapon.Data).Trim() + "\r\n";
          }
        }
      }
    }

    private void WILBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      try {
        int val = int.Parse(WILBox.Text);
        WILResistLabel.Text = GetResistMod(val, WILResistLabel);
        RecalcActions();
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

    private void WoundBox_TextChanged(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (!NumbersOnly.IsMatch(box.Text)) {
        MessageBox.Show("Numbers only, please");
        return;
      }
      if (box.Text.Length == 0) return;
      try {
        int val = int.Parse(box.Text);
        if (val > 0 && val < 21) {
          HowManyCheckBoxes(WoundPanel, val);
        }
        SetWindowName();
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }
  }
}