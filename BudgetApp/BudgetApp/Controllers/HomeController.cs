using BudgetApp.Persistance.Models;
using BudgetApp.Persistance.Logic;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BudgetApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserLogic _userLogic;

        public HomeController()
        {
        }

        public HomeController(IUserLogic userLogic)
        {
            _userLogic = userLogic;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        
        public ActionResult LoadAllUsersSummary()
        {
            var summary = _userLogic.LoadAllUsersSummary();
            return Json(summary, JsonRequestBehavior.AllowGet);
        }       
    }
}