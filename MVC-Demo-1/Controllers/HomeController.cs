using System.Linq;
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

        public ActionResult Details(int id)
        {
            var selectedDepartment = db.Departments.Single(d => d.Id == id);

            ViewBag.Message = "Details";
            return View(selectedDepartment);
        }

        public ActionResult Create()
        {
            return View(new Department());
        }

        [HttpPost]
        public ActionResult Create(Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}