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
  partial class AboutForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.linkLabel2 = new System.Windows.Forms.LinkLabel();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // linkLabel1
      // 
      this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(171, 39);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(101, 13);
      this.linkLabel1.TabIndex = 0;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "More Info on Github";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // linkLabel2
      // 
      this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.linkLabel2.AutoSize = true;
      this.linkLabel2.Location = new System.Drawing.Point(12, 39);
      this.linkLabel2.Name = "linkLabel2";
      this.linkLabel2.Size = new System.Drawing.Size(123, 13);
      this.linkLabel2.TabIndex = 1;
      this.linkLabel2.TabStop = true;
      this.linkLabel2.Text = "Licensed: CC BY-NC 3.0";
      this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
      // 
      // textBox1
      // 
      this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.textBox1.BackColor = System.Drawing.SystemColors.Control;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.textBox1.Location = new System.Drawing.Point(12, 12);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(260, 24);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "Alternity Helper, by Andrew Barber.";
      // 
      // AboutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 61);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.linkLabel2);
      this.Controls.Add(this.linkLabel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutForm";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "About";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AboutForm_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.LinkLabel linkLabel2;
    private System.Windows.Forms.TextBox textBox1;
  }
}