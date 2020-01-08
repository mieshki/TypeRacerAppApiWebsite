using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TypeRacerWebPageAndAPI.Models;

namespace TypeRacerWebPageAndAPI.Controllers
{
    public class RegisterController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Create new account!";
            return View();
        }

        public ActionResult CreateNewAccount(AccountModel account)
        {
            AccountController.RegisterAccount_Helper(account);

            return View("RegistrationSuccessful");
        }
    }
}