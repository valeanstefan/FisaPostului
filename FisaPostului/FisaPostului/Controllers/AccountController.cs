using FisaPostului.Domain.Models;
using FisaPostului.Domain.Repository;
using FisaPostului.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FisaPostului.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserManager _userManager;
        public AccountController (IUserManager userManager)
        {
            _userManager = userManager;
        }
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                UserDto user = new UserDto()
                {
                    email = model.Email,
                    first_name = model.FirstName,
                    last_name = model.LastName,
                    username = model.Username,
                    user_password = model.Password
                };

                _userManager.Insert(user);
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
               if(_userManager.IsUserValid(model.Username, model.Password))
                {
                    ViewBag.Username = model.Username;
                    return RedirectToAction("Index");
                }
                return View();
            }

            return View();
        }

    }
}