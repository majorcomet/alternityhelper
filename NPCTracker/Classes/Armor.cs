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
  public class Armor {
    public string Name { get; set; }
    public string Data { get; set; }
    public Armor() {
      //do nothing
    }
    public Armor(string input):this() {
      if (string.IsNullOrWhiteSpace(input)) return;
      string[] tokens = input.Split("|".ToCharArray(), 2);
      if (tokens.Length != 2) return;
      this.Name = tokens[0].Trim();
      this.Data = tokens[1].Trim();
    }
    public override string ToString() {
      return this.Name;
    }
  }
  public static class Armors {
    public static List<Armor> Items;
    static Armors() {
      ReloadArmor();
    }
    public static void ReloadArmor() {
      Items = new List<Armor>();
      string ArmorFileName = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "Armor.txt");
      try {
        using (StreamReader rd = new StreamReader(ArmorFileName)) {
          string line = rd.ReadLine();
          while (line != null) {
            if (!line.Trim().StartsWith("//")) {
              Items.Add(new Armor(line));
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
