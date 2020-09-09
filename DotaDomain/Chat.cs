using System;
using System.Collections.Generic;
using System.Text;

namespace DotaDomain
{
    public class Chat
    {
        public int Time { get; set; } //in sec
        public string Type { get; set; } // Player message or could be event type, I.E "CHAT_MESSAGE_TOWER_KILL"
        public string Unit { get; set; } //name of player
        public string Key { get; set; } //what they said
        public int slot { get; set; } //their slot


    }
}
