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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Alternity.Forms {
  public partial class TextEditor : Form {
    private string DefaultFilePath = "";
    private bool Dirty = false;
    private string FilePath = "";
    public TextEditor() {
      InitializeComponent();
      this.FormClosing += TextEditor_FormClosing;
    }

    public TextEditor(string title, string filePath, string defaultFilePath)
      : this() {
      this.Text = title;
      LoadFile(filePath);
      FilePath = filePath;
      DefaultFilePath = defaultFilePath;
    }

    private void EditorBox_TextChanged(object sender, EventArgs e) {
      Dirty = true;
    }

    private void LoadFile(string filePath) {
      try {
        EditorBox.Text = File.ReadAllText(filePath);
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
      Dirty = false;
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
      File.WriteAllText(FilePath, EditorBox.Text);
      Dirty = false;
    }

    void TextEditor_FormClosing(object sender, FormClosingEventArgs e) {
      if (Dirty) {
        var res = MessageBox.Show("Save data file?", "Closing", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        if (res == System.Windows.Forms.DialogResult.Yes) {
          saveToolStripMenuItem_Click(saveToolStripMenuItem, null);
          this.DialogResult = System.Windows.Forms.DialogResult.OK;
        } else if (res == System.Windows.Forms.DialogResult.Cancel) {
          e.Cancel = true;
        } else if (res == System.Windows.Forms.DialogResult.No) {
          this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
      } else {
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
    }
    private void useDefaultToolStripMenuItem_Click(object sender, EventArgs e) {
      if (MessageBox.Show("This will reload the default values.", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        == System.Windows.Forms.DialogResult.OK) {
        LoadFile(DefaultFilePath);
        Dirty = true;
      }
    }

    private void closeDontSaveToolStripMenuItem_Click(object sender, EventArgs e) {
      this.Close();
    }

    private void EditorBox_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.A && e.Modifiers == Keys.Control) {
        EditorBox.SelectAll();
        e.Handled = true;
      }
    }
  }
}
