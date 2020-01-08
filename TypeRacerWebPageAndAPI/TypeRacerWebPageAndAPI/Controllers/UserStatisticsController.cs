using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TypeRacerWebPageAndAPI.Models;

namespace TypeRacerWebPageAndAPI.Controllers
{
    [RoutePrefix("api/userstatistics")]
    public class UserStatisticsController : ApiController
    {
        [HttpPost]
        [Route("playedcount")]
        public int PlayedCount([FromBody] AccountModel account)
        {
            UserStatisticsModel acc = HomeController.db.allUsersStatistics.Single(o => o.Username == account.Username);
            if (acc != null)
                return acc.PlayedGames;
            else
                return 0;
        }

        [HttpPost]
        [Route("incrementplayedcount")]
        public void IncrementPlayedCount([FromBody] AccountModel account)
        {
            foreach (UserStatisticsModel actualUser in HomeController.db.allUsersStatistics)
                if (account.Username == actualUser.Username)
                    actualUser.PlayedGames++;
        }
    }
}
