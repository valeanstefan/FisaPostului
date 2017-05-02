using FisaPostului.Domain.Repository;
using FisaPostului.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FisaPostului.Controllers
{
    public class HomeController : Controller
    {
        private ObjectToJsonHelper _jsonHelper = new ObjectToJsonHelper();
        private IDisciplinaManager _disciplinaManager;
        private IProgramManager _programManager;
        private IUserManager _userManager;

        public HomeController(IDisciplinaManager disciplinaManager, IProgramManager programManager, IUserManager userManager)
        {
            _userManager = userManager;
            _disciplinaManager = disciplinaManager;
            _programManager = programManager;
        }

        // GET: Home
        public ActionResult Index()
        {
            var users = _userManager.GetAllUsers();
            List<String> jsons = new List<String>();
            foreach(var user in users)
            {
                jsons.Add(_jsonHelper.ToJson(user));
            }
            String all="";
            foreach(var js in jsons)
            {
                all += js.ToString();
            }

            ViewBag.Jsons = all;
            return View();
        }
    }
}