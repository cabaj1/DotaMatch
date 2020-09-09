using System;
using System.Collections.Generic;

namespace DotaDomain
{
    public class Match
    {       
        //expand later
        public int Match_id { get; set; }
        public int Match_seq_num { get; set; }
        public bool Radiant_win { get; set; }
        public int Duration { get; set; } //in sec
        public int Tower_status_radiant { get; set; }
        public int Tower_status_dire { get; set; }
        public int Barracks_status_radiant { get; set; }
        public int Barrack_status_dire { get; set; }
        public int Cluster { get; set; } //?
        public int First_blood_time  { get; set; }
        public int Lobby_type { get; set; }
        public int Human_players { get; set; }
        public int Leagueid { get; set; }
        public int Positive_votes { get; set; }
        public int Negative_votes { get; set; }
        public int Game_mode { get; set; }
        public int Engine { get; set; }
        public int Parse_status { get; set; }
        public int[] Radiant_gold_adv { get; set; }
        public int[] Radiant_xp_adv { get; set; }
        public int Version { get; set; }
        public int Skill { get; set; }


        //complex stuff
        public IEnumerable<PickBan> Picks_bans { get; set; }
        public IEnumerable<Chat> Chat { get; set; }
        public IEnumerable<Teamfight> Teamfights { get; set; }
        public IEnumerable<Player> Players { get; set; }





        //https://github.com/odota/core/wiki/JSON-Data-Dump


        public override string ToString()
        {
            return Match_id + " - " + Match_seq_num + " - " + Radiant_win;
        }
    }
}
