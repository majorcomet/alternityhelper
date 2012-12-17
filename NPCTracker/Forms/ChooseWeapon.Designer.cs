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
  partial class ChooseWeapon {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChooseWeapon));
      this.WeaponList = new System.Windows.Forms.ListBox();
      this.OKButton = new System.Windows.Forms.Button();
      this.CancelButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // WeaponList
      // 
      this.WeaponList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.WeaponList.FormattingEnabled = true;
      this.WeaponList.Location = new System.Drawing.Point(0, 0);
      this.WeaponList.Name = "WeaponList";
      this.WeaponList.Size = new System.Drawing.Size(298, 511);
      this.WeaponList.TabIndex = 1;
      this.WeaponList.SelectedIndexChanged += new System.EventHandler(this.WeaponList_SelectedIndexChanged);
      this.WeaponList.DoubleClick += new System.EventHandler(this.WeaponList_DoubleClick);
      // 
      // OKButton
      // 
      this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.OKButton.Location = new System.Drawing.Point(12, 529);
      this.OKButton.Name = "OKButton";
      this.OKButton.Size = new System.Drawing.Size(75, 23);
      this.OKButton.TabIndex = 2;
      this.OKButton.Text = "OK";
      this.OKButton.UseVisualStyleBackColor = true;
      // 
      // CancelButton
      // 
      this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelButton.Location = new System.Drawing.Point(211, 528);
      this.CancelButton.Name = "CancelButton";
      this.CancelButton.Size = new System.Drawing.Size(75, 23);
      this.CancelButton.TabIndex = 3;
      this.CancelButton.Text = "Cancel";
      this.CancelButton.UseVisualStyleBackColor = true;
      // 
      // ChooseWeapon
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(298, 560);
      this.Controls.Add(this.CancelButton);
      this.Controls.Add(this.OKButton);
      this.Controls.Add(this.WeaponList);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MinimumSize = new System.Drawing.Size(217, 260);
      this.Name = "ChooseWeapon";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Choose Weapon";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ChooseWeapon_KeyUp);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ListBox WeaponList;
    private System.Windows.Forms.Button OKButton;
    private System.Windows.Forms.Button CancelButton;
  }
}