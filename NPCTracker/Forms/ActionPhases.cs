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
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alternity {
  public partial class ActionPhases : Form {
    public ActionPhases() {
      InitializeComponent();
      AmazingRadio.Tag = Phase.Amazing;
      GoodRadio.Tag = Phase.Good;
      OrdinaryRadio.Tag = Phase.Ordinary;
      MarginalRadio.Tag = Phase.Marginal;
      NumberRadio.Tag = Phase.Number;
    }
    public Phase ChosenPhase {
      get {
        foreach (var control in groupBox1.Controls) {
          var radio = control as RadioButton;
          if (radio != null && radio.Checked) {
            return (Phase)radio.Tag;
          }
        }
        return Phase.Marginal;
      }
    }
    public int ChosenNumber {
      get {
        int val = 20;
        int.TryParse(NumberBox.Text, out val);
        return val;
      }
    }
    private void button1_Click(object sender, EventArgs e) {
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
    }

    private void ActionPhases_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Escape) {
        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        e.Handled = true;
      } else if (e.KeyCode == Keys.Enter) {
        button1_Click(OKButton, null);
      }
    }

    private Regex NumbersOnly = new Regex("^[0-9]*$");
    private Regex NotNumbers = new Regex("[^0-9]");
    private void NumberBox_TextChanged(object sender, EventArgs e) {
      NumberRadio.Checked = true;
      if (!NumbersOnly.IsMatch(NumberBox.Text)) {
        MessageBox.Show("Numbers only, please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        NumberBox.Text = NotNumbers.Replace(NumberBox.Text, "");
      }
    }

    private void NumberBox_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Up) {
        NumberRadio.Focus();
        e.Handled = true;
      } else if (e.KeyCode == Keys.Down) {
        AmazingRadio.Focus();
        e.Handled = true;
      }
    }
  }
}
