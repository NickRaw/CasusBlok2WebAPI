using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CasusBlok2WebAPI.Models
{
    public class Boardgame
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int minPlayers { get; set; }
        public int maxPlayers { get; set; }
    }
}