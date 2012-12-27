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
  [Serializable]
  public class NPC {
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Will { get; set; }
    public int Personality { get; set; }
    public int ActionCheck { get; set; }
    public int Actions { get; set; }
    public int StunMax { get; set; }
    public int WoundMax { get; set; }
    public int FatigueMax { get; set; }
    public int MortalMax { get; set; }
    public int StunTaken { get; set; }
    public int WoundTaken { get; set; }
    public int FatigueTaken { get; set; }
    public int MortalTaken { get; set; }
    public string Armor { get; set; }
    public string Weapons { get; set; }
    public string Other { get; set; }
    public int StrengthResistMod { get; set; }
    public int DexterityResistMod { get; set; }
    public int IntelligenceResistMod { get; set; }
    public int WillResistMod { get; set; }
    public int ActionCheckAdjustment { get; set; }
    public bool Locked { get; set; }
    public int ExtraActions { get; set; }
    public string ToolTitle { get; set; }
    public string ToolPath { get; set; }
    public string ToolArgs { get; set; }
    public int Sprint { get; set; }
    public int Run { get; set; }
    public int Walk { get; set; }
    public int EasySwim { get; set; }
    public int Swim { get; set; }
    public int Glide { get; set; }
    public int Fly { get; set; }
    public int LastResorts { get; set; }

    public NPC() {
      Name = "";
      Strength = Dexterity = Will = Intelligence = Constitution = Personality = 9;
      WoundMax = StunMax = 12;
      FatigueMax = MortalMax = 6;
      ActionCheck = 12;
      Armor =  Weapons = Other = "";
      ToolTitle = ToolPath = ToolArgs = "";
    }

    /// <summary>
    /// Calculated
    /// </summary>
    public int ActionPlus {
      get { return ActionCheck + 1; }
    }
    /// <summary>
    /// Calculated
    /// </summary>
    public int ActionGood {
      get { return ActionCheck / 2; }
    }
    /// <summary>
    /// Calculated
    /// </summary>
    public int ActionAmazing {
      get { return ActionGood / 2; }
    }
  }
}
