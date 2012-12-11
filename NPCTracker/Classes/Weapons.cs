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
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternity {
  public class Weapon {
    public string Name { get; set; }
    public string Data { get; set; }
    public Weapon() {
      //do nothing
    }
    public Weapon(string input):this() {
      if (string.IsNullOrWhiteSpace(input)) return;
      string[] tokens = input.Split("|".ToCharArray(), 2);
      if (tokens.Length != 2) return;
      this.Name = tokens[0].Trim();
      this.Data = tokens[1].Trim();
    }
    public override string ToString() {
      return Name;
    }
  }
  public static class Weapons {
    public static List<Weapon> Items;
    static Weapons() {
      ReloadWeapons();
    }
    public static void ReloadWeapons() {
      Items = new List<Weapon>();
      string WeaponFileName = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Weapons.txt");
      try {
        using (StreamReader rd = new StreamReader(WeaponFileName)) {
          string line = rd.ReadLine();
          while (line != null) {
            Items.Add(new Weapon(line));
            line = rd.ReadLine();
          }
        }
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

  }
}
