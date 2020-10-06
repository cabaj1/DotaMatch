using System;
using System.Collections.Generic;
using System.Text;

namespace DotaDomain
{
    public class PrimaryAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Effect_one { get; set; } //+1 damage
        public string Effect_two { get; set; } //+x armor / mana / hp
        public string Effect_three { get; set; } //+x mana / hp regen
    }
}
