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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternity {
  public class Tool {
    public Tool() {
      Title = Path = Args = "";
    }

    public string Title { get; set; }
    public string Path { get; set; }
    public string Args { get; set; }

    public override string ToString() {
      return Title;
    }
  }
}
