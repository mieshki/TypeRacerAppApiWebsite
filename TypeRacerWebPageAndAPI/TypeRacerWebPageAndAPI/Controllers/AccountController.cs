using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TypeRacerWebPageAndAPI.Models;

namespace TypeRacerWebPageAndAPI.Controllers
{
    [RoutePrefix("api/account")]
    public class AccountController : ApiController
    {
        public static bool LoginAccount_Helper(AccountModel account)
        {
            foreach (AccountModel acc in HomeController.db.allAccounts)
            {
                if (acc.Username == account.Username && acc.Username == account.Username)
                    return true;
            }

                return false;
        }

        [Route("login")]
        [HttpPost]
        public bool LoginAccount([FromBody] AccountModel account)
        {
            return LoginAccount_Helper(account);
        }

        public static void RegisterAccount_Helper(AccountModel account)
        {
            HomeController.db.allAccounts.Add(new AccountModel(account.Username, account.Password));
            HomeController.db.allUsersStatistics.Add(new UserStatisticsModel(account.Username));

            HomeController.db.SaveChanges();
        }

        [Route("register")]
        [HttpPost]
        public void RegisterAccount([FromBody] AccountModel account)
        {
            RegisterAccount_Helper(account);
        }

    }
}
