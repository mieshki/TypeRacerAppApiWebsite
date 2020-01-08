using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TypeRacerWebPageAndAPI.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {

        }

        public DbSet<AccountModel> allAccounts { get; set; }
        public DbSet<UserStatisticsModel> allUsersStatistics { get; set; }
        public DbSet<HighscoreModel> allHighscores { get; set; }

    }
}