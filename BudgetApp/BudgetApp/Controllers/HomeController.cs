using BudgetApp.Persistance.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace BudgetApp.Controllers
{
    public class HomeController : Controller
    {
        private IList<SummaryView> _summarys;

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
            TempLoadData();
            return Json(_summarys, JsonRequestBehavior.AllowGet);
        }

        private void TempLoadData()
        {
            _summarys = new List<SummaryView>
            {
                new SummaryView
                {
                    Name = "Mike",
                    TotalBudget = 67
                },
                new SummaryView
                {
                    Name ="Test1",
                    TotalBudget = 57
                },
                new SummaryView
                {
                    Name = "Test2",
                    TotalBudget = 87
                }

            };
        }
       
    }
}