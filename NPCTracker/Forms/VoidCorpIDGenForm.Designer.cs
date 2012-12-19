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
  partial class VoidCorpIDGenForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoidCorpIDGenForm));
      this.label1 = new System.Windows.Forms.Label();
      this.RankBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ResultBox = new System.Windows.Forms.TextBox();
      this.GenerateButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Rank:";
      // 
      // RankBox
      // 
      this.RankBox.Location = new System.Drawing.Point(53, 6);
      this.RankBox.MaxLength = 2;
      this.RankBox.Name = "RankBox";
      this.RankBox.Size = new System.Drawing.Size(31, 20);
      this.RankBox.TabIndex = 1;
      this.RankBox.Enter += new System.EventHandler(this.RankBox_Enter);
      this.RankBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RankBox_KeyDown);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 64);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(21, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "ID:";
      // 
      // ResultBox
      // 
      this.ResultBox.BackColor = System.Drawing.SystemColors.Window;
      this.ResultBox.Location = new System.Drawing.Point(53, 61);
      this.ResultBox.Name = "ResultBox";
      this.ResultBox.ReadOnly = true;
      this.ResultBox.Size = new System.Drawing.Size(100, 20);
      this.ResultBox.TabIndex = 4;
      this.ResultBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RankBox_KeyDown);
      // 
      // GenerateButton
      // 
      this.GenerateButton.Location = new System.Drawing.Point(53, 32);
      this.GenerateButton.Name = "GenerateButton";
      this.GenerateButton.Size = new System.Drawing.Size(75, 23);
      this.GenerateButton.TabIndex = 2;
      this.GenerateButton.Text = "Generate";
      this.GenerateButton.UseVisualStyleBackColor = true;
      this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
      // 
      // VoidCorpIDGenForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(168, 89);
      this.Controls.Add(this.GenerateButton);
      this.Controls.Add(this.ResultBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.RankBox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Name = "VoidCorpIDGenForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "VoidCorp ID Generator";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VoidCorpIDGenForm_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox RankBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ResultBox;
    private System.Windows.Forms.Button GenerateButton;
  }
}