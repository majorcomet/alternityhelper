namespace PythogoreanDistance {
  partial class Form1 {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.label1 = new System.Windows.Forms.Label();
      this.X1Box = new System.Windows.Forms.TextBox();
      this.Y1Box = new System.Windows.Forms.TextBox();
      this.Y2Box = new System.Windows.Forms.TextBox();
      this.X2Box = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.CalculateButton = new System.Windows.Forms.Button();
      this.DistanceBox = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(60, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Location 1:";
      // 
      // X1Box
      // 
      this.X1Box.Location = new System.Drawing.Point(75, 12);
      this.X1Box.Name = "X1Box";
      this.X1Box.Size = new System.Drawing.Size(50, 20);
      this.X1Box.TabIndex = 1;
      this.X1Box.Text = "0";
      this.X1Box.TextChanged += new System.EventHandler(this.InputBox_Changed);
      this.X1Box.Enter += new System.EventHandler(this.X1Box_Enter);
      this.X1Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.X1Box_KeyDown);
      // 
      // Y1Box
      // 
      this.Y1Box.Location = new System.Drawing.Point(128, 12);
      this.Y1Box.Name = "Y1Box";
      this.Y1Box.Size = new System.Drawing.Size(50, 20);
      this.Y1Box.TabIndex = 2;
      this.Y1Box.Text = "0";
      this.Y1Box.TextChanged += new System.EventHandler(this.InputBox_Changed);
      this.Y1Box.Enter += new System.EventHandler(this.X1Box_Enter);
      this.Y1Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Y1Box_KeyDown);
      // 
      // Y2Box
      // 
      this.Y2Box.Location = new System.Drawing.Point(128, 37);
      this.Y2Box.Name = "Y2Box";
      this.Y2Box.Size = new System.Drawing.Size(50, 20);
      this.Y2Box.TabIndex = 5;
      this.Y2Box.Text = "0";
      this.Y2Box.TextChanged += new System.EventHandler(this.InputBox_Changed);
      this.Y2Box.Enter += new System.EventHandler(this.X1Box_Enter);
      this.Y2Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Y2Box_KeyDown);
      // 
      // X2Box
      // 
      this.X2Box.Location = new System.Drawing.Point(75, 37);
      this.X2Box.Name = "X2Box";
      this.X2Box.Size = new System.Drawing.Size(50, 20);
      this.X2Box.TabIndex = 4;
      this.X2Box.Text = "0";
      this.X2Box.TextChanged += new System.EventHandler(this.InputBox_Changed);
      this.X2Box.Enter += new System.EventHandler(this.X1Box_Enter);
      this.X2Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.X2Box_KeyDown);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(12, 40);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(60, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Location 2:";
      // 
      // CalculateButton
      // 
      this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CalculateButton.Location = new System.Drawing.Point(75, 63);
      this.CalculateButton.Name = "CalculateButton";
      this.CalculateButton.Size = new System.Drawing.Size(72, 23);
      this.CalculateButton.TabIndex = 6;
      this.CalculateButton.Text = "Calculate";
      this.CalculateButton.UseVisualStyleBackColor = true;
      this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
      // 
      // DistanceBox
      // 
      this.DistanceBox.BackColor = System.Drawing.SystemColors.Window;
      this.DistanceBox.Location = new System.Drawing.Point(75, 95);
      this.DistanceBox.Name = "DistanceBox";
      this.DistanceBox.ReadOnly = true;
      this.DistanceBox.Size = new System.Drawing.Size(50, 20);
      this.DistanceBox.TabIndex = 8;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 98);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 13);
      this.label3.TabIndex = 7;
      this.label3.Text = "Distance:";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(191, 124);
      this.Controls.Add(this.DistanceBox);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.CalculateButton);
      this.Controls.Add(this.Y2Box);
      this.Controls.Add(this.X2Box);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.Y1Box);
      this.Controls.Add(this.X1Box);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Form1";
      this.Text = "Pythagorean Distance";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox X1Box;
    private System.Windows.Forms.TextBox Y1Box;
    private System.Windows.Forms.TextBox Y2Box;
    private System.Windows.Forms.TextBox X2Box;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button CalculateButton;
    private System.Windows.Forms.TextBox DistanceBox;
    private System.Windows.Forms.Label label3;
  }
}

