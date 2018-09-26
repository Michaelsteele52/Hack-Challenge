using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackChallenge.HTTPObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HackChallenge.Controllers
{
    [Route("api/tttgame")]
    [ApiController]
    public class TTTGameController : ControllerBase
    {
        private static List<TTTGame> games = new List<TTTGame>();

        // GET: api/TTTGame
        [HttpGet]
        public IEnumerable<string> Get()
        {
            //return new [] {"String"};
            return games.Select(x => x._gameID);
        }

        // GET: api/TTTGame/GAMEID
        [HttpGet("{gameID}", Name = "Get")]
        public TTTGame Get(string gameID)
        {
            System.Diagnostics.Debugger.Break();
            Console.WriteLine("THIS IS THE GAME ID: " + gameID);
            return games.FirstOrDefault(x => x._gameID.Equals(gameID));
        }

        // POST: api/TTTGame
        [HttpPost]
        public void Post([FromBody] NewGameRequestObject value)
        {
         games.Add(new TTTGame(value));
           System.Diagnostics.Debugger.Break();
            //ToDo: Create a new game

        }

        // PUT: api/TTTGame/play
        [HttpPost("play")]
        public void Post([FromBody] NewMoveObject value)
        {
            games.FirstOrDefault(x => x._gameID.Equals(value.GameId)).MakeMove(value.BoardPosition, value.Player);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
