using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Students.Models;

namespace Students.Controllers
{
    public class UsersController : Controller
    {
        
        [HttpGet]
        public ActionResult Hello()
        {
            if (Request.Cookies["name"] != null)
            {
                string name = Request.Cookies["name"].Value;

                ViewBag.Name = name;
            }
            
            return View();
        }

        [HttpPost]
        public ActionResult Hello(User newUser)
        {
            HttpCookie aCookie = new HttpCookie("name");
            aCookie.Value = newUser.Name;
            Response.Cookies.Add(aCookie);

            return RedirectToAction("Hello");
        }
    }
}