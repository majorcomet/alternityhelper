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
using System.IO;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternity {
  public class ToolRepository {
    private List<Tool> _tools;
    public void Wipe() {
      _tools = new List<Tool>();
    }
    public void Add(params Tool[] tools) {
      _tools.AddRange(tools);
    }
    public List<Tool> ListTools() {
      return _tools;
    }
    public string ToolsXmlFile {
      get {
        string toolFile = Path.Combine(SaveLocation.DataLocation, "Tools.xml");
        if (!File.Exists(toolFile)) {
          if (_tools.Count == 0) {
            _tools.Add(new Tool { Title = "Explorer", Args = "", Path = "explorer.exe" });
          }
          Save();
        }
        return toolFile;
      }
    }
    public ToolRepository() {
      string toolFile = Path.Combine(SaveLocation.DataLocation, "Tools.xml");
      _tools = new List<Tool>();
      if (!File.Exists(toolFile)) {
        _tools.Add(new Tool { Title = "Explorer", Args = "", Path = "explorer.exe" });
        Save();
        return;
      }
      try {
        XDocument doc = XDocument.Load(toolFile);
        XElement root = doc.Element("Tools");
        foreach (var elem in root.Elements("Tool")) {
          _tools.Add(new Tool { 
            Title = elem.Element("Title").Value,
            Path = elem.Element("Path").Value,
            Args = elem.Element("Args").Value 
          });
        }
      } catch { }
    }
    public void Save() {
      XElement root = new XElement("Tools");
      foreach (var tool in _tools) {
        root.Add(new XElement("Tool",
          new XElement("Title", tool.Title),
          new XElement("Path", tool.Path),
          new XElement("Args", tool.Args)
          ));
      }
      string toolFile = Path.Combine(SaveLocation.DataLocation, "Tools.xml");
      if (File.Exists(toolFile)) File.Delete(toolFile);
      root.Save(toolFile);
    }
  }
}
