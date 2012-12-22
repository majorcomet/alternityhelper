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
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alternity {
  public partial class ToolsWindow : Form {
    private string editor;
    ToolRepository rep = new ToolRepository();
    public ToolsWindow() {
      InitializeComponent();
      string ed = ConfigurationManager.AppSettings["textEditor"];
      if (string.IsNullOrWhiteSpace(ed)) {
        ed = "notepad.exe";
      }
      editor = ed;
      this.FormClosing += ToolsWindow_FormClosing;
      foreach (var tool in rep.ListTools()) {
        ToolList.Items.Add(tool);
      }
    }

    void ToolsWindow_FormClosing(object sender, FormClosingEventArgs e) {
    }

    private void button1_Click(object sender, EventArgs e) {
      ToolRepository rep = new ToolRepository();
      ProcessStartInfo psi = new ProcessStartInfo();
      psi.Arguments = "\"" + rep.ToolsXmlFile + "\"";
      psi.FileName = editor;
      psi.WindowStyle = ProcessWindowStyle.Maximized;
      psi.WorkingDirectory = Path.GetDirectoryName(rep.ToolsXmlFile);
      Process.Start(psi);
    }

    private void ToolsWindow_KeyUp(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Escape) {
        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        e.Handled = true;
      } else if (e.KeyCode == Keys.Enter) {
        OKButton_Click(OKButton, null);
        e.Handled = true;
      }
    }

    private void DeleteButton_Click(object sender, EventArgs e) {
      if (ToolList.SelectedItem == null) {
        return;
      }
      if (MessageBox.Show("Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes) {
        object del = ToolList.SelectedItem;
        ToolList.Items.Remove(del);
      }
    }

    private void AddButton_Click(object sender, EventArgs e) {
      using (ToolDetailForm win = new ToolDetailForm("Add Tool")) {
        if (win.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
          ToolList.Items.Add(win.Tool);
        }
      }
    }

    private void ToolList_DoubleClick(object sender, EventArgs e) {
      Tool tool = ToolList.SelectedItem as Tool;
      if (tool != null) {
        int idx = ToolList.SelectedIndex;
        using (ToolDetailForm win = new ToolDetailForm(tool, "Edit Tool")) {
          if (win.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
            tool.Args = win.Tool.Args;
            tool.Title = win.Tool.Title;
            tool.Path = win.Tool.Path;
            ToolList.Items.Insert(idx, tool);
            ToolList.Items.RemoveAt(idx + 1);
          }
        }
      }
    }
    private void EditButton_Click(object sender, EventArgs e) {
      ToolList_DoubleClick(ToolList, null);
    }

    private void SaveButton_Click(object sender, EventArgs e) {
      if (ToolList.SelectedItem == null) return;
      int idx = ToolList.SelectedIndex;
      object item = ToolList.SelectedItem;
      ToolList.Items.RemoveAt(idx);
      if (idx == 0) idx = ToolList.Items.Count+1;
      idx--;
      ToolList.Items.Insert(idx, item);
      ToolList.SelectedIndex = idx;
    }

    private void OKButton_Click(object sender, EventArgs e) {
      rep.Wipe();
      foreach (var item in ToolList.Items) {
        Tool tool = item as Tool;
        if (tool != null) {
          rep.Add(tool);
        }
      }
      rep.Save();
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
    }


  }
}
