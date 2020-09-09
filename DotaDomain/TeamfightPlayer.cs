namespace DotaDomain
{
    public class TeamfightPlayer
    {
        //todo: death_pos, ability_uses, item_uses, killed
        public int Deaths { get; set; }
        public int Buybacks { get; set; }
        public int Damage { get; set; } 
        public int Gold_delta { get; set; }
        public int Xp_delta { get; set; }
        public int Xp_start { get; set; }
        public int Xp_end { get; set; }
    }
}