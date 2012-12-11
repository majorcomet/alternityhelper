/*
 * Alternity RPG NPC Tracker/Helper
 * By Andrew Barber.
 * 
 * Licensed: CC BY-NC 3.0
 * http://creativecommons.org/licenses/by-nc/3.0/
 * 
 * More info at my blog: http://www.andrewbarber.com/post.aspx?id=e9252c9b-8ee0-4faa-b144-9f516dfd457a
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
  public partial class ChooseWeapon : Form {
    public ChooseWeapon() {
      InitializeComponent();
      foreach (Weapon weapon in Weapons.Items) {
        WeaponList.Items.Add(weapon);
      }
    }
    public Weapon ChosenWeapon { get; set; }

    private void WeaponList_SelectedIndexChanged(object sender, EventArgs e) {
      ChosenWeapon = WeaponList.SelectedItem as Weapon;
    }

    private void ChooseWeapon_KeyUp(object sender, KeyEventArgs e) {
      if (e.KeyCode == Keys.Enter) {
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
        e.Handled = true;
      } else if (e.KeyCode == Keys.Escape) {
        this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        e.Handled = true;
      }
    }

    private void WeaponList_DoubleClick(object sender, EventArgs e) {
      this.DialogResult = System.Windows.Forms.DialogResult.OK;
    }
  }
}
