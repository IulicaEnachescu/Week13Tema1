using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplicationApp17._01.Models;

namespace WebApplicationApp17._01.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        private readonly StudentData studentData;
        public StudentsController()
        {
            this.studentData = new StudentData();

        }
        public ActionResult Index()
        {
            var students = this.studentData.GetStudents();
            return View(students);
        }
        public ActionResult ById(int id)
        {
            var u = this.studentData.GetStudent(id);
            return this.View(u);
        }
    }
}
