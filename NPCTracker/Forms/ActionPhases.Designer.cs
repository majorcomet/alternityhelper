﻿namespace Alternity {
  partial class ActionPhases {
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActionPhases));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.NumberBox = new System.Windows.Forms.TextBox();
      this.NumberRadio = new System.Windows.Forms.RadioButton();
      this.MarginalRadio = new System.Windows.Forms.RadioButton();
      this.OrdinaryRadio = new System.Windows.Forms.RadioButton();
      this.GoodRadio = new System.Windows.Forms.RadioButton();
      this.AmazingRadio = new System.Windows.Forms.RadioButton();
      this.OKButton = new System.Windows.Forms.Button();
      this.Cancel_Button = new System.Windows.Forms.Button();
      this.RandomRollRadio = new System.Windows.Forms.RadioButton();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.RandomRollRadio);
      this.groupBox1.Controls.Add(this.NumberBox);
      this.groupBox1.Controls.Add(this.NumberRadio);
      this.groupBox1.Controls.Add(this.MarginalRadio);
      this.groupBox1.Controls.Add(this.OrdinaryRadio);
      this.groupBox1.Controls.Add(this.GoodRadio);
      this.groupBox1.Controls.Add(this.AmazingRadio);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(114, 164);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Phase";
      // 
      // NumberBox
      // 
      this.NumberBox.Location = new System.Drawing.Point(52, 115);
      this.NumberBox.MaxLength = 2;
      this.NumberBox.Name = "NumberBox";
      this.NumberBox.Size = new System.Drawing.Size(31, 20);
      this.NumberBox.TabIndex = 5;
      this.NumberBox.TextChanged += new System.EventHandler(this.NumberBox_TextChanged);
      this.NumberBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NumberBox_KeyDown);
      // 
      // NumberRadio
      // 
      this.NumberRadio.AutoSize = true;
      this.NumberRadio.Location = new System.Drawing.Point(6, 115);
      this.NumberRadio.Name = "NumberRadio";
      this.NumberRadio.Size = new System.Drawing.Size(46, 17);
      this.NumberRadio.TabIndex = 4;
      this.NumberRadio.Text = "Roll:";
      this.toolTip1.SetToolTip(this.NumberRadio, "Select common roll for each NPC");
      this.NumberRadio.UseVisualStyleBackColor = true;
      // 
      // MarginalRadio
      // 
      this.MarginalRadio.AutoSize = true;
      this.MarginalRadio.Location = new System.Drawing.Point(6, 92);
      this.MarginalRadio.Name = "MarginalRadio";
      this.MarginalRadio.Size = new System.Drawing.Size(65, 17);
      this.MarginalRadio.TabIndex = 3;
      this.MarginalRadio.Text = "Marginal";
      this.toolTip1.SetToolTip(this.MarginalRadio, "Set all NPCs to Marginal");
      this.MarginalRadio.UseVisualStyleBackColor = true;
      // 
      // OrdinaryRadio
      // 
      this.OrdinaryRadio.AutoSize = true;
      this.OrdinaryRadio.Location = new System.Drawing.Point(6, 69);
      this.OrdinaryRadio.Name = "OrdinaryRadio";
      this.OrdinaryRadio.Size = new System.Drawing.Size(64, 17);
      this.OrdinaryRadio.TabIndex = 2;
      this.OrdinaryRadio.Text = "Ordinary";
      this.toolTip1.SetToolTip(this.OrdinaryRadio, "Set all NPCs to Ordinary");
      this.OrdinaryRadio.UseVisualStyleBackColor = true;
      // 
      // GoodRadio
      // 
      this.GoodRadio.AutoSize = true;
      this.GoodRadio.Location = new System.Drawing.Point(6, 46);
      this.GoodRadio.Name = "GoodRadio";
      this.GoodRadio.Size = new System.Drawing.Size(51, 17);
      this.GoodRadio.TabIndex = 1;
      this.GoodRadio.Text = "Good";
      this.toolTip1.SetToolTip(this.GoodRadio, "Set all NPCs to Good");
      this.GoodRadio.UseVisualStyleBackColor = true;
      // 
      // AmazingRadio
      // 
      this.AmazingRadio.AutoSize = true;
      this.AmazingRadio.Checked = true;
      this.AmazingRadio.Location = new System.Drawing.Point(6, 23);
      this.AmazingRadio.Name = "AmazingRadio";
      this.AmazingRadio.Size = new System.Drawing.Size(65, 17);
      this.AmazingRadio.TabIndex = 0;
      this.AmazingRadio.TabStop = true;
      this.AmazingRadio.Text = "Amazing";
      this.toolTip1.SetToolTip(this.AmazingRadio, "Set all NPCs to Amazing");
      this.AmazingRadio.UseVisualStyleBackColor = true;
      // 
      // OKButton
      // 
      this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OKButton.Location = new System.Drawing.Point(12, 185);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(53, 23);
      this.OKButton.TabIndex = 1;
      this.OKButton.Text = "OK";
      this.OKButton.UseVisualStyleBackColor = true;
      this.OKButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // Cancel_Button
      // 
      this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.Cancel_Button.Location = new System.Drawing.Point(73, 185);
      this.Cancel_Button.Name = "Cancel_Button";
      this.Cancel_Button.Size = new System.Drawing.Size(53, 23);
      this.Cancel_Button.TabIndex = 2;
      this.Cancel_Button.Text = "Cancel";
      this.Cancel_Button.UseVisualStyleBackColor = true;
      // 
      // RandomRollRadio
      // 
      this.RandomRollRadio.AutoSize = true;
      this.RandomRollRadio.Location = new System.Drawing.Point(6, 138);
      this.RandomRollRadio.Name = "RandomRollRadio";
      this.RandomRollRadio.Size = new System.Drawing.Size(65, 17);
      this.RandomRollRadio.TabIndex = 6;
      this.RandomRollRadio.Text = "Random";
      this.toolTip1.SetToolTip(this.RandomRollRadio, "Roll each NPC individually");
      this.RandomRollRadio.UseVisualStyleBackColor = true;
      // 
      // ActionPhases
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(138, 216);
      this.Controls.Add(this.Cancel_Button);
      this.Controls.Add(this.OKButton);
      this.Controls.Add(this.groupBox1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ActionPhases";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Set Action Phase";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ActionPhases_KeyDown);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton MarginalRadio;
    private System.Windows.Forms.RadioButton OrdinaryRadio;
    private System.Windows.Forms.RadioButton GoodRadio;
    private System.Windows.Forms.RadioButton AmazingRadio;
    private System.Windows.Forms.Button OKButton;
    private System.Windows.Forms.Button Cancel_Button;
    private System.Windows.Forms.TextBox NumberBox;
    private System.Windows.Forms.RadioButton NumberRadio;
    private System.Windows.Forms.RadioButton RandomRollRadio;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}