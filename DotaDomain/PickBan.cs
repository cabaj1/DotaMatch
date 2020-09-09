using System;
using System.Collections.Generic;
using System.Text;

namespace DotaDomain
{
    public class PickBan
    {
        public bool is_pick { get; set; }
        public int Hero_id { get; set; }
        public int Team { get; set; } //0 or 1
        public int Order { get; set; }
    }
}
