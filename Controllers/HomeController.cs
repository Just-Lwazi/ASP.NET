using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        StudentsEntities storeDb = new StudentsEntities();
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
        public ActionResult Registration()
        {

            return View();
        }
        // POST: /Home/Registration
        // Saves registering student 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration(Student_Information student_Information)
        {

            if (ModelState.IsValid)
            {
                storeDb.Student_Information.Add(student_Information);
                storeDb.SaveChanges();
                return RedirectToAction("ContactDetails","Registration");
            }
            return View(student_Information);
        }

        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LogIn(Student_Information student_Information)
        {
            if (ModelState.IsValid)
            {
                var details = (from userList in storeDb.Student_Information
                               where userList.Email == student_Information.Email && userList.Password == student_Information.Password
                               select new { userList.Email, userList.Password }).ToList();
                if (details.FirstOrDefault() != null)
                {
                    Session["Email"] = details.FirstOrDefault().Email;
                    Session["Password"] = details.FirstOrDefault().Password;

                }
            }
            else
            {
                ModelState.AddModelError("", "Invalid Account");
            }
            return View(student_Information);
        }
        //Shows list of students in Database
        public ActionResult Admin()
        {
            var student = storeDb.Student_Information.ToList();
            return View(student);
        }

        public ActionResult Delete(Student_Information student_Information)
        {
            var student = storeDb.Student_Information.Where(x => x.Email == x.Email).First();
            storeDb.Student_Information.Remove(student);
            storeDb.SaveChanges();

            return View("Admin");
        }
        public ActionResult Edit()
        {
            var student = storeDb.Student_Information.Where(x => x.Email == x.Email).First();
            return View(student);
        }
        [HttpPost]
        public ActionResult Edit(Student_Information model)
        {
            var student = storeDb.Student_Information.Where(x => x.Email == x.Email).First();
            student.Email = model.Email;
            student.Password = model.Password;
            return View(student);
        }


    }
}