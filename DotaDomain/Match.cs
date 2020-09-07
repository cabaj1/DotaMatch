using System;

namespace DotaDomain
{
    public class Match
    {       
        //expand later
        public int Match_id { get; set; }
        public int Match_seq_num { get; set; }
        public bool Radiant_win { get; set; }

        //https://github.com/odota/core/wiki/JSON-Data-Dump


        public override string ToString()
        {
            return Match_id + " - " + Match_seq_num + " - " + Radiant_win;
        }
    }
}
