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
  public partial class AboutForm : Form {
    public AboutForm() {
      InitializeComponent();
    }

    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start("https://github.com/majorcomet/alternityhelper/wiki");
    }

    private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
      Process.Start("http://creativecommons.org/licenses/by-nc/3.0/");
    }

    private void AboutForm_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Escape) {
        this.Close();
      }
    }
  }
}
