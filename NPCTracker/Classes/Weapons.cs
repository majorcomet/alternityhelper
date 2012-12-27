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
    private const string WeaponsTxt = "Weapons.txt";
    public static string DefaultWeaponFileName = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), WeaponsTxt);
    public static string WeaponFileName = Path.Combine(SaveLocation.DataLocation, WeaponsTxt);
    static Weapons() {
      AssureWeaponFile();
      ReloadWeapons();
    }
    private static void AssureWeaponFile() {
      if (!File.Exists(WeaponFileName)) {
        File.Copy(DefaultWeaponFileName, WeaponFileName);
      }
    }

    public static void ReloadWeapons() {
      Items = new List<Weapon>();
      try {
        using (StreamReader rd = new StreamReader(WeaponFileName)) {
          string line = rd.ReadLine();
          while (line != null) {
            if (!line.Trim().StartsWith("//") && line.Trim().Length > 0) {
              Items.Add(new Weapon(line));
            }
            line = rd.ReadLine();
          }
        }
      } catch (Exception ex) {
        MessageBox.Show(ex.Message, "Error");
      }
    }

  }
}
