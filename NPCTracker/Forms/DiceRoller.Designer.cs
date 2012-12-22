/*
 * Alternity RPG NPC Tracker/Helper
 * By Andrew Barber.
 * 
 * Licensed: CC BY-NC 3.0
 * http://creativecommons.org/licenses/by-nc/3.0/
 * 
 * More info at the Github repo:  https://github.com/majorcomet/alternityhelper/wiki
 */
namespace Alternity {
  partial class DiceRoller {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiceRoller));
      this.D4Check = new System.Windows.Forms.CheckBox();
      this.D6Check = new System.Windows.Forms.CheckBox();
      this.D12Check = new System.Windows.Forms.CheckBox();
      this.D8Check = new System.Windows.Forms.CheckBox();
      this.D20aCheck = new System.Windows.Forms.CheckBox();
      this.D20bCheck = new System.Windows.Forms.CheckBox();
      this.D20cCheck = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.BaseBox = new System.Windows.Forms.TextBox();
      this.D4Box = new System.Windows.Forms.TextBox();
      this.D6Box = new System.Windows.Forms.TextBox();
      this.D8Box = new System.Windows.Forms.TextBox();
      this.D20bBox = new System.Windows.Forms.TextBox();
      this.D20aBox = new System.Windows.Forms.TextBox();
      this.D12Box = new System.Windows.Forms.TextBox();
      this.D20cBox = new System.Windows.Forms.TextBox();
      this.RollButton = new System.Windows.Forms.Button();
      this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.TotalBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
      this.SuspendLayout();
      // 
      // D4Check
      // 
      this.D4Check.AutoSize = true;
      this.D4Check.Location = new System.Drawing.Point(15, 56);
      this.D4Check.Name = "D4Check";
      this.D4Check.Size = new System.Drawing.Size(40, 17);
      this.D4Check.TabIndex = 4;
      this.D4Check.Text = "D4";
      this.toolTip1.SetToolTip(this.D4Check, "Control-A to select all die boxes");
      this.D4Check.UseVisualStyleBackColor = true;
      this.D4Check.CheckedChanged += new System.EventHandler(this.DieCheck_Changed);
      // 
      // D6Check
      // 
      this.D6Check.AutoSize = true;
      this.D6Check.Location = new System.Drawing.Point(15, 79);
      this.D6Check.Name = "D6Check";
      this.D6Check.Size = new System.Drawing.Size(40, 17);
      this.D6Check.TabIndex = 6;
      this.D6Check.Text = "D6";
      this.toolTip1.SetToolTip(this.D6Check, "Control-A to select all die boxes");
      this.D6Check.UseVisualStyleBackColor = true;
      this.D6Check.CheckedChanged += new System.EventHandler(this.DieCheck_Changed);
      // 
      // D12Check
      // 
      this.D12Check.AutoSize = true;
      this.D12Check.Location = new System.Drawing.Point(15, 125);
      this.D12Check.Name = "D12Check";
      this.D12Check.Size = new System.Drawing.Size(46, 17);
      this.D12Check.TabIndex = 10;
      this.D12Check.Text = "D12";
      this.toolTip1.SetToolTip(this.D12Check, "Control-A to select all die boxes");
      this.D12Check.UseVisualStyleBackColor = true;
      this.D12Check.CheckedChanged += new System.EventHandler(this.DieCheck_Changed);
      // 
      // D8Check
      // 
      this.D8Check.AutoSize = true;
      this.D8Check.Location = new System.Drawing.Point(15, 102);
      this.D8Check.Name = "D8Check";
      this.D8Check.Size = new System.Drawing.Size(40, 17);
      this.D8Check.TabIndex = 8;
      this.D8Check.Text = "D8";
      this.toolTip1.SetToolTip(this.D8Check, "Control-A to select all die boxes");
      this.D8Check.UseVisualStyleBackColor = true;
      this.D8Check.CheckedChanged += new System.EventHandler(this.DieCheck_Changed);
      // 
      // D20aCheck
      // 
      this.D20aCheck.AutoSize = true;
      this.D20aCheck.Location = new System.Drawing.Point(15, 148);
      this.D20aCheck.Name = "D20aCheck";
      this.D20aCheck.Size = new System.Drawing.Size(46, 17);
      this.D20aCheck.TabIndex = 12;
      this.D20aCheck.Text = "D20";
      this.toolTip1.SetToolTip(this.D20aCheck, "Control-A to select all die boxes");
      this.D20aCheck.UseVisualStyleBackColor = true;
      this.D20aCheck.CheckedChanged += new System.EventHandler(this.DieCheck_Changed);
      // 
      // D20bCheck
      // 
      this.D20bCheck.AutoSize = true;
      this.D20bCheck.Location = new System.Drawing.Point(15, 171);
      this.D20bCheck.Name = "D20bCheck";
      this.D20bCheck.Size = new System.Drawing.Size(46, 17);
      this.D20bCheck.TabIndex = 14;
      this.D20bCheck.Text = "D20";
      this.toolTip1.SetToolTip(this.D20bCheck, "Control-A to select all die boxes");
      this.D20bCheck.UseVisualStyleBackColor = true;
      this.D20bCheck.CheckedChanged += new System.EventHandler(this.DieCheck_Changed);
      // 
      // D20cCheck
      // 
      this.D20cCheck.AutoSize = true;
      this.D20cCheck.Location = new System.Drawing.Point(15, 194);
      this.D20cCheck.Name = "D20cCheck";
      this.D20cCheck.Size = new System.Drawing.Size(46, 17);
      this.D20cCheck.TabIndex = 16;
      this.D20cCheck.Text = "D20";
      this.toolTip1.SetToolTip(this.D20cCheck, "Control-A to select all die boxes");
      this.D20cCheck.UseVisualStyleBackColor = true;
      this.D20cCheck.CheckedChanged += new System.EventHandler(this.DieCheck_Changed);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Base D20";
      this.toolTip1.SetToolTip(this.label1, "Control-A to select all die boxes");
      // 
      // BaseBox
      // 
      this.BaseBox.Location = new System.Drawing.Point(67, 33);
      this.BaseBox.Name = "BaseBox";
      this.BaseBox.ReadOnly = true;
      this.BaseBox.Size = new System.Drawing.Size(27, 20);
      this.BaseBox.TabIndex = 3;
      this.BaseBox.TabStop = false;
      // 
      // D4Box
      // 
      this.D4Box.Location = new System.Drawing.Point(67, 54);
      this.D4Box.Name = "D4Box";
      this.D4Box.ReadOnly = true;
      this.D4Box.Size = new System.Drawing.Size(27, 20);
      this.D4Box.TabIndex = 5;
      this.D4Box.TabStop = false;
      // 
      // D6Box
      // 
      this.D6Box.Location = new System.Drawing.Point(67, 77);
      this.D6Box.Name = "D6Box";
      this.D6Box.ReadOnly = true;
      this.D6Box.Size = new System.Drawing.Size(27, 20);
      this.D6Box.TabIndex = 7;
      this.D6Box.TabStop = false;
      // 
      // D8Box
      // 
      this.D8Box.Location = new System.Drawing.Point(67, 100);
      this.D8Box.Name = "D8Box";
      this.D8Box.ReadOnly = true;
      this.D8Box.Size = new System.Drawing.Size(27, 20);
      this.D8Box.TabIndex = 9;
      this.D8Box.TabStop = false;
      // 
      // D20bBox
      // 
      this.D20bBox.Location = new System.Drawing.Point(67, 169);
      this.D20bBox.Name = "D20bBox";
      this.D20bBox.ReadOnly = true;
      this.D20bBox.Size = new System.Drawing.Size(27, 20);
      this.D20bBox.TabIndex = 15;
      this.D20bBox.TabStop = false;
      // 
      // D20aBox
      // 
      this.D20aBox.Location = new System.Drawing.Point(67, 146);
      this.D20aBox.Name = "D20aBox";
      this.D20aBox.ReadOnly = true;
      this.D20aBox.Size = new System.Drawing.Size(27, 20);
      this.D20aBox.TabIndex = 13;
      this.D20aBox.TabStop = false;
      // 
      // D12Box
      // 
      this.D12Box.Location = new System.Drawing.Point(67, 123);
      this.D12Box.Name = "D12Box";
      this.D12Box.ReadOnly = true;
      this.D12Box.Size = new System.Drawing.Size(27, 20);
      this.D12Box.TabIndex = 11;
      this.D12Box.TabStop = false;
      // 
      // D20cBox
      // 
      this.D20cBox.Location = new System.Drawing.Point(67, 192);
      this.D20cBox.Name = "D20cBox";
      this.D20cBox.ReadOnly = true;
      this.D20cBox.Size = new System.Drawing.Size(27, 20);
      this.D20cBox.TabIndex = 17;
      this.D20cBox.TabStop = false;
      // 
      // RollButton
      // 
      this.RollButton.Location = new System.Drawing.Point(15, 244);
      this.RollButton.Name = "RollButton";
      this.RollButton.Size = new System.Drawing.Size(82, 23);
      this.RollButton.TabIndex = 20;
      this.RollButton.Text = "Roll";
      this.RollButton.UseVisualStyleBackColor = true;
      this.RollButton.Click += new System.EventHandler(this.RollButton_Click);
      // 
      // numericUpDown1
      // 
      this.numericUpDown1.InterceptArrowKeys = false;
      this.numericUpDown1.Location = new System.Drawing.Point(58, 7);
      this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
      this.numericUpDown1.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            -2147483648});
      this.numericUpDown1.Name = "numericUpDown1";
      this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
      this.numericUpDown1.TabIndex = 1;
      this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(23, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Diff";
      // 
      // TotalBox
      // 
      this.TotalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TotalBox.Location = new System.Drawing.Point(67, 218);
      this.TotalBox.Name = "TotalBox";
      this.TotalBox.ReadOnly = true;
      this.TotalBox.Size = new System.Drawing.Size(27, 20);
      this.TotalBox.TabIndex = 19;
      this.TotalBox.TabStop = false;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(27, 221);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 13);
      this.label3.TabIndex = 18;
      this.label3.Text = "Total:";
      // 
      // DiceRoller
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(108, 273);
      this.Controls.Add(this.TotalBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.numericUpDown1);
      this.Controls.Add(this.RollButton);
      this.Controls.Add(this.D20cBox);
      this.Controls.Add(this.D20bBox);
      this.Controls.Add(this.D20aBox);
      this.Controls.Add(this.D12Box);
      this.Controls.Add(this.D8Box);
      this.Controls.Add(this.D6Box);
      this.Controls.Add(this.D4Box);
      this.Controls.Add(this.BaseBox);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.D20cCheck);
      this.Controls.Add(this.D20bCheck);
      this.Controls.Add(this.D20aCheck);
      this.Controls.Add(this.D8Check);
      this.Controls.Add(this.D12Check);
      this.Controls.Add(this.D6Check);
      this.Controls.Add(this.D4Check);
      this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Alternity.Properties.Settings.Default, "RollerLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.Location = global::Alternity.Properties.Settings.Default.RollerLocation;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DiceRoller";
      this.Text = "Dice Roller";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiceRoller_KeyUp);
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.CheckBox D4Check;
    private System.Windows.Forms.CheckBox D6Check;
    private System.Windows.Forms.CheckBox D12Check;
    private System.Windows.Forms.CheckBox D8Check;
    private System.Windows.Forms.CheckBox D20aCheck;
    private System.Windows.Forms.CheckBox D20bCheck;
    private System.Windows.Forms.CheckBox D20cCheck;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox BaseBox;
    private System.Windows.Forms.TextBox D4Box;
    private System.Windows.Forms.TextBox D6Box;
    private System.Windows.Forms.TextBox D8Box;
    private System.Windows.Forms.TextBox D20bBox;
    private System.Windows.Forms.TextBox D20aBox;
    private System.Windows.Forms.TextBox D12Box;
    private System.Windows.Forms.TextBox D20cBox;
    private System.Windows.Forms.Button RollButton;
    private System.Windows.Forms.NumericUpDown numericUpDown1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox TotalBox;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ToolTip toolTip1;
  }
}