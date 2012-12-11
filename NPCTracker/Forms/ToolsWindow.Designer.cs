/*
 * Alternity RPG NPC Tracker/Helper
 * By Andrew Barber.
 * 
 * Licensed: CC BY-NC 3.0
 * http://creativecommons.org/licenses/by-nc/3.0/
 * 
 * More info at my blog: http://www.andrewbarber.com/post.aspx?id=e9252c9b-8ee0-4faa-b144-9f516dfd457a
 */
namespace Alternity {
  partial class ToolsWindow {
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
      this.ToolList = new System.Windows.Forms.ListBox();
      this.AddButton = new System.Windows.Forms.Button();
      this.DeleteButton = new System.Windows.Forms.Button();
      this.SaveButton = new System.Windows.Forms.Button();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.EditButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // ToolList
      // 
      this.ToolList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ToolList.FormattingEnabled = true;
      this.ToolList.Location = new System.Drawing.Point(0, 0);
      this.ToolList.Name = "ToolList";
      this.ToolList.Size = new System.Drawing.Size(197, 238);
      this.ToolList.TabIndex = 0;
      this.ToolList.DoubleClick += new System.EventHandler(this.ToolList_DoubleClick);
      // 
      // AddButton
      // 
      this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.AddButton.Location = new System.Drawing.Point(4, 251);
      this.AddButton.Name = "AddButton";
      this.AddButton.Size = new System.Drawing.Size(44, 23);
      this.AddButton.TabIndex = 1;
      this.AddButton.Text = "Add";
      this.AddButton.UseVisualStyleBackColor = true;
      this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
      // 
      // DeleteButton
      // 
      this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.DeleteButton.Location = new System.Drawing.Point(139, 251);
      this.DeleteButton.Name = "DeleteButton";
      this.DeleteButton.Size = new System.Drawing.Size(55, 23);
      this.DeleteButton.TabIndex = 4;
      this.DeleteButton.Text = "Delete";
      this.DeleteButton.UseVisualStyleBackColor = true;
      this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
      // 
      // SaveButton
      // 
      this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.SaveButton.AutoSize = true;
      this.SaveButton.FlatAppearance.BorderSize = 0;
      this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.SaveButton.Image = global::Alternity.Properties.Resources.Up;
      this.SaveButton.Location = new System.Drawing.Point(50, 251);
      this.SaveButton.Name = "SaveButton";
      this.SaveButton.Size = new System.Drawing.Size(22, 22);
      this.SaveButton.TabIndex = 2;
      this.toolTip1.SetToolTip(this.SaveButton, "Move item Up");
      this.SaveButton.UseVisualStyleBackColor = true;
      this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
      // 
      // EditButton
      // 
      this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.EditButton.Location = new System.Drawing.Point(78, 251);
      this.EditButton.Name = "EditButton";
      this.EditButton.Size = new System.Drawing.Size(55, 23);
      this.EditButton.TabIndex = 3;
      this.EditButton.Text = "Edit";
      this.EditButton.UseVisualStyleBackColor = true;
      this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
      // 
      // ToolsWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(197, 286);
      this.Controls.Add(this.EditButton);
      this.Controls.Add(this.SaveButton);
      this.Controls.Add(this.DeleteButton);
      this.Controls.Add(this.AddButton);
      this.Controls.Add(this.ToolList);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ToolsWindow";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Edit Tools";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ToolsWindow_KeyUp);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListBox ToolList;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Button DeleteButton;
    private System.Windows.Forms.Button SaveButton;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Button EditButton;
  }
}