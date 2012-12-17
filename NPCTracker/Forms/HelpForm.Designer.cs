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
  partial class HelpForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
      this.linkLabel1 = new System.Windows.Forms.LinkLabel();
      this.HelpBox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // linkLabel1
      // 
      this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.linkLabel1.AutoSize = true;
      this.linkLabel1.Location = new System.Drawing.Point(12, 204);
      this.linkLabel1.Name = "linkLabel1";
      this.linkLabel1.Size = new System.Drawing.Size(105, 13);
      this.linkLabel1.TabIndex = 1;
      this.linkLabel1.TabStop = true;
      this.linkLabel1.Text = "More Help on Github";
      this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
      // 
      // HelpBox
      // 
      this.HelpBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.HelpBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.HelpBox.Location = new System.Drawing.Point(12, 12);
      this.HelpBox.Multiline = true;
      this.HelpBox.Name = "HelpBox";
      this.HelpBox.ReadOnly = true;
      this.HelpBox.Size = new System.Drawing.Size(288, 173);
      this.HelpBox.TabIndex = 0;
      // 
      // HelpForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(312, 226);
      this.Controls.Add(this.linkLabel1);
      this.Controls.Add(this.HelpBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "HelpForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Help";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HelpForm_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.LinkLabel linkLabel1;
    private System.Windows.Forms.TextBox HelpBox;
  }
}