using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TypeRacerWebPageAndAPI.Models
{
    public class UserStatisticsModel
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public int PlayedGames { get; set; }

        public UserStatisticsModel(string Username)
        {
            this.Username = Username;
            this.PlayedGames = 0;
        }

        public UserStatisticsModel() { }
    }
}