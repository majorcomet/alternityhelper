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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alternity.Forms {
  public partial class HelpForm : Form {
    public HelpForm() {
      InitializeComponent();
      HelpBox.BorderStyle = BorderStyle.None;
      string msg = @"In NPC Windows:
  F5: Increase Stun Damage
  F6: Increase Wound Damage
  F7: Increase Mortal Damage
    (Use with SHIFT to decrease damage)
  Click/Right-Click resistance mods to adjust *
  Click/Right-Click Actions label to adjust *
  Right-Click 'Link' to set info shortcut for NPC

In Numeric Text Boxes:
  Up/Down: Adjust Numeric Value *

* These don't work when editing is locked.";
      HelpBox.Text = msg;
      linkLabel1.Focus();
      HelpBox.SelectionStart = 0;
      HelpBox.SelectionLength = 0;
    }

    private void HelpForm_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Escape) {
        e.Handled = true;
        this.Close();
      }
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start("https://github.com/majorcomet/alternityhelper/wiki/Documentation:-Windows");
    }
  }
}
