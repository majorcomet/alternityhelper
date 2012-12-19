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
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Alternity.Forms {
  public partial class VoidCorpIDGenForm : Form {
    Random random = new Random();
    private static readonly string[] Letters = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
    public VoidCorpIDGenForm() {
      InitializeComponent();
    }
    private Regex AlphaOnly = new Regex("^[a-zA-Z]{0,2}$");
    private void GenerateButton_Click(object sender, EventArgs e) {
      string rank = RankBox.Text.Trim();
      if (!AlphaOnly.IsMatch(rank)) {
        MessageBox.Show("Rank must be 0-2 letters, only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      rank = rank.ToUpper();
      if (rank.Length == 0) {
        rank += RandomCharacter() + RandomCharacter();
      } else if (rank.Length == 1) {
        rank += RandomCharacter();
      }
      rank += (random.Next(0, 10).ToString() + random.Next(0, 10).ToString() + random.Next(0, 10).ToString() + " ");
      rank += (random.Next(0, 10).ToString() + random.Next(0, 10).ToString());
      rank += (RandomCharacter() + RandomCharacter() + RandomCharacter());
      ResultBox.Text = rank;
    }
    private string RandomCharacter() {
      return Letters[random.Next(0, Letters.Length)];
    }
    private void VoidCorpIDGenForm_KeyDown(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        GenerateButton_Click(GenerateButton, null);
        e.Handled = true;
      } else if (e.KeyCode == Keys.Escape) {
        this.Close();
        e.Handled = true;
      }
    }
  }
}
