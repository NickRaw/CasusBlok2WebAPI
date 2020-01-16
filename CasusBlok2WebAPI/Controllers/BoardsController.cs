using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CasusBlok2WebAPI.Models;

namespace CasusBlok2WebAPI.Controllers
{
    public class BoardsController : ApiController
    {
        Boardgame[] boardgames = new Boardgame[]
        {
            new Boardgame{ID = 0, name = "Colonisten van Katan", description = "Dit is een board spel.", minPlayers = 2, maxPlayers = 5 },
            new Boardgame{ID = 1, name = "Terraforming Mars", description = "Dit is een board spel.", minPlayers = 4, maxPlayers = 15 },
            new Boardgame{ID = 2, name = "Brass Birmingham", description = "Dit is een board spel.", minPlayers = 1, maxPlayers = 4 },
            new Boardgame{ID = 3, name = "Twilight Struggle", description = "Dit is een board spel.", minPlayers = 2, maxPlayers = 10 }
        };

        public IEnumerable<Boardgame> GetAllBoardGames()
        {
            return boardgames;
        }

        public IHttpActionResult GetBoardgame(int id)
        {
            var boardgame = boardgames.FirstOrDefault(p => p.ID == id);
            if (boardgame == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(boardgame);
            }
        }

    }
}
