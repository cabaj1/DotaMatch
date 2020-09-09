using System;
using System.Collections.Generic;
using System.Text;

namespace DotaDomain
{
    public class Teamfight
    {
        public int Start { get; set; } //sec
        public int End { get; set; }

        public int Last_death { get; set; }
        public int Deaths { get; set; }
        public IEnumerable<TeamfightPlayer> Players { get; set; }
    }
}
