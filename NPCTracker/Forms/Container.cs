﻿/*
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
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Alternity {

  public partial class Container : Form {
    private DiceRoller roller;

    public Container() {
      InitializeComponent();
      ReloadTools();
    }

    public Container(params string[] files)
      : this() {
      foreach (var fileName in files) {
        if (File.Exists(fileName)) {
          MainForm newMain = new MainForm(fileName);
          newMain.MdiParent = this;
          newMain.Show();
        }
      }
    }

    private void cascadeToolStripMenuItem_Click(object sender, EventArgs e) {
      this.LayoutMdi(MdiLayout.Cascade);
    }

    private void Container_FormClosing(object sender, FormClosingEventArgs e) {
      if (this.WindowState == FormWindowState.Normal) {
        Properties.Settings.Default.Save();
      }
    }

    private void diceRollerToolStripMenuItem_Click(object sender, EventArgs e) {
      ShowRoller();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
      string msg = @"In NPC Windows:
  F5: Increase Stun Damage
  F6: Increase Wound Damage
  F7: Increase Mortal Damage
  (Use SHIFT to decrease damage)
  Click/Right-Click resistance mods to adjust *

In Numeric Text Boxes:
  Up/Down: Adjust Numeric Value *

* These don't work when editing is locked.

";
      MessageBox.Show(msg, "Keys", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e) {
      MainForm newMain = new MainForm(new NPC());
      newMain.MdiParent = this;
      newMain.Show();
    }

    private string lastLocation = SaveLocation.Location;

    private void openToolStripMenuItem_Click(object sender, EventArgs e) {
      openFileDialog1.InitialDirectory = lastLocation;
      if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        foreach (var fileName in openFileDialog1.FileNames) {
          MainForm newMain = new MainForm(fileName);
          newMain.MdiParent = this;
          newMain.Show();
          lastLocation = Path.GetDirectoryName(fileName);
        }
      }
    }

    private void phaseToolStripMenuItem_Click(object sender, EventArgs e) {
      switch (phaseToolStripMenuItem.Text) {
        case "&Phase":
          phaseToolStripMenuItem.Text = "&Phase: Amazing";
          break;

        case "&Phase: Amazing":
          phaseToolStripMenuItem.Text = "&Phase: Good";
          break;

        case "&Phase: Good":
          phaseToolStripMenuItem.Text = "&Phase: Ordinary";
          break;

        case "&Phase: Ordinary":
          phaseToolStripMenuItem.Text = "&Phase: Marginal";
          break;

        default:
          phaseToolStripMenuItem.Text = "&Phase";
          break;
      }
    }

    private void roller_FormClosing(object sender, FormClosingEventArgs e) {
      roller = null;
    }

    private void ShowRoller() {
      if (roller == null) {
        roller = new DiceRoller();
        roller.FormClosing += roller_FormClosing;
        roller.Owner = this;
        roller.Show();
      } else {
        roller.Location = new Point(
          this.Location.X + (this.Size.Width / 2) - (roller.Size.Width / 2),
          this.Location.Y + (this.Size.Height / 2) - (roller.Size.Height / 2)
          );
      }
      roller.Focus();
    }

    private void stackToolStripMenuItem_Click(object sender, EventArgs e) {
      System.Drawing.Point LastLocation = new Point(0, 0);
      var forms = this.MdiChildren.OrderBy(f => f.Text).ToList();
      foreach (var form in forms) {
        form.Location = LastLocation;
        LastLocation = new Point(0, form.Location.Y + form.Size.Height);
      }
    }

    private void editToolStripMenuItem_Click(object sender, EventArgs e) {
      using (ToolsWindow win = new ToolsWindow()) {
        win.ShowDialog();
        ReloadTools();
      }
    }

    private void ReloadTools() {
      ToolRepository rep = new ToolRepository();
      List<ToolStripMenuItem> toDelete = new List<ToolStripMenuItem>();
      foreach (var tool in toolsToolStripMenuItem.DropDownItems) {
        ToolStripMenuItem item = tool as ToolStripMenuItem;
        if (item != null) {
          if (item.Tag.ToString() != "Keep") {
            item.Click -= it_Click;
            toDelete.Add(item);
          }
        }
      }
      foreach (var item in toDelete) {
        toolsToolStripMenuItem.DropDownItems.Remove(item);
      }
      foreach (var tool in rep.ListTools()) {
        ToolStripMenuItem it = new ToolStripMenuItem { Tag = tool, Text = tool.Title.Replace("&", "&&") };
        it.Click += it_Click;
        toolsToolStripMenuItem.DropDownItems.Add(it);
      }
    }

    private Dictionary<string, WebView> WebViews = new Dictionary<string, WebView>();
    private void it_Click(object sender, EventArgs e) {
      Tool tool = ((ToolStripMenuItem)sender).Tag as Tool;
      if (tool != null) {
        if (tool.Path.StartsWith("http")) {
          WebView view = null;
          if (WebViews.ContainsKey(tool.Path)) {
            view = WebViews[tool.Path];
          }
          if (view == null) {
            view = new WebView(tool.Path, tool.Title);
            view.FormClosing += view_FormClosing;
            view.Show();
            WebViews[tool.Path] = view;
          }
          if (view != null) {
            view.Focus(); 
          }
        } else {
          try {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.Arguments = tool.Args;
            psi.FileName = tool.Path;
            psi.WorkingDirectory = Path.GetDirectoryName(tool.Path);
            Process.Start(psi);
          } catch (Exception ex) {
            MessageBox.Show(ex.Message, "Error");
          }
        }
      }
    }

    void view_FormClosing(object sender, FormClosingEventArgs e) {
      WebView view = sender as WebView;
      if (view != null) {
        WebViews.Remove(view.Url);
      }
      view.Dispose();
    }

    private void renameWindowToolStripMenuItem_Click(object sender, EventArgs e) {
      using (StringEditor win = new StringEditor("Set Title", this.Text)) {
        if (win.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
          this.Text = win.StringValue;
          if (string.IsNullOrWhiteSpace(this.Text)) {
            this.Text = "Alternity Helper";
          }
        }
      }
    }

    private void setAllActionPhasesToolStripMenuItem_Click(object sender, EventArgs e) {
      Phase phase = Phase.Marginal;
      int num = 20;
      using (ActionPhases win = new ActionPhases()) {
        if (win.ShowDialog() == System.Windows.Forms.DialogResult.Cancel) {
          return;
        }
        phase = win.ChosenPhase;
        num = win.ChosenNumber;
      }
      foreach (var win in MdiChildren) {
        MainForm frm = win as MainForm;
        if (frm != null) {
          frm.ChosenNumber = num;
          frm.ChosenPhase = phase;
        }
      }
    }
  }
}