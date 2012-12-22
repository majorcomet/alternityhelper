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
  partial class MovementForm {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovementForm));
      this.label1 = new System.Windows.Forms.Label();
      this.SprintBox = new System.Windows.Forms.TextBox();
      this.RunBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.WalkBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.EasySwimBox = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.SwimBox = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.GlideBox = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.FlyBox = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.OKButton = new System.Windows.Forms.Button();
      this.Cancel_Button = new System.Windows.Forms.Button();
      this.GenerateLabel = new System.Windows.Forms.LinkLabel();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.NoFlyLabel = new System.Windows.Forms.LinkLabel();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(34, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Sprint";
      // 
      // SprintBox
      // 
      this.SprintBox.Location = new System.Drawing.Point(63, 12);
      this.SprintBox.MaxLength = 2;
      this.SprintBox.Name = "SprintBox";
      this.SprintBox.Size = new System.Drawing.Size(24, 20);
      this.SprintBox.TabIndex = 1;
      this.SprintBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBox_Keypress);
      // 
      // RunBox
      // 
      this.RunBox.Location = new System.Drawing.Point(63, 38);
      this.RunBox.MaxLength = 2;
      this.RunBox.Name = "RunBox";
      this.RunBox.Size = new System.Drawing.Size(24, 20);
      this.RunBox.TabIndex = 3;
      this.RunBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBox_Keypress);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 41);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(27, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Run";
      // 
      // WalkBox
      // 
      this.WalkBox.Location = new System.Drawing.Point(63, 64);
      this.WalkBox.MaxLength = 2;
      this.WalkBox.Name = "WalkBox";
      this.WalkBox.Size = new System.Drawing.Size(24, 20);
      this.WalkBox.TabIndex = 5;
      this.WalkBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBox_Keypress);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 67);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Walk";
      // 
      // EasySwimBox
      // 
      this.EasySwimBox.Location = new System.Drawing.Point(155, 12);
      this.EasySwimBox.MaxLength = 2;
      this.EasySwimBox.Name = "EasySwimBox";
      this.EasySwimBox.Size = new System.Drawing.Size(24, 20);
      this.EasySwimBox.TabIndex = 7;
      this.EasySwimBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBox_Keypress);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(104, 15);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(42, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "E.Swim";
      // 
      // SwimBox
      // 
      this.SwimBox.Location = new System.Drawing.Point(155, 38);
      this.SwimBox.MaxLength = 2;
      this.SwimBox.Name = "SwimBox";
      this.SwimBox.Size = new System.Drawing.Size(24, 20);
      this.SwimBox.TabIndex = 9;
      this.SwimBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBox_Keypress);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(104, 41);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(32, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Swim";
      // 
      // GlideBox
      // 
      this.GlideBox.Location = new System.Drawing.Point(155, 64);
      this.GlideBox.MaxLength = 2;
      this.GlideBox.Name = "GlideBox";
      this.GlideBox.Size = new System.Drawing.Size(24, 20);
      this.GlideBox.TabIndex = 11;
      this.GlideBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBox_Keypress);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(104, 67);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(31, 13);
      this.label6.TabIndex = 10;
      this.label6.Text = "Glide";
      // 
      // FlyBox
      // 
      this.FlyBox.Location = new System.Drawing.Point(155, 90);
      this.FlyBox.MaxLength = 2;
      this.FlyBox.Name = "FlyBox";
      this.FlyBox.Size = new System.Drawing.Size(24, 20);
      this.FlyBox.TabIndex = 13;
      this.FlyBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MoveBox_Keypress);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(104, 93);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(20, 13);
      this.label7.TabIndex = 12;
      this.label7.Text = "Fly";
      // 
      // OKButton
      // 
      this.OKButton.Location = new System.Drawing.Point(15, 126);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(75, 23);
      this.OKButton.TabIndex = 14;
      this.OKButton.Text = "OK";
      this.OKButton.UseVisualStyleBackColor = true;
      this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
      // 
      // Cancel_Button
      // 
      this.Cancel_Button.Location = new System.Drawing.Point(104, 126);
      this.Cancel_Button.Name = "Cancel_Button";
      this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
      this.Cancel_Button.TabIndex = 15;
      this.Cancel_Button.Text = "Cancel";
      this.Cancel_Button.UseVisualStyleBackColor = true;
      this.Cancel_Button.Click += new System.EventHandler(this.button3_Click);
      // 
      // GenerateLabel
      // 
      this.GenerateLabel.AutoSize = true;
      this.GenerateLabel.Location = new System.Drawing.Point(12, 97);
      this.GenerateLabel.Name = "GenerateLabel";
      this.GenerateLabel.Size = new System.Drawing.Size(60, 13);
      this.GenerateLabel.TabIndex = 16;
      this.GenerateLabel.TabStop = true;
      this.GenerateLabel.Text = "Generate...";
      this.toolTip1.SetToolTip(this.GenerateLabel, "Click to generate movement values based on stats. (Control-G)");
      this.GenerateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GenerateLabel_LinkClicked);
      // 
      // NoFlyLabel
      // 
      this.NoFlyLabel.AutoSize = true;
      this.NoFlyLabel.Location = new System.Drawing.Point(130, 93);
      this.NoFlyLabel.Name = "NoFlyLabel";
      this.NoFlyLabel.Size = new System.Drawing.Size(19, 13);
      this.NoFlyLabel.TabIndex = 17;
      this.NoFlyLabel.TabStop = true;
      this.NoFlyLabel.Text = "no";
      this.toolTip1.SetToolTip(this.NoFlyLabel, "Click to set Glide/Fly values to 0 (Control-F)");
      this.NoFlyLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoFlyLabel_LinkClicked);
      // 
      // MovementForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(194, 163);
      this.Controls.Add(this.NoFlyLabel);
      this.Controls.Add(this.GenerateLabel);
      this.Controls.Add(this.Cancel_Button);
      this.Controls.Add(this.OKButton);
      this.Controls.Add(this.FlyBox);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.GlideBox);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.SwimBox);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.EasySwimBox);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.WalkBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.RunBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.SprintBox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "MovementForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Movement";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MovementForm_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox SprintBox;
    private System.Windows.Forms.TextBox RunBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox WalkBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox EasySwimBox;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox SwimBox;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox GlideBox;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox FlyBox;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button OKButton;
    private System.Windows.Forms.Button Cancel_Button;
    private System.Windows.Forms.LinkLabel GenerateLabel;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.LinkLabel NoFlyLabel;
  }
}