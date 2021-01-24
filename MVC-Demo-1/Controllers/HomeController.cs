using System.Web.Mvc;
using MVC_Demo_1.Models;

namespace MVC_Demo_1.Controllers
{
    public class HomeController : Controller
    {
        Database1Entities db = new Database1Entities();

        public ActionResult Index()
        {
            var allDepartments = db.Departments;
            return View(allDepartments);
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
    }
}