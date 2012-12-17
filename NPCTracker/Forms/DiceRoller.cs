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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alternity {
  public partial class DiceRoller : Form {
    Random random = new Random();
    public DiceRoller() {
      InitializeComponent();
      RollButton.Focus();
    }

    private void RollButton_Click(object sender, EventArgs e) {
      RollDie(null, BaseBox, 20);
      RollDie(D4Check, D4Box, 4);
      RollDie(D6Check, D6Box, 6);
      RollDie(D8Check, D8Box, 8);
      RollDie(D12Check, D12Box, 12);
      RollDie(D20aCheck, D20aBox, 20);
      RollDie(D20bCheck, D20bBox, 20);
      RollDie(D20cCheck, D20cBox, 20);
      CalculateTotal();
    }

    private void CalculateTotal() {
      int diff = (int)numericUpDown1.Value;
      if (diff == 0) {
        TotalBox.Text = BaseBox.Text;
      }
      int mult = (diff >= 0 ? 1 : -1);
      int total = int.Parse(BaseBox.Text);
      total += DetermineMod(mult, D4Check, D4Box);
      total += DetermineMod(mult, D6Check, D6Box);
      total += DetermineMod(mult, D8Check, D8Box);
      total += DetermineMod(mult, D12Check, D12Box);
      total += DetermineMod(mult, D20aCheck, D20aBox);
      total += DetermineMod(mult, D20bCheck, D20bBox);
      total += DetermineMod(mult, D20cCheck, D20cBox);
      TotalBox.Text = total.ToString();
    }

    private int DetermineMod(int mult, CheckBox check, TextBox box) {
      if (check.Checked) {
        return int.Parse(box.Text) * mult;
      }
      return 0;
    }

    private void RollDie(CheckBox check, TextBox box, int size) {
      if (check == null || check.Checked) {
        box.Text = GetResult(size);
      } else {
        box.Text = "";
      }
    }

    private string GetResult(int size) {
      return random.Next(1, (size + 1)).ToString();
    }

    private void DiceRoller_KeyUp(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.D && e.Modifiers == Keys.Control) {
        Form owner = this.Owner;
        this.Location = new Point(
          owner.Location.X + (owner.Size.Width / 2) - (this.Size.Width / 2),
          owner.Location.Y + (owner.Size.Height / 2) - (this.Size.Height / 2)
          );
        e.Handled = true;
      }else if (e.KeyCode == Keys.Enter && !RollButton.Focused) {
        RollButton_Click(RollButton, e);
        e.Handled = true;
      } else if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control) {
        CheckAll();
      } else if ((e.KeyCode == Keys.Up || e.KeyCode == Keys.Add) && numericUpDown1.Value < numericUpDown1.Maximum) {
        numericUpDown1.Value = numericUpDown1.Value + 1;
        e.Handled = true;
      } else if ((e.KeyCode == Keys.Down || e.KeyCode == Keys.Subtract) && numericUpDown1.Value > numericUpDown1.Minimum) {
        numericUpDown1.Value = numericUpDown1.Value - 1;
        e.Handled = true;
      } else if (e.KeyCode == Keys.Escape) {
        this.Close();
      }
    }

    private void CheckAll() {
      foreach (var item in this.Controls) {
        CheckBox box = item as CheckBox;
        if (box != null) {
          box.Checked = true;
        }
      }
    }

    private void numericUpDown1_ValueChanged(object sender, EventArgs e) {
      int abs = Math.Abs((int)numericUpDown1.Value);
      switch (abs) {
        case 0:
          UncheckAllBut();
          break;
        case 1:
          UncheckAllBut(D4Check);
          break;
        case 2:
          UncheckAllBut(D6Check);
          break;
        case 3:
          UncheckAllBut(D8Check);
          break;
        case 4:
          UncheckAllBut(D12Check);
          break;
        case 5:
          UncheckAllBut(D20aCheck);
          break;
        case 6:
          UncheckAllBut(D20aCheck, D20bCheck);
          break;
        case 7:
          UncheckAllBut(D20aCheck, D20bCheck, D20cCheck);
          break;
      }
    }

    private void UncheckAllBut(params CheckBox[] boxes) {
      foreach (var item in this.Controls) {
        var box = item as CheckBox;
        if (box != null) {
          box.Checked = boxes.Contains(box);
        }
      }
    }

    private void DieCheck_Changed(object sender, EventArgs e) {
      
    }
  }
}
