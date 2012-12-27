/*
 * Alternity RPG NPC Tracker/Helper
 * By Andrew Barber.
 *
 * Licensed: CC BY-NC 3.0
 * http://creativecommons.org/licenses/by-nc/3.0/
 *
 * More info at the Github repo:  https://github.com/majorcomet/alternityhelper/wiki
 */
namespace Alternity.Forms {
  partial class TextEditor {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditor));
      this.EditorBox = new System.Windows.Forms.TextBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.useDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.closeDontSaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // EditorBox
      // 
      this.EditorBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.EditorBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.EditorBox.Location = new System.Drawing.Point(0, 24);
      this.EditorBox.MaxLength = 2000000;
      this.EditorBox.Multiline = true;
      this.EditorBox.Name = "EditorBox";
      this.EditorBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.EditorBox.Size = new System.Drawing.Size(808, 389);
      this.EditorBox.TabIndex = 0;
      this.EditorBox.TextChanged += new System.EventHandler(this.EditorBox_TextChanged);
      this.EditorBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorBox_KeyDown);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(808, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.useDefaultToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.closeDontSaveToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // useDefaultToolStripMenuItem
      // 
      this.useDefaultToolStripMenuItem.Name = "useDefaultToolStripMenuItem";
      this.useDefaultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.useDefaultToolStripMenuItem.Text = "&Use Default...";
      this.useDefaultToolStripMenuItem.Click += new System.EventHandler(this.useDefaultToolStripMenuItem_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(149, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.saveToolStripMenuItem.Text = "&Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // closeDontSaveToolStripMenuItem
      // 
      this.closeDontSaveToolStripMenuItem.Name = "closeDontSaveToolStripMenuItem";
      this.closeDontSaveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.closeDontSaveToolStripMenuItem.Text = "&Close";
      this.closeDontSaveToolStripMenuItem.Click += new System.EventHandler(this.closeDontSaveToolStripMenuItem_Click);
      // 
      // TextEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(808, 413);
      this.Controls.Add(this.EditorBox);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(220, 250);
      this.Name = "TextEditor";
      this.Text = "Editor";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox EditorBox;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem useDefaultToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem closeDontSaveToolStripMenuItem;
  }
}