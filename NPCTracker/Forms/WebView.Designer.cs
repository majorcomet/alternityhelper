namespace Alternity {
  partial class WebView {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebView));
      this.Browser = new System.Windows.Forms.WebBrowser();
      this.SuspendLayout();
      // 
      // Browser
      // 
      this.Browser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Browser.Location = new System.Drawing.Point(0, 0);
      this.Browser.MinimumSize = new System.Drawing.Size(20, 20);
      this.Browser.Name = "Browser";
      this.Browser.Size = new System.Drawing.Size(570, 402);
      this.Browser.TabIndex = 0;
      // 
      // WebView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = global::Alternity.Properties.Settings.Default.ClientSize;
      this.Controls.Add(this.Browser);
      this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Alternity.Properties.Settings.Default, "MainLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.DataBindings.Add(new System.Windows.Forms.Binding("ClientSize", global::Alternity.Properties.Settings.Default, "ClientSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Location = global::Alternity.Properties.Settings.Default.MainLocation;
      this.Name = "WebView";
      this.Text = "Web View";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.WebBrowser Browser;
  }
}