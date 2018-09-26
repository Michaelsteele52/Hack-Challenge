using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackChallenge.HTTPObjects;

namespace HackChallenge
{
    public class TTTGame
    {
        public TileState[] board { get; set; }

        public string _gameID { get; set; }

        public Player _player1 { get; set; }
        public Player _player2 { get; set; }

        public string _status { get; set; }
        public string _winner { get; set; }

        public TTTGame(NewGameRequestObject newGameObj)
        {
            board = new TileState[9];
            _gameID = newGameObj.GameId;
            _player1 = new Player(newGameObj.X, TileState.X);
            _player2 = new Player(newGameObj.O, TileState.O);
        }

        public bool MakeMove(int position, string player)
        {
            if (position < 1 || position > 9) return false;
            int pos = position - 1;
            if (board[pos] != TileState.Empty)
            {
                return false;
            }
            if (player == "X")
            {
                board[pos] = TileState.X;
            } else if(player == "O")
            {
                board[pos] = TileState.O;
            }
            else
            {
                return false;
                //you fucked up
            }
           CheckStatus();
            return true;
        }

        private void CheckStatus()
        {
            //Check if someone has won
        }


    }


}
