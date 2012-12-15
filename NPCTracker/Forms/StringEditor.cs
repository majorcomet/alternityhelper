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
  public partial class StringEditor : Form {
    public StringEditor() {
      InitializeComponent();
    }
    public StringEditor(string title, string initial)
      : this() {
      this.Text = title;
      StringValue = initial;
    }

    public string StringValue {
      get { return textBox1.Text; }
      set { textBox1.Text = value; }
    }

    private void StringEditor_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        button1_Click(button1, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.Escape) {
        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        e.Handled = true;
      }
    }

    private void button1_Click(object sender, EventArgs e) {
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
    }
  }
}
