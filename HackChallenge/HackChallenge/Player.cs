using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackChallenge
{
    public class Player
    {
        private readonly string _name;
        private readonly TileState _playerToken;

        public Player(string name, TileState playerToken)
        {
            this._name = name;
            this._playerToken = playerToken;
        }

        public string GetName()
        {
            return _name;
        }

        public TileState GetPlayerToken()
        {
            return _playerToken;
        }
    }
}
