using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Students.Models;

namespace Students.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(1, "seth", "quaye", "male", 30),
                new Student(2, "zach", "ballard", "male", 26),
            };
            return View(students);
        }
    }
}