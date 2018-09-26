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
    [Route("api/[controller]")]
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

        // GET: api/TTTGame/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            //ToDo: Get game using game ID
            return "value";
        }

        // POST: api/TTTGame
        [HttpPost]
        public void Post([FromBody] NewGameRequestObject value)
        {
         games.Add(new TTTGame(value));
           System.Diagnostics.Debugger.Break();
            //ToDo: Create a new game

        }

        // PUT: api/TTTGame/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            //ToDo: Make a move in a game
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
