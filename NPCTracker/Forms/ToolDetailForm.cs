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
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alternity {
  public partial class ToolDetailForm : Form {
    
    public ToolDetailForm() {
      InitializeComponent();
      openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    }
    
    public ToolDetailForm(Alternity.Tool tool)
      : this() {
      this.Tool = tool;
      TitleBox.Text = this.Tool.Title;
      PathBox.Text = this.Tool.Path;
      ArgsBox.Text = this.Tool.Args;
    }
    
    public Tool Tool { get; set; }

    private void Cancel_Button_Click(object sender, EventArgs e) {
      this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
    }

    private void PathButton_Click(object sender, EventArgs e) {
      if (!string.IsNullOrWhiteSpace(PathBox.Text)) {
        try {
          if (Directory.Exists(PathBox.Text)) {
            openFileDialog1.InitialDirectory = PathBox.Text;
          } else if (File.Exists(PathBox.Text)) {
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(PathBox.Text);
          } else if (Directory.Exists(Path.GetDirectoryName(PathBox.Text))) {
            openFileDialog1.InitialDirectory = Path.GetDirectoryName(PathBox.Text);
          }
        } catch {
          openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
      } else {
        openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      }
      if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
        PathBox.Text = openFileDialog1.FileName;
      }
    }

    private void SaveButton_Click(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(TitleBox.Text)) {
        MessageBox.Show("Title is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      } else if (string.IsNullOrWhiteSpace(PathBox.Text)) {
        MessageBox.Show("Path is required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      } else if (PathBox.Text.ToLower().StartsWith("http")) {
        // do nothing; just avoid checking the path.
      } else if (!File.Exists(PathBox.Text) && !Directory.Exists(PathBox.Text)) {
        MessageBox.Show("Path does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      this.Tool = new Alternity.Tool { Path = PathBox.Text, Args = ArgsBox.Text, Title = TitleBox.Text };
      DialogResult = System.Windows.Forms.DialogResult.OK;
    }

    private void ToolDetailForm_KeyUp(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        SaveButton_Click(SaveButton, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.Escape) {
        DialogResult = System.Windows.Forms.DialogResult.Cancel;
        e.Handled = true;
      }
    }
  }
}
