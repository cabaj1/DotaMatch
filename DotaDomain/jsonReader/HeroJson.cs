namespace DotaDomain.jsonReader
{
    public class Rootobject
    {
        public HeroJson[] Games { get; set; }
    }

    public class HeroJson
    {
        public string name { get; set; }
        public string primaryAttribute { get; set; }
        public int startStrength { get; set; }
        public int startAgility { get; set; }
        public int startIntelligence { get; set; }
        public float strengthPerLevel { get; set; }
        public float agilityPerLevel { get; set; }
        public float intelligencePerLevel { get; set; }
        public int health { get; set; }
        public float healthRegen { get; set; }
        public float magicalResistance { get; set; }
        public int mana { get; set; }
        public float manaRegen { get; set; }
        public int spellDamageAmplification { get; set; }
        public float armor { get; set; }
        public float attacksPerSecond { get; set; }
        public int movementSpeedAmplification { get; set; }
        public int damage { get; set; }
        public int movementSpeed { get; set; }
        public int attackSpeed { get; set; }
        public float turnRate { get; set; }
        public int dayVisionRange { get; set; }
        public int nightVisionRange { get; set; }
        public int attackRange { get; set; }
        public int projectileSpeed { get; set; }
        public string attackAnimation { get; set; }
        public float baseAttackTIme { get; set; }
        public int damageBlock { get; set; }
        public int collisionSize { get; set; }
        public int legs { get; set; }
        public string gibType { get; set; }
        public string[] roles { get; set; }
        public string attackType { get; set; }
        public string image { get; set; }
        public string lore { get; set; }
        public string voiceActor { get; set; }
        public string secondName { get; set; }
    }

}
