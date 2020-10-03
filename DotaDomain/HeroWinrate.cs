using System;
using System.Collections.Generic;
using System.Text;

namespace DotaDomain
{
    public class HeroWinrate
    {
        public int HeroId { get; set; }
        public int HeroVersusId { get; set; }
        public int Win { get; set; }
        public int AmountOfGames { get; set; }

        public void AddWin()
        {
            Win++;
            AddGame();
        }
        public void AddGame()
        {
            AmountOfGames++;
        }

        public bool Equals(HeroWinrate obj)
        {
            return obj.HeroId == this.HeroId &&
                   obj.HeroVersusId == this.HeroVersusId;
        }
    }
}
