using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackChallenge.HTTPObjects
{
    public class NewMoveObject 
    {
        public string Player { get; set; }
        public int BoardPosition { get; set; }
        public string GameId { get; set; }


    }
}
