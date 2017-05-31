using FisaPostului.Domain.BusinessHandler.Contracts;
using FisaPostului.Domain.Models;
using FisaPostului.Domain.Repository;
using FisaPostului.Helpers;
using FisaPostului.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            var users = _userManager.GetAll();
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FisaViewModel model)
        {
            _jsonHelper.ToJson(model);
            if (ModelState.IsValid) { 

                ProgramDto program = new ProgramDto
                {
                    ciclu_studii = model.ciclu_studii,
                    departamentul = model.departamentul,
                    domeniu_studii = model.domeniu_studii,
                    facultatea = model.facultatea,
                    institutie_invatamant_superior = model.institutie_invatamant_superior,
                    specializarea = model.specializarea
                };

                DisciplinaDto disciplina = new DisciplinaDto
                {
                    an_studiu = model.an_studiu,
                    codul_disciplinei = model.codul_disciplinei,
                    denumirea_disciplinei = model.denumirea_disciplinei,
                    regimul_disciplinei = model.regimul_disciplinei,
                    semestru = model.semestru,
                    tip_evaluare = model.tip_evaluare,
                    titularul_activitati_aplicatii = model.titularul_activitati_aplicatii,
                    titular_activitati_curs = model.titular_activitati_curs
                };

                _disciplinaManager.Insert(disciplina);
                _programManager.Insert(program);                
            }

            return Json(model, JsonRequestBehavior.AllowGet);
        }
        
        public ActionResult List()
        {
            var listOfPrograms = _programManager.GetAll();
            return View(listOfPrograms);
        }

        public ActionResult ToJson(int id)
        {

            var program = _programManager.GetById(id);
          
            byte[] fileBytes = Encoding.ASCII.GetBytes(_jsonHelper.ToJson(program));
            string fileName = "output.json";

            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
        }

    }
}