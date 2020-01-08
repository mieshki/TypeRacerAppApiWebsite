using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TypeRacerWebPageAndAPI.Models;

namespace TypeRacerWebPageAndAPI.Controllers
{
    [RoutePrefix("api/highscores")]
    public class HighscoresController : ApiController
    {
        [HttpGet]
        public List<HighscoreModel> GetAllHighscores()
        {
            return HomeController.db.allHighscores.OrderBy(o => o.WordsPerMinute).ToList();
        }

        [HttpPost]
        public void AddHighscore([FromBody] HighscoreModel score)
        {
            HighscoreModel temp = new HighscoreModel();

            temp.Player = score.Player;
            temp.WordsPerMinute = score.WordsPerMinute;
            temp.TimeInSeconds = score.TimeInSeconds;
            temp.Map = score.Map;

            HomeController.db.allHighscores.Add(temp);
            HomeController.db.SaveChanges();
        }

    }
}
