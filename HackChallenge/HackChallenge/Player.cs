using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackChallenge
{
    public class Player
    {
        public string Name { get; set; }
        public TileState PlayerToken { get; set; }

        public Player(string name, TileState playerToken)
        {
            Name = name;
            PlayerToken = playerToken;
        }
    }
}
