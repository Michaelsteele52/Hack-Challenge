using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackChallenge
{
    public class Tile
    {
        private TileState _state;

        public Tile()
        {
            this._state = TileState.Empty;
        }

        public TileState GetState()
        {
            return _state;
        }

        public void SetState(TileState state)
        {
            _state = state;
        }
    }
}
