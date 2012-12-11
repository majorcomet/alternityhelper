using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Alternity {
  class Program {
    static void Main(string[] args) {
      string root = SaveLocation.Location;
      foreach (var item in Directory.GetFiles(root, "*.alch", SearchOption.AllDirectories)) {
        Convert(item);
        Console.WriteLine(item);
      }

      Process.Start(root);
    }

    static void Convert(string source) {
      try {
        string dest = Path.ChangeExtension(source, ".xml");
        BinaryFormatter bfor = new BinaryFormatter();
        NPC npc = null;
        using (FileStream fs = new FileStream(source, FileMode.Open, FileAccess.Read, FileShare.None)) {
          npc = (NPC)bfor.Deserialize(fs);
        }
        SoapFormatter sfor = new SoapFormatter();
        using (FileStream fs = new FileStream(dest, FileMode.Create, FileAccess.Write, FileShare.None)) {
          sfor.Serialize(fs, npc);
        }
      } catch (Exception ex) {
        Console.WriteLine(ex.Message);
      }
    }
  }
}
