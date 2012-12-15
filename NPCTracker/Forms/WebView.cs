/*
 * Alternity RPG NPC Tracker/Helper
 * By Andrew Barber.
 * 
 * Licensed: CC BY-NC 3.0
 * http://creativecommons.org/licenses/by-nc/3.0/
 * 
 * More info at the Github repo:  https://github.com/majorcomet/alternityhelper/wiki
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alternity {
  public partial class WebView : Form {
    public WebView() {
      InitializeComponent();
      this.Load += WebView_Load;
    }

    void WebView_Load(object sender, EventArgs e) {
      Browser.Navigate(Url);
    }
    public string Url { get; set; }
    public WebView(string url, string title)
      : this() {
        Url = url;
        this.Text = title;
    }
  }
}
