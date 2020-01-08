using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TypeRacerWebPageAndAPI.Models;

namespace TypeRacerWebPageAndAPI.Controllers
{
    public class HomeController : Controller
    {
        public static DatabaseContext db = new DatabaseContext();

        public static string Username { get; set; }
        public static string Password { get; set; }

        public ActionResult Index()
        {
            ViewBag.Message = "My own login page";
            return View();
        }

        public ActionResult Login(AccountModel model)
        {
            bool loginSuccessful = AccountController.LoginAccount_Helper(model);

            if (loginSuccessful)
            {
                Username = model.Username;
                Password = model.Password;

                ViewBag.Message = model.Username;
                ViewBag.PlayedCount = HomeController.db.allUsersStatistics.Single(a => a.Username == model.Username).PlayedGames;
                ViewBag.allScores = HomeController.db.allHighscores.ToList();

                return View("LoginSuccessful", model);
            }
            else
                return View("LoginFailed");
        }
    }
}