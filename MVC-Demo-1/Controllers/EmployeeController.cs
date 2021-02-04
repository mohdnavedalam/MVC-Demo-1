using MVC_Demo_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Demo_1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        
        public ActionResult Create(int departmentID)
        {
            var model = new Employee();
            model.DepartmentID = departmentID;
            return View(model);
        }

        Database1Entities db = new Database1Entities();

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var department = db.Departments.Single(d => d.Id == employee.DepartmentID);
                department.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Details", "Home", new { id = employee.DepartmentID });
            }

            return View(employee);
        }
    }
}