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
  partial class Container {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.diceRollerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.setAllActionPhasesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
      this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.renameWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.stackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.phaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.phaseToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.MdiWindowListItem = this.windowToolStripMenuItem;
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(799, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripMenuItem4,
            this.helpToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.newToolStripMenuItem.Text = "&New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.openToolStripMenuItem.Text = "&Open...";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 6);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.helpToolStripMenuItem.Text = "&Help";
      this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diceRollerToolStripMenuItem1,
            this.setAllActionPhasesToolStripMenuItem1,
            this.toolStripMenuItem6,
            this.editToolStripMenuItem,
            this.toolStripMenuItem5});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
      this.toolsToolStripMenuItem.Text = "&Tools";
      // 
      // diceRollerToolStripMenuItem1
      // 
      this.diceRollerToolStripMenuItem1.Name = "diceRollerToolStripMenuItem1";
      this.diceRollerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.diceRollerToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
      this.diceRollerToolStripMenuItem1.Tag = "Keep";
      this.diceRollerToolStripMenuItem1.Text = "&Dice Roller";
      this.diceRollerToolStripMenuItem1.Click += new System.EventHandler(this.diceRollerToolStripMenuItem_Click);
      // 
      // setAllActionPhasesToolStripMenuItem1
      // 
      this.setAllActionPhasesToolStripMenuItem1.Name = "setAllActionPhasesToolStripMenuItem1";
      this.setAllActionPhasesToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.setAllActionPhasesToolStripMenuItem1.Size = new System.Drawing.Size(234, 22);
      this.setAllActionPhasesToolStripMenuItem1.Tag = "Keep";
      this.setAllActionPhasesToolStripMenuItem1.Text = "Set All Action &Phases...";
      this.setAllActionPhasesToolStripMenuItem1.Click += new System.EventHandler(this.setAllActionPhasesToolStripMenuItem_Click);
      // 
      // toolStripMenuItem6
      // 
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new System.Drawing.Size(231, 6);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
      this.editToolStripMenuItem.Tag = "Keep";
      this.editToolStripMenuItem.Text = "&Edit Tools...";
      this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(231, 6);
      this.toolStripMenuItem5.Tag = "Keep";
      // 
      // windowToolStripMenuItem
      // 
      this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.renameWindowToolStripMenuItem1,
            this.toolStripMenuItem3,
            this.cascadeToolStripMenuItem,
            this.stackToolStripMenuItem,
            this.toolStripMenuItem2});
      this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
      this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
      this.windowToolStripMenuItem.Text = "&Window";
      // 
      // renameWindowToolStripMenuItem1
      // 
      this.renameWindowToolStripMenuItem1.Name = "renameWindowToolStripMenuItem1";
      this.renameWindowToolStripMenuItem1.Size = new System.Drawing.Size(173, 22);
      this.renameWindowToolStripMenuItem1.Text = "&Rename Window...";
      this.renameWindowToolStripMenuItem1.Click += new System.EventHandler(this.renameWindowToolStripMenuItem_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(170, 6);
      // 
      // cascadeToolStripMenuItem
      // 
      this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
      this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.cascadeToolStripMenuItem.Text = "&Cascade";
      this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
      // 
      // stackToolStripMenuItem
      // 
      this.stackToolStripMenuItem.Name = "stackToolStripMenuItem";
      this.stackToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
      this.stackToolStripMenuItem.Text = "&Stack";
      this.stackToolStripMenuItem.Click += new System.EventHandler(this.stackToolStripMenuItem_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(170, 6);
      // 
      // phaseToolStripMenuItem
      // 
      this.phaseToolStripMenuItem.Name = "phaseToolStripMenuItem";
      this.phaseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.phaseToolStripMenuItem.Text = "&Phase";
      this.phaseToolStripMenuItem.Click += new System.EventHandler(this.phaseToolStripMenuItem_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.DefaultExt = "xml";
      this.openFileDialog1.Filter = "Alternity Character Files|*.xml";
      this.openFileDialog1.Multiselect = true;
      this.openFileDialog1.RestoreDirectory = true;
      this.openFileDialog1.SupportMultiDottedExtensions = true;
      this.openFileDialog1.Title = "Choose Character Template to Load";
      // 
      // Container
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(799, 431);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.IsMdiContainer = true;
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "Container";
      this.Text = "Alternity Helper";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Container_FormClosing);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem stackToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem phaseToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem renameWindowToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem diceRollerToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem setAllActionPhasesToolStripMenuItem1;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
  }
}