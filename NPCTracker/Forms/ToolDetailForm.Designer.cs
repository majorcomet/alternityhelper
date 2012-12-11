namespace Alternity {
  partial class ToolDetailForm {
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
      this.label1 = new System.Windows.Forms.Label();
      this.TitleBox = new System.Windows.Forms.TextBox();
      this.PathBox = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.ArgsBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SaveButton = new System.Windows.Forms.Button();
      this.Cancel_Button = new System.Windows.Forms.Button();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.PathButton = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(27, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Title";
      this.toolTip1.SetToolTip(this.label1, "Displayed Title");
      // 
      // TitleBox
      // 
      this.TitleBox.Location = new System.Drawing.Point(45, 6);
      this.TitleBox.Name = "TitleBox";
      this.TitleBox.Size = new System.Drawing.Size(227, 20);
      this.TitleBox.TabIndex = 1;
      this.toolTip1.SetToolTip(this.TitleBox, "Displayed Title");
      // 
      // PathBox
      // 
      this.PathBox.Location = new System.Drawing.Point(45, 32);
      this.PathBox.Name = "PathBox";
      this.PathBox.Size = new System.Drawing.Size(206, 20);
      this.PathBox.TabIndex = 3;
      this.toolTip1.SetToolTip(this.PathBox, "Path to local file or internet resource.");
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 35);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(29, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Path";
      this.toolTip1.SetToolTip(this.label2, "Path to local file/directory or internet resource.");
      // 
      // ArgsBox
      // 
      this.ArgsBox.Location = new System.Drawing.Point(45, 58);
      this.ArgsBox.Name = "ArgsBox";
      this.ArgsBox.Size = new System.Drawing.Size(227, 20);
      this.ArgsBox.TabIndex = 6;
      this.toolTip1.SetToolTip(this.ArgsBox, "Command-line arguments");
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 61);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "Args";
      this.toolTip1.SetToolTip(this.label3, "Command-line arguments");
      // 
      // SaveButton
      // 
      this.SaveButton.Location = new System.Drawing.Point(45, 84);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(75, 23);
      this.SaveButton.TabIndex = 7;
      this.SaveButton.Text = "Save";
      this.SaveButton.UseVisualStyleBackColor = true;
      this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // Cancel_Button
      // 
      this.Cancel_Button.Location = new System.Drawing.Point(197, 84);
      this.Cancel_Button.Name = "Cancel_Button";
      this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
      this.Cancel_Button.TabIndex = 8;
      this.Cancel_Button.Text = "Cancel";
      this.Cancel_Button.UseVisualStyleBackColor = true;
      this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.AddExtension = false;
      this.openFileDialog1.DereferenceLinks = false;
      this.openFileDialog1.Filter = "All Files|*.*";
      this.openFileDialog1.RestoreDirectory = true;
      this.openFileDialog1.Title = "Choose File/Program to Open";
      // 
      // PathButton
      // 
      this.PathButton.AutoSize = true;
      this.PathButton.FlatAppearance.BorderSize = 0;
      this.PathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.PathButton.Image = global::Alternity.Properties.Resources.Folder;
      this.PathButton.Location = new System.Drawing.Point(250, 30);
      this.PathButton.Name = "PathButton";
      this.PathButton.Size = new System.Drawing.Size(22, 22);
      this.PathButton.TabIndex = 4;
      this.toolTip1.SetToolTip(this.PathButton, "Browse for file");
      this.PathButton.UseVisualStyleBackColor = true;
      this.PathButton.Click += new System.EventHandler(this.PathButton_Click);
      // 
      // ToolDetailForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 116);
      this.Controls.Add(this.PathButton);
      this.Controls.Add(this.Cancel_Button);
      this.Controls.Add(this.SaveButton);
      this.Controls.Add(this.ArgsBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.PathBox);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.TitleBox);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ToolDetailForm";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Add Tool Item";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolDetailForm_KeyUp);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TitleBox;
    private System.Windows.Forms.TextBox PathBox;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox ArgsBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.Button Cancel_Button;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button PathButton;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}