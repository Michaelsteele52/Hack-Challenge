using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackChallenge.HTTPObjects;

namespace HackChallenge
{
    public class TTTGame
    {
        private Tile[] board;

        public string _gameID { get; set; }

        public Player _player1 { get; set; }
        public Player _player2 { get; set; }

        private string _status;
        private string _winner;

        public TTTGame(NewGameRequestObject newGameObj)
        {
            _gameID = newGameObj.GameId;
            _player1 = new Player(newGameObj.X, TileState.X);
            _player2 = new Player(newGameObj.O, TileState.O);
        }

        public bool MakeMove(string json)
        {
            return true;
        }

    }


}
