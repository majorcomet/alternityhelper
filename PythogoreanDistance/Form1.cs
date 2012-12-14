using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PythogoreanDistance {
  public partial class Form1 : Form {
    private Regex NotNumbersOnly = new Regex("[^-.0-9]");

    private Regex NumbersOnly = new Regex("^[-.0-9]*$");

    public Form1() {
      InitializeComponent();
    }
    private void CalculateButton_Click(object sender, EventArgs e) {
      FixNumbersOnly(X1Box);
      FixNumbersOnly(Y1Box);
      FixNumbersOnly(X2Box);
      FixNumbersOnly(Y2Box);
      double x1 = double.Parse(X1Box.Text);
      double y1 = double.Parse(Y1Box.Text);
      double x2 = double.Parse(X2Box.Text);
      double y2 = double.Parse(Y2Box.Text);
      double result = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);
      result = Math.Sqrt(result);
      DistanceBox.Text = result.ToString("0.0#");
    }

    private void FixNumbersOnly(TextBox box) {
      string ret = NotNumbersOnly.Replace(box.Text, "");
      if (ret.Length == 0) ret = "0.0";
      box.Text = ret;
      box.SelectAll();
    }

    private void FocusSelect(TextBox box) {
      box.Focus();
      box.SelectAll();
    }

    private void Form1_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        CalculateButton_Click(CalculateButton, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.Escape) {
        this.Close();
      }
    }

    private bool HasValidValue(TextBox box) {
      if (!NumbersOnly.IsMatch(box.Text)) {
        return false;
      }
      return true;
    }

    private void InputBox_Changed(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (box != null) {
        if (!HasValidValue(box)) {
          MessageBox.Show("Numeric values only, please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
          FixNumbersOnly(box);
          return;
        }
      }
    }
    private void X1Box_Enter(object sender, EventArgs e) {
      TextBox box = sender as TextBox;
      if (box != null) {
        box.SelectAll();
      }
    }
    private void X1Box_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) {
        FocusSelect(X2Box);
        e.Handled = true;
      } else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left) {
        FocusSelect(Y1Box);
        e.Handled = true;
      }
    }
    private void Y1Box_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) {
        FocusSelect(Y2Box);
        e.Handled = true;
      } else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left) {
        FocusSelect(X1Box);
        e.Handled = true;
      }
    }

    private void Y2Box_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) {
        FocusSelect(Y1Box);
        e.Handled = true;
      } else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left) {
        FocusSelect(X2Box);
        e.Handled = true;
      }
    }

    private void X2Box_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down) {
        FocusSelect(X1Box);
        e.Handled = true;
      } else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.Left) {
        FocusSelect(Y2Box);
        e.Handled = true;
      }
    }

  }
}
