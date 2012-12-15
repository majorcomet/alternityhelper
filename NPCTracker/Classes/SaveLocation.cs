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
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternity {
  public static class SaveLocation {
    public const string DataFileExtension = "altchr";
    private static string dataLocation;
    public static string DataLocation {
      get {
        if (string.IsNullOrWhiteSpace(dataLocation)) {
          dataLocation = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
          dataLocation = Path.Combine(dataLocation, "Inkwell\\AlternityHelper");
        }
        AssureLocation(dataLocation);
        return dataLocation;
      }
    }
    private static string location;
    public static string Location {
      get {
        if (string.IsNullOrWhiteSpace(location)) {
          location = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
          location = Path.Combine(location, "Inkwell\\AlternityHelper");
        }
        AssureLocation(location);
        return location;
      }
    }

    private static void AssureLocation(string location) {
      if (!Directory.Exists(location)) {
        Directory.CreateDirectory(location);
      }
    }
  }
}
