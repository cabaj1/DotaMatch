namespace DotaDomain.jsonReader
{

    public class GameJson
    {
        public int match_id { get; set; }
        public int match_seq_num { get; set; }
        public bool? radiant_win { get; set; }
        public int start_time { get; set; }
        public int duration { get; set; }
        public int tower_status_radiant { get; set; }
        public int tower_status_dire { get; set; }
        public int barracks_status_radiant { get; set; }
        public int barracks_status_dire { get; set; }
        public int cluster { get; set; }
        public int first_blood_time { get; set; }
        public int lobby_type { get; set; }
        public int human_players { get; set; }
        public int leagueid { get; set; }
        public int positive_votes { get; set; }
        public int negative_votes { get; set; }
        public int game_mode { get; set; }
        public int engine { get; set; }
        public object picks_bans { get; set; }
        public int parse_status { get; set; }
        public Chat[] chat { get; set; }
        public Objective[] objectives { get; set; }
        public int[] radiant_gold_adv { get; set; }
        public int[] radiant_xp_adv { get; set; }
        public Teamfight[] teamfights { get; set; }
        public int version { get; set; }
        public Player1[] players { get; set; }
    }

    public class Chat
    {
        public int time { get; set; }
        public string type { get; set; }
        public string unit { get; set; }
        public string key { get; set; }
        public int slot { get; set; }
    }

    public class Objective
    {
        public int time { get; set; }
        public string type { get; set; }
        public int value { get; set; }
        public int player1 { get; set; }
        public int player2 { get; set; }
        public int slot { get; set; }
        public int team { get; set; }
    }

    public class Teamfight
    {
        public int start { get; set; }
        public int end { get; set; }
        public int last_death { get; set; }
        public int deaths { get; set; }
        public Player[] players { get; set; }
    }

    public class Player
    {
        //public Deaths_Pos deaths_pos { get; set; }
        //public Ability_Uses ability_uses { get; set; }
        //public Item_Uses item_uses { get; set; }
        //public Killed killed { get; set; }
        public int deaths { get; set; }
        public int buybacks { get; set; }
        public int damage { get; set; }
        public int gold_delta { get; set; }
        public int xp_delta { get; set; }
        public int xp_start { get; set; }
        public int xp_end { get; set; }
    }

    //public class Deaths_Pos
    //{
    //    public _82 _82 { get; set; }
    //    public _92 _92 { get; set; }
    //    public _84 _84 { get; set; }
    //    public _90 _90 { get; set; }
    //    public _174 _174 { get; set; }
    //    public _122 _122 { get; set; }
    //    public _126 _126 { get; set; }
    //}

    //public class _82
    //{
    //    public int _158 { get; set; }
    //}

    //public class _92
    //{
    //    public int _174 { get; set; }
    //}

    //public class _84
    //{
    //    public int _164 { get; set; }
    //}

    //public class _90
    //{
    //    public int _160 { get; set; }
    //}

    //public class _174
    //{
    //    public int _92 { get; set; }
    //}

    //public class _122
    //{
    //    public int _122 { get; set; }
    //}

    //public class _126
    //{
    //    public int _128 { get; set; }
    //}

    //public class Ability_Uses
    //{
    //    public int ember_spirit_searing_chains { get; set; }
    //    public int ember_spirit_flame_guard { get; set; }
    //    public int necrolyte_death_pulse { get; set; }
    //    public int skeleton_king_hellfire_blast { get; set; }
    //    public int vengefulspirit_wave_of_terror { get; set; }
    //    public int lion_impale { get; set; }
    //    public int lion_voodoo { get; set; }
    //    public int templar_assassin_refraction { get; set; }
    //    public int templar_assassin_psionic_trap { get; set; }
    //    public int templar_assassin_meld { get; set; }
    //    public int spectre_spectral_dagger { get; set; }
    //    public int shadow_shaman_ether_shock { get; set; }
    //    public int shadow_shaman_shackles { get; set; }
    //    public int shadow_shaman_voodoo { get; set; }
    //    public int omniknight_purification { get; set; }
    //    public int omniknight_repel { get; set; }
    //    public int ember_spirit_fire_remnant { get; set; }
    //    public int ember_spirit_activate_fire_remnant { get; set; }
    //    public int vengefulspirit_magic_missile { get; set; }
    //}

    //public class Item_Uses
    //{
    //    public int bottle { get; set; }
    //    public int magic_stick { get; set; }
    //    public int tango { get; set; }
    //    public int tpscroll { get; set; }
    //    public int smoke_of_deceit { get; set; }
    //    public int enchanted_mango { get; set; }
    //    public int phase_boots { get; set; }
    //    public int clarity { get; set; }
    //}

    //public class Killed
    //{
    //    public int npc_dota_hero_shadow_shaman { get; set; }
    //    public int npc_dota_hero_lion { get; set; }
    //    public int npc_dota_hero_spectre { get; set; }
    //    public int npc_dota_hero_necrolyte { get; set; }
    //    public int npc_dota_hero_templar_assassin { get; set; }
    //    public int npc_dota_hero_slardar { get; set; }
    //}

    public class Player1
    {
        public long? account_id { get; set; }
        public int player_slot { get; set; }
        public int hero_id { get; set; }
        public int item_0 { get; set; }
        public int item_1 { get; set; }
        public int item_2 { get; set; }
        public int item_3 { get; set; }
        public int item_4 { get; set; }
        public int item_5 { get; set; }
        public int kills { get; set; }
        public int deaths { get; set; }
        public int assists { get; set; }
        public int? leaver_status { get; set; }
        public int gold { get; set; }
        public int last_hits { get; set; }
        public int denies { get; set; }
        public int gold_per_min { get; set; }
        public int xp_per_min { get; set; }
        public int gold_spent { get; set; }
        public int hero_damage { get; set; }
        public int tower_damage { get; set; }
        public int hero_healing { get; set; }
        public int level { get; set; }
        public Ability_Upgrades[] ability_upgrades { get; set; }
        public object additional_units { get; set; }
        public float? stuns { get; set; }
        ///public Max_Hero_Hit max_hero_hit { get; set; }
        public int[] times { get; set; }
        public int[] gold_t { get; set; }
        public int[] lh_t { get; set; }
        public int[] xp_t { get; set; }
        public Obs_Log[] obs_log { get; set; }
        public Sen_Log[] sen_log { get; set; }
        public Purchase_Log[] purchase_log { get; set; }
        public Kills_Log[] kills_log { get; set; }
        public object[] buyback_log { get; set; }
        //public Lane_Pos lane_pos { get; set; }
        //public Obs obs { get; set; }
        //public Sen sen { get; set; }
        //public Actions actions { get; set; }
        public Pings pings { get; set; }
        //public Purchase purchase { get; set; }
        //public Gold_Reasons gold_reasons { get; set; }
        public Xp_Reasons xp_reasons { get; set; }
        //public Killed1 killed { get; set; }
        //public Item_Uses1 item_uses { get; set; }
        //public Ability_Uses1 ability_uses { get; set; }
        //public Hero_Hits hero_hits { get; set; }
        //public Damage damage { get; set; }
        //public Damage_Taken damage_taken { get; set; }
        //public Damage_Inflictor damage_inflictor { get; set; }
        public Runes runes { get; set; }
        //public Killed_By killed_by { get; set; }
        //public Modifier_Applied modifier_applied { get; set; }
        public Kill_Streaks kill_streaks { get; set; }
        public Multi_Kills multi_kills { get; set; }
        //public Healing healing { get; set; }
    }

    //public class Max_Hero_Hit
    //{
    //    public string type { get; set; }
    //    public int time { get; set; }
    //    public bool max { get; set; }
    //    public string unit { get; set; }
    //    public string key { get; set; }
    //    public int value { get; set; }
    //    public int slot { get; set; }
    //    public int player_slot { get; set; }
    //    public string inflictor { get; set; }
    //}

    //public class Lane_Pos
    //{
    //    public _72 _72 { get; set; }
    //    public _74 _74 { get; set; }
    //    public _76 _76 { get; set; }
    //    public _78 _78 { get; set; }
    //    public _80 _80 { get; set; }
    //    public _821 _82 { get; set; }
    //    public _841 _84 { get; set; }
    //    public _86 _86 { get; set; }
    //    public _88 _88 { get; set; }
    //    public _901 _90 { get; set; }
    //    public _921 _92 { get; set; }
    //    public _94 _94 { get; set; }
    //    public _96 _96 { get; set; }
    //    public _98 _98 { get; set; }
    //    public _100 _100 { get; set; }
    //    public _102 _102 { get; set; }
    //    public _104 _104 { get; set; }
    //    public _106 _106 { get; set; }
    //    public _108 _108 { get; set; }
    //    public _110 _110 { get; set; }
    //    public _112 _112 { get; set; }
    //    public _114 _114 { get; set; }
    //    public _116 _116 { get; set; }
    //    public _118 _118 { get; set; }
    //    public _120 _120 { get; set; }
    //    public _1221 _122 { get; set; }
    //    public _124 _124 { get; set; }
    //    public _1261 _126 { get; set; }
    //    public _128 _128 { get; set; }
    //    public _130 _130 { get; set; }
    //    public _132 _132 { get; set; }
    //    public _134 _134 { get; set; }
    //    public _136 _136 { get; set; }
    //    public _138 _138 { get; set; }
    //    public _140 _140 { get; set; }
    //    public _142 _142 { get; set; }
    //    public _144 _144 { get; set; }
    //    public _146 _146 { get; set; }
    //    public _148 _148 { get; set; }
    //    public _150 _150 { get; set; }
    //    public _68 _68 { get; set; }
    //    public _70 _70 { get; set; }
    //    public _152 _152 { get; set; }
    //    public _154 _154 { get; set; }
    //    public _156 _156 { get; set; }
    //    public _158 _158 { get; set; }
    //    public _160 _160 { get; set; }
    //    public _162 _162 { get; set; }
    //    public _164 _164 { get; set; }
    //    public _166 _166 { get; set; }
    //    public _168 _168 { get; set; }
    //    public _170 _170 { get; set; }
    //    public _172 _172 { get; set; }
    //    public _1741 _174 { get; set; }
    //    public _176 _176 { get; set; }
    //    public _178 _178 { get; set; }
    //    public _180 _180 { get; set; }
    //    public _182 _182 { get; set; }
    //    public _184 _184 { get; set; }
    //}

    //public class _72
    //{
    //    public int _74 { get; set; }
    //    public int _76 { get; set; }
    //    public int _78 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _158 { get; set; }
    //}

    //public class _74
    //{
    //    public int _72 { get; set; }
    //    public int _74 { get; set; }
    //    public int _76 { get; set; }
    //    public int _78 { get; set; }
    //    public int _80 { get; set; }
    //    public int _82 { get; set; }
    //    public int _84 { get; set; }
    //    public int _86 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _156 { get; set; }
    //}

    //public class _76
    //{
    //    public int _78 { get; set; }
    //    public int _80 { get; set; }
    //    public int _86 { get; set; }
    //    public int _146 { get; set; }
    //    public int _148 { get; set; }
    //    public int _150 { get; set; }
    //    public int _152 { get; set; }
    //    public int _154 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _82 { get; set; }
    //    public int _84 { get; set; }
    //}

    //public class _78
    //{
    //    public int _80 { get; set; }
    //    public int _88 { get; set; }
    //    public int _138 { get; set; }
    //    public int _148 { get; set; }
    //    public int _150 { get; set; }
    //    public int _152 { get; set; }
    //    public int _154 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _170 { get; set; }
    //    public int _172 { get; set; }
    //    public int _86 { get; set; }
    //    public int _90 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //    public int _140 { get; set; }
    //    public int _142 { get; set; }
    //    public int _144 { get; set; }
    //    public int _146 { get; set; }
    //}

    //public class _80
    //{
    //    public int _80 { get; set; }
    //    public int _88 { get; set; }
    //    public int _140 { get; set; }
    //    public int _142 { get; set; }
    //    public int _144 { get; set; }
    //    public int _146 { get; set; }
    //    public int _148 { get; set; }
    //    public int _150 { get; set; }
    //    public int _152 { get; set; }
    //    public int _154 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _170 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _92 { get; set; }
    //    public int _138 { get; set; }
    //    public int _78 { get; set; }
    //}

    //public class _821
    //{
    //    public int _80 { get; set; }
    //    public int _82 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _88 { get; set; }
    //    public int _140 { get; set; }
    //    public int _154 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _170 { get; set; }
    //    public int _172 { get; set; }
    //    public int _94 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //    public int _138 { get; set; }
    //    public int _146 { get; set; }
    //    public int _78 { get; set; }
    //    public int _174 { get; set; }
    //}

    //public class _841
    //{
    //    public int _80 { get; set; }
    //    public int _84 { get; set; }
    //    public int _86 { get; set; }
    //    public int _164 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _172 { get; set; }
    //    public int _88 { get; set; }
    //    public int _140 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _170 { get; set; }
    //    public int _94 { get; set; }
    //    public int _132 { get; set; }
    //    public int _162 { get; set; }
    //    public int _154 { get; set; }
    //    public int _78 { get; set; }
    //    public int _160 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //}

    //public class _86
    //{
    //    public int _80 { get; set; }
    //    public int _88 { get; set; }
    //    public int _164 { get; set; }
    //    public int _170 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _138 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _96 { get; set; }
    //    public int _130 { get; set; }
    //    public int _78 { get; set; }
    //    public int _176 { get; set; }
    //    public int _168 { get; set; }
    //}

    //public class _88
    //{
    //    public int _80 { get; set; }
    //    public int _90 { get; set; }
    //    public int _92 { get; set; }
    //    public int _162 { get; set; }
    //    public int _170 { get; set; }
    //    public int _94 { get; set; }
    //    public int _136 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _96 { get; set; }
    //    public int _130 { get; set; }
    //    public int _174 { get; set; }
    //    public int _78 { get; set; }
    //    public int _156 { get; set; }
    //    public int _172 { get; set; }
    //    public int _176 { get; set; }
    //}

    //public class _901
    //{
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _172 { get; set; }
    //    public int _96 { get; set; }
    //    public int _158 { get; set; }
    //    public int _98 { get; set; }
    //    public int _128 { get; set; }
    //    public int _136 { get; set; }
    //    public int _170 { get; set; }
    //    public int _80 { get; set; }
    //    public int _164 { get; set; }
    //    public int _78 { get; set; }
    //    public int _176 { get; set; }
    //    public int _168 { get; set; }
    //    public int _178 { get; set; }
    //}

    //public class _921
    //{
    //    public int _80 { get; set; }
    //    public int _94 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _174 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _136 { get; set; }
    //    public int _128 { get; set; }
    //    public int _78 { get; set; }
    //    public int _172 { get; set; }
    //    public int _176 { get; set; }
    //    public int _166 { get; set; }
    //    public int _170 { get; set; }
    //    public int _178 { get; set; }
    //}

    //public class _94
    //{
    //    public int _80 { get; set; }
    //    public int _96 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _178 { get; set; }
    //    public int _180 { get; set; }
    //    public int _100 { get; set; }
    //    public int _136 { get; set; }
    //    public int _158 { get; set; }
    //    public int _126 { get; set; }
    //    public int _170 { get; set; }
    //    public int _78 { get; set; }
    //    public int _182 { get; set; }
    //}

    //public class _96
    //{
    //    public int _80 { get; set; }
    //    public int _96 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _178 { get; set; }
    //    public int _102 { get; set; }
    //    public int _104 { get; set; }
    //    public int _136 { get; set; }
    //    public int _100 { get; set; }
    //    public int _124 { get; set; }
    //    public int _138 { get; set; }
    //    public int _156 { get; set; }
    //    public int _78 { get; set; }
    //    public int _170 { get; set; }
    //}

    //public class _98
    //{
    //    public int _80 { get; set; }
    //    public int _98 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _170 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _106 { get; set; }
    //    public int _136 { get; set; }
    //    public int _138 { get; set; }
    //    public int _102 { get; set; }
    //    public int _120 { get; set; }
    //    public int _122 { get; set; }
    //    public int _156 { get; set; }
    //    public int _78 { get; set; }
    //}

    //public class _100
    //{
    //    public int _80 { get; set; }
    //    public int _100 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _168 { get; set; }
    //    public int _170 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _138 { get; set; }
    //    public int _104 { get; set; }
    //    public int _118 { get; set; }
    //    public int _164 { get; set; }
    //    public int _166 { get; set; }
    //    public int _78 { get; set; }
    //    public int _178 { get; set; }
    //}

    //public class _102
    //{
    //    public int _80 { get; set; }
    //    public int _102 { get; set; }
    //    public int _156 { get; set; }
    //    public int _172 { get; set; }
    //    public int _176 { get; set; }
    //    public int _178 { get; set; }
    //    public int _116 { get; set; }
    //    public int _118 { get; set; }
    //    public int _138 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _170 { get; set; }
    //    public int _174 { get; set; }
    //    public int _106 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _140 { get; set; }
    //    public int _164 { get; set; }
    //    public int _78 { get; set; }
    //    public int _158 { get; set; }
    //}

    //public class _104
    //{
    //    public int _80 { get; set; }
    //    public int _104 { get; set; }
    //    public int _106 { get; set; }
    //    public int _156 { get; set; }
    //    public int _176 { get; set; }
    //    public int _120 { get; set; }
    //    public int _138 { get; set; }
    //    public int _140 { get; set; }
    //    public int _142 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _122 { get; set; }
    //    public int _78 { get; set; }
    //    public int _164 { get; set; }
    //    public int _178 { get; set; }
    //}

    //public class _106
    //{
    //    public int _108 { get; set; }
    //    public int _146 { get; set; }
    //    public int _156 { get; set; }
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _136 { get; set; }
    //    public int _166 { get; set; }
    //    public int _102 { get; set; }
    //    public int _104 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _138 { get; set; }
    //    public int _168 { get; set; }
    //    public int _78 { get; set; }
    //    public int _150 { get; set; }
    //    public int _142 { get; set; }
    //    public int _144 { get; set; }
    //    public int _148 { get; set; }
    //    public int _176 { get; set; }
    //    public int _174 { get; set; }
    //}

    //public class _108
    //{
    //    public int _80 { get; set; }
    //    public int _110 { get; set; }
    //    public int _140 { get; set; }
    //    public int _142 { get; set; }
    //    public int _144 { get; set; }
    //    public int _146 { get; set; }
    //    public int _148 { get; set; }
    //    public int _150 { get; set; }
    //    public int _152 { get; set; }
    //    public int _154 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //    public int _100 { get; set; }
    //    public int _156 { get; set; }
    //    public int _78 { get; set; }
    //    public int _166 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _164 { get; set; }
    //    public int _178 { get; set; }
    //}

    //public class _110
    //{
    //    public int _80 { get; set; }
    //    public int _112 { get; set; }
    //    public int _138 { get; set; }
    //    public int _140 { get; set; }
    //    public int _100 { get; set; }
    //    public int _78 { get; set; }
    //    public int _142 { get; set; }
    //    public int _132 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //    public int _154 { get; set; }
    //    public int _166 { get; set; }
    //    public int _152 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _164 { get; set; }
    //    public int _172 { get; set; }
    //    public int _178 { get; set; }
    //}

    //public class _112
    //{
    //    public int _78 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _116 { get; set; }
    //    public int _118 { get; set; }
    //    public int _122 { get; set; }
    //    public int _136 { get; set; }
    //    public int _140 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _138 { get; set; }
    //    public int _132 { get; set; }
    //    public int _134 { get; set; }
    //    public int _142 { get; set; }
    //    public int _154 { get; set; }
    //    public int _166 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _152 { get; set; }
    //    public int _164 { get; set; }
    //    public int _172 { get; set; }
    //}

    //public class _114
    //{
    //    public int _78 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _116 { get; set; }
    //    public int _118 { get; set; }
    //    public int _120 { get; set; }
    //    public int _122 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //    public int _138 { get; set; }
    //    public int _98 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _124 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _130 { get; set; }
    //    public int _140 { get; set; }
    //    public int _154 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _152 { get; set; }
    //    public int _164 { get; set; }
    //    public int _166 { get; set; }
    //}

    //public class _116
    //{
    //    public int _78 { get; set; }
    //    public int _110 { get; set; }
    //    public int _114 { get; set; }
    //    public int _118 { get; set; }
    //    public int _120 { get; set; }
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _132 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //    public int _100 { get; set; }
    //    public int _98 { get; set; }
    //    public int _102 { get; set; }
    //    public int _104 { get; set; }
    //    public int _106 { get; set; }
    //    public int _108 { get; set; }
    //    public int _116 { get; set; }
    //    public int _138 { get; set; }
    //    public int _140 { get; set; }
    //    public int _154 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _166 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _150 { get; set; }
    //    public int _164 { get; set; }
    //}

    //public class _118
    //{
    //    public int _110 { get; set; }
    //    public int _114 { get; set; }
    //    public int _116 { get; set; }
    //    public int _118 { get; set; }
    //    public int _120 { get; set; }
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _128 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //    public int _134 { get; set; }
    //    public int _78 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _102 { get; set; }
    //    public int _104 { get; set; }
    //    public int _106 { get; set; }
    //    public int _108 { get; set; }
    //    public int _112 { get; set; }
    //    public int _136 { get; set; }
    //    public int _126 { get; set; }
    //    public int _138 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _166 { get; set; }
    //    public int _156 { get; set; }
    //    public int _172 { get; set; }
    //    public int _176 { get; set; }
    //    public int _150 { get; set; }
    //    public int _174 { get; set; }
    //}

    //public class _120
    //{
    //    public int _78 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _118 { get; set; }
    //    public int _120 { get; set; }
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //    public int _104 { get; set; }
    //    public int _106 { get; set; }
    //    public int _136 { get; set; }
    //    public int _80 { get; set; }
    //    public int _138 { get; set; }
    //    public int _160 { get; set; }
    //    public int _168 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _150 { get; set; }
    //}

    //public class _1221
    //{
    //    public int _80 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _116 { get; set; }
    //    public int _118 { get; set; }
    //    public int _120 { get; set; }
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _106 { get; set; }
    //    public int _114 { get; set; }
    //    public int _134 { get; set; }
    //    public int _78 { get; set; }
    //    public int _136 { get; set; }
    //    public int _138 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _148 { get; set; }
    //    public int _168 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _158 { get; set; }
    //}

    //public class _124
    //{
    //    public int _82 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _116 { get; set; }
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _130 { get; set; }
    //    public int _80 { get; set; }
    //    public int _106 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _118 { get; set; }
    //    public int _132 { get; set; }
    //    public int _78 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //    public int _138 { get; set; }
    //    public int _142 { get; set; }
    //    public int _160 { get; set; }
    //    public int _140 { get; set; }
    //    public int _144 { get; set; }
    //    public int _146 { get; set; }
    //    public int _148 { get; set; }
    //    public int _170 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _158 { get; set; }
    //}

    //public class _1261
    //{
    //    public int _82 { get; set; }
    //    public int _108 { get; set; }
    //    public int _116 { get; set; }
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _106 { get; set; }
    //    public int _78 { get; set; }
    //    public int _84 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //    public int _134 { get; set; }
    //    public int _138 { get; set; }
    //    public int _140 { get; set; }
    //    public int _142 { get; set; }
    //    public int _144 { get; set; }
    //    public int _146 { get; set; }
    //    public int _148 { get; set; }
    //    public int _150 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _170 { get; set; }
    //    public int _176 { get; set; }
    //    public int _136 { get; set; }
    //    public int _172 { get; set; }
    //}

    //public class _128
    //{
    //    public int _82 { get; set; }
    //    public int _108 { get; set; }
    //    public int _120 { get; set; }
    //    public int _122 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _106 { get; set; }
    //    public int _116 { get; set; }
    //    public int _84 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //    public int _142 { get; set; }
    //    public int _146 { get; set; }
    //    public int _148 { get; set; }
    //    public int _150 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _170 { get; set; }
    //    public int _176 { get; set; }
    //}

    //public class _130
    //{
    //    public int _82 { get; set; }
    //    public int _108 { get; set; }
    //    public int _116 { get; set; }
    //    public int _122 { get; set; }
    //    public int _104 { get; set; }
    //    public int _106 { get; set; }
    //    public int _114 { get; set; }
    //    public int _120 { get; set; }
    //    public int _78 { get; set; }
    //    public int _86 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //    public int _142 { get; set; }
    //    public int _150 { get; set; }
    //    public int _152 { get; set; }
    //    public int _154 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _146 { get; set; }
    //    public int _170 { get; set; }
    //    public int _164 { get; set; }
    //    public int _176 { get; set; }
    //    public int _172 { get; set; }
    //}

    //public class _132
    //{
    //    public int _84 { get; set; }
    //    public int _108 { get; set; }
    //    public int _114 { get; set; }
    //    public int _120 { get; set; }
    //    public int _128 { get; set; }
    //    public int _102 { get; set; }
    //    public int _104 { get; set; }
    //    public int _118 { get; set; }
    //    public int _78 { get; set; }
    //    public int _88 { get; set; }
    //    public int _126 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //    public int _144 { get; set; }
    //    public int _152 { get; set; }
    //    public int _154 { get; set; }
    //    public int _156 { get; set; }
    //    public int _170 { get; set; }
    //    public int _166 { get; set; }
    //    public int _176 { get; set; }
    //    public int _146 { get; set; }
    //    public int _158 { get; set; }
    //    public int _162 { get; set; }
    //    public int _164 { get; set; }
    //    public int _172 { get; set; }
    //}

    //public class _134
    //{
    //    public int _84 { get; set; }
    //    public int _108 { get; set; }
    //    public int _112 { get; set; }
    //    public int _118 { get; set; }
    //    public int _126 { get; set; }
    //    public int _86 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _78 { get; set; }
    //    public int _90 { get; set; }
    //    public int _94 { get; set; }
    //    public int _96 { get; set; }
    //    public int _124 { get; set; }
    //    public int _128 { get; set; }
    //    public int _134 { get; set; }
    //    public int _144 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _120 { get; set; }
    //    public int _132 { get; set; }
    //    public int _146 { get; set; }
    //    public int _170 { get; set; }
    //    public int _166 { get; set; }
    //    public int _176 { get; set; }
    //    public int _168 { get; set; }
    //    public int _172 { get; set; }
    //}

    //public class _136
    //{
    //    public int _84 { get; set; }
    //    public int _108 { get; set; }
    //    public int _112 { get; set; }
    //    public int _116 { get; set; }
    //    public int _124 { get; set; }
    //    public int _88 { get; set; }
    //    public int _96 { get; set; }
    //    public int _78 { get; set; }
    //    public int _90 { get; set; }
    //    public int _126 { get; set; }
    //    public int _134 { get; set; }
    //    public int _146 { get; set; }
    //    public int _158 { get; set; }
    //    public int _118 { get; set; }
    //    public int _128 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //    public int _168 { get; set; }
    //    public int _170 { get; set; }
    //    public int _174 { get; set; }
    //    public int _144 { get; set; }
    //    public int _176 { get; set; }
    //}

    //public class _138
    //{
    //    public int _86 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _114 { get; set; }
    //    public int _124 { get; set; }
    //    public int _90 { get; set; }
    //    public int _96 { get; set; }
    //    public int _116 { get; set; }
    //    public int _78 { get; set; }
    //    public int _92 { get; set; }
    //    public int _122 { get; set; }
    //    public int _136 { get; set; }
    //    public int _146 { get; set; }
    //    public int _158 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //    public int _134 { get; set; }
    //    public int _170 { get; set; }
    //    public int _138 { get; set; }
    //    public int _140 { get; set; }
    //    public int _142 { get; set; }
    //    public int _172 { get; set; }
    //    public int _176 { get; set; }
    //}

    //public class _140
    //{
    //    public int _88 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _116 { get; set; }
    //    public int _122 { get; set; }
    //    public int _84 { get; set; }
    //    public int _90 { get; set; }
    //    public int _92 { get; set; }
    //    public int _94 { get; set; }
    //    public int _96 { get; set; }
    //    public int _114 { get; set; }
    //    public int _78 { get; set; }
    //    public int _120 { get; set; }
    //    public int _138 { get; set; }
    //    public int _148 { get; set; }
    //    public int _160 { get; set; }
    //    public int _134 { get; set; }
    //    public int _170 { get; set; }
    //    public int _174 { get; set; }
    //    public int _172 { get; set; }
    //}

    //public class _142
    //{
    //    public int _90 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _120 { get; set; }
    //    public int _86 { get; set; }
    //    public int _88 { get; set; }
    //    public int _92 { get; set; }
    //    public int _94 { get; set; }
    //    public int _96 { get; set; }
    //    public int _106 { get; set; }
    //    public int _118 { get; set; }
    //    public int _140 { get; set; }
    //    public int _148 { get; set; }
    //    public int _150 { get; set; }
    //    public int _162 { get; set; }
    //    public int _122 { get; set; }
    //    public int _132 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //    public int _170 { get; set; }
    //    public int _174 { get; set; }
    //    public int _172 { get; set; }
    //    public int _176 { get; set; }
    //}

    //public class _144
    //{
    //    public int _92 { get; set; }
    //    public int _94 { get; set; }
    //    public int _104 { get; set; }
    //    public int _106 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _118 { get; set; }
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _102 { get; set; }
    //    public int _78 { get; set; }
    //    public int _116 { get; set; }
    //    public int _142 { get; set; }
    //    public int _144 { get; set; }
    //    public int _150 { get; set; }
    //    public int _164 { get; set; }
    //    public int _120 { get; set; }
    //    public int _170 { get; set; }
    //    public int _174 { get; set; }
    //    public int _172 { get; set; }
    //    public int _122 { get; set; }
    //    public int _176 { get; set; }
    //}

    //public class _146
    //{
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _102 { get; set; }
    //    public int _108 { get; set; }
    //    public int _112 { get; set; }
    //    public int _110 { get; set; }
    //    public int _78 { get; set; }
    //    public int _104 { get; set; }
    //    public int _116 { get; set; }
    //    public int _118 { get; set; }
    //    public int _144 { get; set; }
    //    public int _152 { get; set; }
    //    public int _166 { get; set; }
    //    public int _150 { get; set; }
    //    public int _170 { get; set; }
    //    public int _174 { get; set; }
    //    public int _120 { get; set; }
    //}

    //public class _148
    //{
    //    public int _98 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _96 { get; set; }
    //    public int _100 { get; set; }
    //    public int _78 { get; set; }
    //    public int _114 { get; set; }
    //    public int _116 { get; set; }
    //    public int _146 { get; set; }
    //    public int _152 { get; set; }
    //    public int _168 { get; set; }
    //    public int _150 { get; set; }
    //    public int _170 { get; set; }
    //    public int _174 { get; set; }
    //    public int _172 { get; set; }
    //    public int _120 { get; set; }
    //    public int _122 { get; set; }
    //}

    //public class _150
    //{
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _96 { get; set; }
    //    public int _100 { get; set; }
    //    public int _78 { get; set; }
    //    public int _148 { get; set; }
    //    public int _152 { get; set; }
    //    public int _170 { get; set; }
    //    public int _150 { get; set; }
    //    public int _174 { get; set; }
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _126 { get; set; }
    //}

    //public class _68
    //{
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //}

    //public class _70
    //{
    //    public int _74 { get; set; }
    //    public int _76 { get; set; }
    //    public int _160 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _162 { get; set; }
    //}

    //public class _152
    //{
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _106 { get; set; }
    //    public int _108 { get; set; }
    //    public int _78 { get; set; }
    //    public int _148 { get; set; }
    //    public int _154 { get; set; }
    //    public int _170 { get; set; }
    //    public int _150 { get; set; }
    //    public int _174 { get; set; }
    //    public int _110 { get; set; }
    //    public int _122 { get; set; }
    //    public int _126 { get; set; }
    //    public int _128 { get; set; }
    //    public int _176 { get; set; }
    //}

    //public class _154
    //{
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _106 { get; set; }
    //    public int _78 { get; set; }
    //    public int _150 { get; set; }
    //    public int _152 { get; set; }
    //    public int _154 { get; set; }
    //    public int _170 { get; set; }
    //    public int _168 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _124 { get; set; }
    //    public int _126 { get; set; }
    //    public int _130 { get; set; }
    //    public int _132 { get; set; }
    //}

    //public class _156
    //{
    //    public int _98 { get; set; }
    //    public int _106 { get; set; }
    //    public int _96 { get; set; }
    //    public int _154 { get; set; }
    //    public int _156 { get; set; }
    //    public int _172 { get; set; }
    //    public int _168 { get; set; }
    //    public int _176 { get; set; }
    //    public int _126 { get; set; }
    //    public int _134 { get; set; }
    //    public int _136 { get; set; }
    //}

    //public class _158
    //{
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _106 { get; set; }
    //    public int _78 { get; set; }
    //    public int _80 { get; set; }
    //    public int _156 { get; set; }
    //    public int _158 { get; set; }
    //    public int _168 { get; set; }
    //    public int _172 { get; set; }
    //    public int _138 { get; set; }
    //}

    //public class _160
    //{
    //    public int _98 { get; set; }
    //    public int _104 { get; set; }
    //    public int _78 { get; set; }
    //    public int _80 { get; set; }
    //    public int _82 { get; set; }
    //    public int _84 { get; set; }
    //    public int _86 { get; set; }
    //    public int _88 { get; set; }
    //    public int _90 { get; set; }
    //    public int _92 { get; set; }
    //    public int _96 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //    public int _162 { get; set; }
    //    public int _172 { get; set; }
    //    public int _168 { get; set; }
    //    public int _176 { get; set; }
    //    public int _106 { get; set; }
    //    public int _126 { get; set; }
    //    public int _138 { get; set; }
    //}

    //public class _162
    //{
    //    public int _94 { get; set; }
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _104 { get; set; }
    //    public int _78 { get; set; }
    //    public int _80 { get; set; }
    //    public int _82 { get; set; }
    //    public int _158 { get; set; }
    //    public int _164 { get; set; }
    //    public int _172 { get; set; }
    //    public int _168 { get; set; }
    //    public int _170 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _106 { get; set; }
    //    public int _126 { get; set; }
    //    public int _140 { get; set; }
    //}

    //public class _164
    //{
    //    public int _94 { get; set; }
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
        //public int _100 { get; set; }
        //public int _104 { get; set; }
        //public int _80 { get; set; }
        //public int _82 { get; set; }
        //public int _160 { get; set; }
        //public int _166 { get; set; }
        //public int _170 { get; set; }
    //    public int _158 { get; set; }
    //    public int _168 { get; set; }
    //    public int _174 { get; set; }
    //    public int _172 { get; set; }
    //    public int _176 { get; set; }
    //    public int _106 { get; set; }
    //    public int _126 { get; set; }
    //    public int _140 { get; set; }
    //}

    //public class _166
    //{
    //    public int _100 { get; set; }
    //    public int _104 { get; set; }
    //    public int _80 { get; set; }
    //    public int _82 { get; set; }
    //    public int _84 { get; set; }
    //    public int _162 { get; set; }
    //    public int _166 { get; set; }
    //    public int _158 { get; set; }
    //    public int _174 { get; set; }
    //    public int _126 { get; set; }
    //    public int _140 { get; set; }
    //    public int _176 { get; set; }
    //}

    //public class _168
    //{
    //    public int _100 { get; set; }
    //    public int _102 { get; set; }
    //    public int _80 { get; set; }
    //    public int _82 { get; set; }
    //    public int _84 { get; set; }
    //    public int _164 { get; set; }
    //    public int _168 { get; set; }
    //    public int _170 { get; set; }
    //    public int _160 { get; set; }
    //    public int _174 { get; set; }
    //    public int _172 { get; set; }
    //    public int _176 { get; set; }
    //    public int _104 { get; set; }
    //    public int _126 { get; set; }
    //    public int _142 { get; set; }
    //}

    //public class _170
    //{
    //    public int _102 { get; set; }
    //    public int _104 { get; set; }
    //    public int _106 { get; set; }
    //    public int _80 { get; set; }
    //    public int _82 { get; set; }
    //    public int _84 { get; set; }
    //    public int _86 { get; set; }
    //    public int _88 { get; set; }
    //    public int _90 { get; set; }
    //    public int _170 { get; set; }
    //    public int _172 { get; set; }
    //    public int _160 { get; set; }
    //    public int _174 { get; set; }
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _126 { get; set; }
    //    public int _142 { get; set; }
    //}

    //public class _172
    //{
    //    public int _102 { get; set; }
    //    public int _104 { get; set; }
    //    public int _106 { get; set; }
    //    public int _82 { get; set; }
    //    public int _84 { get; set; }
    //    public int _86 { get; set; }
    //    public int _88 { get; set; }
    //    public int _90 { get; set; }
    //    public int _92 { get; set; }
    //    public int _94 { get; set; }
    //    public int _96 { get; set; }
    //    public int _170 { get; set; }
    //    public int _172 { get; set; }
    //    public int _162 { get; set; }
    //    public int _174 { get; set; }
    //    public int _144 { get; set; }
    //    public int _150 { get; set; }
    //    public int _152 { get; set; }
    //    public int _154 { get; set; }
    //    public int _156 { get; set; }
    //}

    //public class _1741
    //{
    //    public int _100 { get; set; }
    //    public int _102 { get; set; }
    //    public int _104 { get; set; }
    //    public int _86 { get; set; }
    //    public int _88 { get; set; }
    //    public int _90 { get; set; }
    //    public int _92 { get; set; }
    //    public int _94 { get; set; }
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _164 { get; set; }
    //    public int _166 { get; set; }
    //    public int _168 { get; set; }
    //    public int _176 { get; set; }
    //    public int _106 { get; set; }
    //    public int _110 { get; set; }
    //    public int _126 { get; set; }
    //    public int _146 { get; set; }
    //    public int _148 { get; set; }
    //    public int _158 { get; set; }
    //    public int _160 { get; set; }
    //}

    //public class _176
    //{
    //    public int _104 { get; set; }
    //    public int _90 { get; set; }
    //    public int _92 { get; set; }
    //    public int _94 { get; set; }
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _102 { get; set; }
    //    public int _106 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _170 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _116 { get; set; }
    //    public int _118 { get; set; }
    //    public int _120 { get; set; }
    //    public int _126 { get; set; }
    //    public int _162 { get; set; }
    //}

    //public class _178
    //{
    //    public int _92 { get; set; }
    //    public int _96 { get; set; }
    //    public int _98 { get; set; }
    //    public int _100 { get; set; }
    //    public int _102 { get; set; }
    //    public int _172 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _90 { get; set; }
    //    public int _94 { get; set; }
    //    public int _104 { get; set; }
    //    public int _106 { get; set; }
    //    public int _108 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _114 { get; set; }
    //    public int _116 { get; set; }
    //    public int _118 { get; set; }
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _164 { get; set; }
    //    public int _168 { get; set; }
    //    public int _170 { get; set; }
    //}

    //public class _180
    //{
    //    public int _92 { get; set; }
    //    public int _94 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _178 { get; set; }
    //    public int _98 { get; set; }
    //    public int _102 { get; set; }
    //    public int _110 { get; set; }
    //    public int _112 { get; set; }
    //    public int _172 { get; set; }
    //}

    //public class _182
    //{
    //    public int _92 { get; set; }
    //    public int _174 { get; set; }
    //    public int _176 { get; set; }
    //    public int _178 { get; set; }
    //    public int _94 { get; set; }
    //    public int _96 { get; set; }
    //}

    //public class _184
    //{
    //    public int _176 { get; set; }
    //    public int _174 { get; set; }
    //}

    //public class Obs
    //{
    //    public _961 _96 { get; set; }
    //    public _1041 _104 { get; set; }
    //    public _1101 _110 { get; set; }
    //    public _1262 _126 { get; set; }
    //    public _1281 _128 { get; set; }
    //    public _1701 _170 { get; set; }
    //    public _1121 _112 { get; set; }
    //    public _1201 _120 { get; set; }
    //    public _1321 _132 { get; set; }
    //    public _1461 _146 { get; set; }
    //    public _781 _78 { get; set; }
    //}

    //public class _961
    //{
    //    public int _156 { get; set; }
    //}

    //public class _1041
    //{
    //    public int _174 { get; set; }
    //}

    //public class _1101
    //{
    //    public int _146 { get; set; }
    //}

    //public class _1262
    //{
    //    public int _120 { get; set; }
    //}

    //public class _1281
    //{
    //    public int _120 { get; set; }
    //}

    //public class _1701
    //{
    //    public int _102 { get; set; }
    //}

    //public class _1121
    //{
    //    public int _130 { get; set; }
    //}

    //public class _1201
    //{
    //    public int _122 { get; set; }
    //}

    //public class _1321
    //{
    //    public int _96 { get; set; }
    //}

    //public class _1461
    //{
    //    public int _118 { get; set; }
    //}

    //public class _781
    //{
    //    public int _156 { get; set; }
    //}

    //public class Sen
    //{
    //    public _941 _94 { get; set; }
    //    public _1222 _122 { get; set; }
    //    public _1263 _126 { get; set; }
    //    public _1462 _146 { get; set; }
    //}

    //public class _941
    //{
    //    public int _162 { get; set; }
    //}

    //public class _1222
    //{
    //    public int _122 { get; set; }
    //    public int _124 { get; set; }
    //    public int _126 { get; set; }
    //}

    //public class _1263
    //{
    //    public int _144 { get; set; }
    //}

    //public class _1462
    //{
    //    public int _116 { get; set; }
    //}

    //public class Actions
    //{
    //    public int _1 { get; set; }
    //    public int _2 { get; set; }
    //    public int _3 { get; set; }
    //    public int _4 { get; set; }
    //    public int _5 { get; set; }
    //    public int _6 { get; set; }
    //    public int _7 { get; set; }
    //    public int _8 { get; set; }
    //    public int _9 { get; set; }
    //    public int _10 { get; set; }
    //    public int _11 { get; set; }
    //    public int _14 { get; set; }
    //    public int _15 { get; set; }
    //    public int _16 { get; set; }
    //    public int _17 { get; set; }
    //    public int _19 { get; set; }
    //    public int _27 { get; set; }
    //    public int _21 { get; set; }
    //    public int _13 { get; set; }
    //    public int _12 { get; set; }
    //    public int _25 { get; set; }
    //}

    public class Pings
    {
        public int _0 { get; set; }
    }

    //public class Purchase
    //{
    //    public int stout_shield { get; set; }
    //    public int quelling_blade { get; set; }
    //    public int bottle { get; set; }
    //    public int boots { get; set; }
    //    public int tpscroll { get; set; }
    //    public int blades_of_attack { get; set; }
    //    public int phase_boots { get; set; }
    //    public int circlet { get; set; }
    //    public int gauntlets { get; set; }
    //    public int bracer { get; set; }
    //    public int recipe_bracer { get; set; }
    //    public int recipe_ancient_janggo { get; set; }
    //    public int robe { get; set; }
    //    public int ancient_janggo { get; set; }
    //    public int claymore { get; set; }
    //    public int broadsword { get; set; }
    //    public int courier { get; set; }
    //    public int clarity { get; set; }
    //    public int tango { get; set; }
    //    public int magic_stick { get; set; }
    //    public int ward_observer { get; set; }
    //    public int belt_of_strength { get; set; }
    //    public int power_treads { get; set; }
    //    public int gloves { get; set; }
    //    public int helm_of_iron_will { get; set; }
    //    public int recipe_armlet { get; set; }
    //    public int armlet { get; set; }
    //    public int smoke_of_deceit { get; set; }
    //    public int flying_courier { get; set; }
    //    public int ward_dispenser { get; set; }
    //    public int ward_sentry { get; set; }
    //    public int branches { get; set; }
    //    public int magic_wand { get; set; }
    //    public int blink { get; set; }
    //    public int flask { get; set; }
    //    public int ring_of_regen { get; set; }
    //    public int slippers { get; set; }
    //    public int wraith_band { get; set; }
    //    public int recipe_wraith_band { get; set; }
    //    public int orb_of_venom { get; set; }
    //    public int enchanted_mango { get; set; }
    //    public int cloak { get; set; }
    //    public int ogre_axe { get; set; }
    //    public int recipe_sange { get; set; }
    //    public int sange { get; set; }
    //    public int blade_of_alacrity { get; set; }
    //    public int boots_of_elves { get; set; }
    //}

    //public class Gold_Reasons
    //{
    //    public int _0 { get; set; }
    //    public int _6 { get; set; }
    //    public int _11 { get; set; }
    //    public int _12 { get; set; }
    //    public int _13 { get; set; }
    //    public int _1 { get; set; }
    //    public int _5 { get; set; }
    //}

    public class Xp_Reasons
    {
        public int _0 { get; set; }
        public int _1 { get; set; }
        public int _2 { get; set; }
    }

    //public class Killed1
    //{
    //    public int npc_dota_creep_badguys_melee { get; set; }
    //    public int npc_dota_creep_badguys_ranged { get; set; }
    //    public int npc_dota_badguys_siege { get; set; }
    //    public int npc_dota_hero_shadow_shaman { get; set; }
    //    public int npc_dota_hero_lion { get; set; }
    //    public int npc_dota_hero_templar_assassin { get; set; }
    //    public int npc_dota_creep_goodguys_melee { get; set; }
    //    public int npc_dota_badguys_tower1_top { get; set; }
    //    public int npc_dota_hero_spectre { get; set; }
    //    public int npc_dota_neutral_gnoll_assassin { get; set; }
    //    public int npc_dota_neutral_rock_golem { get; set; }
    //    public int npc_dota_neutral_granite_golem { get; set; }
    //    public int npc_dota_neutral_mud_golem { get; set; }
    //    public int npc_dota_neutral_mud_golem_split { get; set; }
    //    public int npc_dota_neutral_kobold { get; set; }
    //    public int npc_dota_creep_goodguys_ranged { get; set; }
    //    public int npc_dota_hero_omniknight { get; set; }
    //    public int npc_dota_hero_skeleton_king { get; set; }
    //    public int npc_dota_goodguys_siege { get; set; }
    //    public int npc_dota_hero_vengefulspirit { get; set; }
    //    public int npc_dota_neutral_dark_troll { get; set; }
    //    public int npc_dota_neutral_dark_troll_warlord { get; set; }
    //    public int npc_dota_dark_troll_warlord_skeleton_warrior { get; set; }
    //    public int npc_dota_neutral_centaur_outrunner { get; set; }
    //    public int npc_dota_neutral_polar_furbolg_champion { get; set; }
    //    public int npc_dota_hero_necrolyte { get; set; }
    //    public int npc_dota_neutral_kobold_tunneler { get; set; }
    //    public int npc_dota_neutral_kobold_taskmaster { get; set; }
    //    public int npc_dota_neutral_forest_troll_berserker { get; set; }
    //    public int npc_dota_hero_slardar { get; set; }
    //}

    //public class Item_Uses1
    //{
    //    public int quelling_blade { get; set; }
    //    public int tango_single { get; set; }
    //    public int bottle { get; set; }
    //    public int tpscroll { get; set; }
    //    public int phase_boots { get; set; }
    //    public int courier { get; set; }
    //    public int ward_observer { get; set; }
    //    public int tango { get; set; }
    //    public int magic_stick { get; set; }
    //    public int clarity { get; set; }
    //    public int ward_dispenser { get; set; }
    //    public int ward_sentry { get; set; }
    //    public int magic_wand { get; set; }
    //    public int blink { get; set; }
    //    public int flask { get; set; }
    //    public int smoke_of_deceit { get; set; }
    //    public int enchanted_mango { get; set; }
    //}

    //public class Ability_Uses1
    //{
    //    public int ember_spirit_flame_guard { get; set; }
    //    public int ember_spirit_searing_chains { get; set; }
    //    public int ember_spirit_fire_remnant { get; set; }
    //    public int ember_spirit_activate_fire_remnant { get; set; }
    //    public int ember_spirit_sleight_of_fist { get; set; }
    //    public int necrolyte_death_pulse { get; set; }
    //    public int necrolyte_reapers_scythe { get; set; }
    //    public int skeleton_king_hellfire_blast { get; set; }
    //    public int vengefulspirit_wave_of_terror { get; set; }
    //    public int vengefulspirit_magic_missile { get; set; }
    //    public int slardar_slithereen_crush { get; set; }
    //    public int slardar_sprint { get; set; }
    //    public int slardar_amplify_damage { get; set; }
    //    public int lion_voodoo { get; set; }
    //    public int lion_impale { get; set; }
    //    public int lion_mana_drain { get; set; }
    //    public int templar_assassin_refraction { get; set; }
    //    public int templar_assassin_meld { get; set; }
    //    public int templar_assassin_psionic_trap { get; set; }
    //    public int templar_assassin_trap { get; set; }
    //    public int spectre_spectral_dagger { get; set; }
    //    public int spectre_haunt { get; set; }
    //    public int spectre_reality { get; set; }
    //    public int shadow_shaman_shackles { get; set; }
    //    public int shadow_shaman_voodoo { get; set; }
    //    public int shadow_shaman_ether_shock { get; set; }
    //    public int omniknight_purification { get; set; }
    //    public int omniknight_repel { get; set; }
    //    public int omniknight_guardian_angel { get; set; }
    //}

    //public class Hero_Hits
    //{
    //    public int undefined { get; set; }
    //    public int ember_spirit_flame_guard { get; set; }
    //    public int ember_spirit_searing_chains { get; set; }
    //    public int ember_spirit_activate_fire_remnant { get; set; }
    //    public int necrolyte_death_pulse { get; set; }
    //    public int necrolyte_heartstopper_aura { get; set; }
    //    public int necrolyte_reapers_scythe { get; set; }
    //    public int skeleton_king_hellfire_blast { get; set; }
    //    public int vengefulspirit_magic_missile { get; set; }
    //    public int vengefulspirit_wave_of_terror { get; set; }
    //    public int slardar_slithereen_crush { get; set; }
    //    public int lion_impale { get; set; }
    //    public int templar_assassin_psi_blades { get; set; }
    //    public int templar_assassin_meld { get; set; }
    //    public int spectre_spectral_dagger { get; set; }
    //    public int spectre_desolate { get; set; }
    //    public int orb_of_venom { get; set; }
    //    public int spectre_dispersion { get; set; }
    //    public int shadow_shaman_shackles { get; set; }
    //    public int shadow_shaman_ether_shock { get; set; }
    //    public int omniknight_purification { get; set; }
    //}

    //public class Damage
    //{
    //    public int npc_dota_hero_lion { get; set; }
    //    public int npc_dota_creep_badguys_melee { get; set; }
    //    public int npc_dota_creep_badguys_ranged { get; set; }
    //    public int npc_dota_hero_templar_assassin { get; set; }
    //    public int npc_dota_badguys_siege { get; set; }
    //    public int npc_dota_creep_goodguys_ranged { get; set; }
    //    public int npc_dota_hero_shadow_shaman { get; set; }
    //    public int npc_dota_hero_spectre { get; set; }
    //    public int npc_dota_creep_goodguys_melee { get; set; }
    //    public int illusion_npc_dota_hero_spectre { get; set; }
    //    public int npc_dota_hero_omniknight { get; set; }
    //    public int npc_dota_badguys_tower1_top { get; set; }
    //    public int npc_dota_neutral_mud_golem { get; set; }
    //    public int npc_dota_neutral_dark_troll_warlord { get; set; }
    //    public int npc_dota_neutral_centaur_khan { get; set; }
    //    public int npc_dota_neutral_satyr_soulstealer { get; set; }
    //    public int npc_dota_badguys_tower1_mid { get; set; }
    //    public int npc_dota_neutral_gnoll_assassin { get; set; }
    //    public int npc_dota_neutral_rock_golem { get; set; }
    //    public int npc_dota_neutral_granite_golem { get; set; }
    //    public int npc_dota_neutral_mud_golem_split { get; set; }
    //    public int npc_dota_neutral_wildkin { get; set; }
    //    public int npc_dota_neutral_kobold { get; set; }
    //    public int npc_dota_hero_ember_spirit { get; set; }
    //    public int npc_dota_hero_skeleton_king { get; set; }
    //    public int npc_dota_neutral_centaur_outrunner { get; set; }
    //    public int npc_dota_hero_necrolyte { get; set; }
    //    public int npc_dota_goodguys_siege { get; set; }
    //    public int npc_dota_hero_vengefulspirit { get; set; }
    //    public int npc_dota_hero_slardar { get; set; }
    //    public int npc_dota_neutral_dark_troll { get; set; }
    //    public int npc_dota_dark_troll_warlord_skeleton_warrior { get; set; }
    //    public int npc_dota_neutral_polar_furbolg_ursa_warrior { get; set; }
    //    public int npc_dota_neutral_polar_furbolg_champion { get; set; }
    //    public int npc_dota_neutral_kobold_taskmaster { get; set; }
    //    public int npc_dota_neutral_kobold_tunneler { get; set; }
    //    public int npc_dota_neutral_forest_troll_berserker { get; set; }
    //}

    //public class Damage_Taken
    //{
    //    public int npc_dota_hero_lion { get; set; }
    //    public int npc_dota_creep_badguys_ranged { get; set; }
    //    public int npc_dota_creep_badguys_melee { get; set; }
    //    public int npc_dota_hero_templar_assassin { get; set; }
    //    public int npc_dota_badguys_tower1_mid { get; set; }
    //    public int npc_dota_hero_spectre { get; set; }
    //    public int npc_dota_badguys_tower1_top { get; set; }
    //    public int npc_dota_hero_shadow_shaman { get; set; }
    //    public int npc_dota_hero_omniknight { get; set; }
    //    public int npc_dota_badguys_siege { get; set; }
    //    public int npc_dota_neutral_mud_golem { get; set; }
    //    public int npc_dota_neutral_kobold { get; set; }
    //    public int npc_dota_neutral_kobold_tunneler { get; set; }
    //    public int npc_dota_neutral_gnoll_assassin { get; set; }
    //    public int undefined { get; set; }
    //    public int npc_dota_neutral_rock_golem { get; set; }
    //    public int npc_dota_neutral_granite_golem { get; set; }
    //    public int npc_dota_neutral_dark_troll { get; set; }
    //    public int npc_dota_neutral_dark_troll_warlord { get; set; }
    //    public int npc_dota_neutral_centaur_khan { get; set; }
    //    public int npc_dota_neutral_polar_furbolg_ursa_warrior { get; set; }
    //    public int npc_dota_neutral_polar_furbolg_champion { get; set; }
    //    public int npc_dota_neutral_centaur_outrunner { get; set; }
    //    public int npc_dota_neutral_mud_golem_split { get; set; }
    //    public int npc_dota_neutral_kobold_taskmaster { get; set; }
    //    public int npc_dota_hero_ember_spirit { get; set; }
    //    public int npc_dota_creep_goodguys_ranged { get; set; }
    //    public int npc_dota_goodguys_tower1_mid { get; set; }
    //    public int npc_dota_hero_necrolyte { get; set; }
    //    public int npc_dota_creep_goodguys_melee { get; set; }
    //    public int npc_dota_goodguys_siege { get; set; }
    //    public int npc_dota_hero_skeleton_king { get; set; }
    //    public int npc_dota_hero_vengefulspirit { get; set; }
    //    public int npc_dota_hero_slardar { get; set; }
    //    public int npc_dota_dark_troll_warlord_skeleton_warrior { get; set; }
    //    public int npc_dota_neutral_forest_troll_berserker { get; set; }
    //    public int npc_dota_goodguys_tower1_bot { get; set; }
    //}

    //public class Damage_Inflictor
    //{
    //    public int undefined { get; set; }
    //    public int ember_spirit_flame_guard { get; set; }
    //    public int ember_spirit_searing_chains { get; set; }
    //    public int ember_spirit_activate_fire_remnant { get; set; }
    //    public int necrolyte_death_pulse { get; set; }
    //    public int necrolyte_heartstopper_aura { get; set; }
    //    public int necrolyte_reapers_scythe { get; set; }
    //    public int skeleton_king_hellfire_blast { get; set; }
    //    public int vengefulspirit_magic_missile { get; set; }
    //    public int vengefulspirit_wave_of_terror { get; set; }
    //    public int slardar_slithereen_crush { get; set; }
    //    public int lion_impale { get; set; }
    //    public int templar_assassin_psi_blades { get; set; }
    //    public int templar_assassin_meld { get; set; }
    //    public int spectre_spectral_dagger { get; set; }
    //    public int spectre_desolate { get; set; }
    //    public int orb_of_venom { get; set; }
    //    public int spectre_dispersion { get; set; }
    //    public int shadow_shaman_shackles { get; set; }
    //    public int shadow_shaman_ether_shock { get; set; }
    //    public int omniknight_purification { get; set; }
    //}

    public class Runes
    {
        public int _1 { get; set; }
        public int _5 { get; set; }
        public int _0 { get; set; }
        public int _3 { get; set; }
        public int _2 { get; set; }
        public int _4 { get; set; }
    }

    //public class Killed_By
    //{
    //    public int npc_dota_hero_spectre { get; set; }
    //    public int npc_dota_hero_shadow_shaman { get; set; }
    //    public int npc_dota_hero_lion { get; set; }
    //    public int npc_dota_hero_templar_assassin { get; set; }
    //    public int npc_dota_hero_omniknight { get; set; }
    //    public int npc_dota_hero_ember_spirit { get; set; }
    //    public int npc_dota_hero_vengefulspirit { get; set; }
    //    public int npc_dota_hero_necrolyte { get; set; }
    //    public int npc_dota_neutral_dark_troll_warlord { get; set; }
    //    public int npc_dota_hero_skeleton_king { get; set; }
    //    public int npc_dota_hero_slardar { get; set; }
    //}

    //public class Modifier_Applied
    //{
    //    public int modifier_tango_heal { get; set; }
    //    public int modifier_ember_spirit_flame_guard { get; set; }
    //    public int modifier_bottle_regeneration { get; set; }
    //    public int modifier_ember_spirit_searing_chains { get; set; }
    //    public int modifier_teleporting { get; set; }
    //    public int modifier_ember_spirit_fire_remnant_charge_counter { get; set; }
    //    public int modifier_item_phase_boots_active { get; set; }
    //    public int modifier_ember_spirit_fire_remnant_timer { get; set; }
    //    public int modifier_ember_spirit_fire_remnant { get; set; }
    //    public int modifier_item_ancient_janggo_aura_effect { get; set; }
    //    public int modifier_ember_spirit_sleight_of_fist_caster { get; set; }
    //    public int modifier_rune_haste { get; set; }
    //    public int modifier_necrolyte_heartstopper_aura_effect { get; set; }
    //    public int modifier_necrolyte_sadist_counter { get; set; }
    //    public int modifier_clarity_potion { get; set; }
    //    public int modifier_necrolyte_reapers_scythe { get; set; }
    //    public int modifier_skeleton_king_vampiric_aura_buff { get; set; }
    //    public int modifier_stunned { get; set; }
    //    public int modifier_skeleton_king_hellfire_blast { get; set; }
    //    public int modifier_vengefulspirit_wave_of_terror { get; set; }
    //    public int modifier_ward_delay { get; set; }
    //    public int modifier_rune_invis { get; set; }
    //    public int modifier_rune_doubledamage { get; set; }
    //    public int modifier_bashed { get; set; }
    //    public int modifier_slithereen_crush { get; set; }
    //    public int modifier_slardar_sprint { get; set; }
    //    public int modifier_slardar_amplify_damage { get; set; }
    //    public int modifier_lion_voodoo { get; set; }
    //    public int modifier_flask_healing { get; set; }
    //    public int modifier_lion_impale { get; set; }
    //    public int modifier_illusion { get; set; }
    //    public int modifier_invulnerable { get; set; }
    //    public int modifier_smoke_of_deceit { get; set; }
    //    public int modifier_lion_mana_drain { get; set; }
    //    public int modifier_templar_assassin_refraction_damage { get; set; }
    //    public int modifier_templar_assassin_refraction_absorb { get; set; }
    //    public int modifier_templar_assassin_meld { get; set; }
    //    public int modifier_templar_assassin_meld_armor { get; set; }
    //    public int modifier_rune_regen { get; set; }
    //    public int modifier_templar_assassin_trap_slow { get; set; }
    //    public int modifier_spectre_spectral_dagger_in_path { get; set; }
    //    public int modifier_spectre_spectral_dagger { get; set; }
    //    public int modifier_item_orb_of_venom_slow { get; set; }
    //    public int modifier_shadow_shaman_shackles { get; set; }
    //    public int modifier_shadow_shaman_voodoo { get; set; }
    //    public int modifier_omniknight_degen_aura_effect { get; set; }
    //    public int modifier_omniknight_repel { get; set; }
    //    public int modifier_omninight_guardian_angel { get; set; }
    //}

    public class Kill_Streaks
    {
        public int _3 { get; set; }
        public int _4 { get; set; }
        public int _5 { get; set; }
        public int _6 { get; set; }
        public int _7 { get; set; }
        public int _8 { get; set; }
        public int _9 { get; set; }
        public int _10 { get; set; }
    }

    public class Multi_Kills
    {
        public int _2 { get; set; }
    }

    //public class Healing
    //{
    //    public int npc_dota_hero_ember_spirit { get; set; }
    //    public int npc_dota_hero_vengefulspirit { get; set; }
    //    public int npc_dota_hero_slardar { get; set; }
    //    public int npc_dota_hero_necrolyte { get; set; }
    //    public int npc_dota_hero_skeleton_king { get; set; }
    //    public int npc_dota_hero_lion { get; set; }
    //    public int npc_dota_hero_templar_assassin { get; set; }
    //    public int npc_dota_hero_spectre { get; set; }
    //    public int npc_dota_hero_shadow_shaman { get; set; }
    //    public int npc_dota_hero_omniknight { get; set; }
    //}

    public class Ability_Upgrades
    {
        public int ability { get; set; }
        public int time { get; set; }
        public int level { get; set; }
    }

    public class Obs_Log
    {
        public int time { get; set; }
        public int[] key { get; set; }
    }

    public class Sen_Log
    {
        public int time { get; set; }
        public int[] key { get; set; }
    }

    public class Purchase_Log
    {
        public int time { get; set; }
        public string key { get; set; }
    }

    public class Kills_Log
    {
        public int time { get; set; }
        public string key { get; set; }
    }

}
