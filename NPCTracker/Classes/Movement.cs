using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Alternity {
  public class Movement {
    public int Sprint { get; set; }
    public int Run { get; set; }
    public int Walk { get; set; }
    public int EasySwim { get; set; }
    public int Swim { get; set; }
    public int Glide { get; set; }
    public int Fly { get; set; }

    public void SetGeneratedValues(int sprint, int run, int walk) {
      Sprint = Glide = sprint;
      Run = run;
      Walk = Swim = walk;
      Fly = Glide * 2;
      EasySwim = Swim / 2;
    }

    public bool AllZero {
      get {
        return (Sprint + Run + Walk + EasySwim + Swim + Glide + Fly) == 0;
      }
    }
  }
}
