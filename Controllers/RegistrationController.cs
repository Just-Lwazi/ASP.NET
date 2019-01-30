using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Web;
using System.Web.Mvc;
using School.Models;

namespace School.Controllers
{
    public class RegistrationController : Controller
    {
        StudentsEntities storeDb = new StudentsEntities();
        // GET: Registration
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ContactDetails()     
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactDetails(ContactDetail contactDetails)
        {
            if (ModelState.IsValid)
            {
                storeDb.ContactDetails.Add(contactDetails);
                storeDb.SaveChanges();
                return RedirectToAction("GuardianDetails");
            }
            return View(contactDetails);
        }

        public ActionResult GuardianDetails()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult GuardianDetails(GuardianDetail guardian)
        {
            if (ModelState.IsValid)
            {
                storeDb.GuardianDetails.Add(guardian);
                storeDb.SaveChanges();
                return RedirectToAction("Course");
            }
            return View(guardian);
        }

        public ActionResult Course()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Course(Course course)
        {
            if (ModelState.IsValid)
            {
                storeDb.Courses.Add(course);
                storeDb.SaveChanges();
                return RedirectToAction("SchoolDetails");
            }
            return View(course);
        }
        public ActionResult SchoolDetails()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SchoolDetails(SchoolDetail school)
        {
            if (ModelState.IsValid)
            {
                storeDb.SchoolDetails.Add(school);
                storeDb.SaveChanges();
                return RedirectToAction("AfterSchool", "Registration");
            }
            return View(school);
        }
        public ActionResult AfterSchool()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AfterSchool(AfterSchool afterSchool)
        {
            if (ModelState.IsValid)
            {
                storeDb.AfterSchools.Add(afterSchool);
                storeDb.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(afterSchool);
        }

        public ActionResult Bursary()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Bursary(Bursary bursary)
        {
            if (ModelState.IsValid)
            {
                storeDb.Bursaries.Add(bursary);
                storeDb.SaveChanges();
                return RedirectToAction("Medical");
            }
            return View(bursary);
        }
        public ActionResult Medical()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Medical(Medical medical)
        {
            if (ModelState.IsValid)
            {
                storeDb.Medicals.Add(medical);
                storeDb.SaveChanges();
                return RedirectToAction("Upload");
            }
            return View(medical);
        }
        [HttpGet]
        public ActionResult AddNewRow()
        {
            return PartialView("_newRowPartial");
        }
        [HttpGet]
        public ActionResult Upload()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Upload(HttpPostedFileBase file)
        {
            string path = Server.MapPath("~/UploadedFiles/" + file.FileName); //setting location
            file.SaveAs(path); // saving file
            @ViewBag.Path = path; // passing file location to view after uploading

            return View();
        }

        public ActionResult Finished()
        {
            ViewBag.Message = "Your application is being processed. Elsenburg will keep in touch regarding your application.";
            return View();
        }
    }
}