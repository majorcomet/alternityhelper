/*
 * Alternity RPG NPC Tracker/Helper
 * By Andrew Barber.
 *
 * Licensed: CC BY-NC 3.0
 * http://creativecommons.org/licenses/by-nc/3.0/
 *
 * More info at the Github repo:  https://github.com/majorcomet/alternityhelper/wiki
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alternity.Forms {
  public partial class MovementForm : Form {
    public Movement MovementValue;

    private static Keys[] keys = new Keys[] { Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.D0 };

    private int Deterity;

    private int Strength;

    public MovementForm(Movement movement, int str, int dex)
      : this() {
      this.MovementValue = movement;
      this.Strength = str;
      this.Deterity = dex;
      SetMovementTextValues();
      if (MovementValue.AllZero) {
        GenerateLabel_LinkClicked(GenerateLabel, null);
      }
    }

    private void SetMovementTextValues() {
      SprintBox.Text = MovementValue.Sprint.ToString();
      RunBox.Text = MovementValue.Run.ToString();
      WalkBox.Text = MovementValue.Walk.ToString();
      EasySwimBox.Text = MovementValue.EasySwim.ToString();
      SwimBox.Text = MovementValue.Swim.ToString();
      GlideBox.Text = MovementValue.Glide.ToString();
      FlyBox.Text = MovementValue.Fly.ToString();
    }

    private MovementForm() {
      InitializeComponent();
    }
    private void button3_Click(object sender, EventArgs e) {
      this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
    }

    private void MoveBox_Keypress(object sender, KeyEventArgs e) {
      TextBox box = sender as TextBox;
      if (box != null) {
        if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) {
          int val = 0;
          int.TryParse(box.Text, out val);
          if (e.KeyCode == Keys.Up) {
            val++;
          } else {
            val--;
            if (val < 0) val = 0;
          }
          box.Text = val.ToString();
          e.Handled = true;
        }else if(e.KeyCode== Keys.Back || e.KeyCode== Keys.Delete){
          //do nothing; allow to go through
        } else if (!keys.Contains(e.KeyCode)) {
          e.Handled = true;
        }
      }
    }
    private void MovementForm_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        OKButton_Click(OKButton, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.Escape) {
        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        e.Handled = true;
      } else if (e.KeyCode == Keys.G && e.Modifiers == Keys.Control) {
        GenerateLabel_LinkClicked(GenerateLabel, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control) {
        NoFlyLabel_LinkClicked(NoFlyLabel, null);
        e.Handled = true;
      }
    }

    private void OKButton_Click(object sender, EventArgs e) {
      int ret = 0;
      int.TryParse(SprintBox.Text, out ret);
      MovementValue.Sprint = ret;
      ret = 0;
      int.TryParse(RunBox.Text, out ret);
      MovementValue.Run = ret;
      ret = 0;
      int.TryParse(WalkBox.Text, out ret);
      MovementValue.Walk = ret;
      ret = 0;
      int.TryParse(EasySwimBox.Text, out ret);
      MovementValue.EasySwim = ret;
      ret = 0;
      int.TryParse(SwimBox.Text, out ret);
      MovementValue.Swim = ret;
      ret = 0;
      int.TryParse(GlideBox.Text, out ret);
      MovementValue.Glide = ret;
      ret = 0;
      int.TryParse(FlyBox.Text, out ret);
      MovementValue.Fly = ret;
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
    }

    private void NoFlyLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      FlyBox.Text = GlideBox.Text = "0";
    }

    private void GenerateLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      int tot = this.Strength + this.Deterity;
      Movement m = new Movement();
      if (tot >= 32) {
        m.SetGeneratedValues(32, 22, 8);
      } else if (tot >= 30) {
        m.SetGeneratedValues(30, 20, 8);
      } else if (tot >= 28) {
        m.SetGeneratedValues(28, 18, 6);
      } else if (tot >= 26) {
        m.SetGeneratedValues(26, 16, 6);
      } else if (tot >= 24) {
        m.SetGeneratedValues(24, 16, 6);
      } else if (tot >= 22) {
        m.SetGeneratedValues(22, 14, 4);
      } else if (tot >= 20) {
        m.SetGeneratedValues(20, 12, 4);
      } else if (tot >= 18) {
        m.SetGeneratedValues(18, 12, 4);
      } else if (tot >= 16) {
        m.SetGeneratedValues(16, 10, 4);
      } else if (tot >= 14) {
        m.SetGeneratedValues(14, 10, 4);
      } else if (tot >= 12) {
        m.SetGeneratedValues(12, 8, 2);
      } else if (tot >= 10) {
        m.SetGeneratedValues(10, 6, 2);
      } else if (tot >= 8) {
        m.SetGeneratedValues(8, 6, 2);
      } else if (tot >= 2) {
        m.SetGeneratedValues(6, 4, 2);
      }
      this.MovementValue = m;
      SetMovementTextValues();
    }
  }
}
