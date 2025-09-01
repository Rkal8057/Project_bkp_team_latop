using Assign_1.Models;
using System;
using System.Web.Mvc;
using System.Diagnostics;
using System.Web;
using System.Linq;
using Microsoft.Ajax.Utilities;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace Assign_1.Controllers
{
    public class HomeController : Controller{
        private DataContext db = new DataContext();

        [HttpGet]
        public ActionResult Index()
        {
            if (TempData["InsertMessage"] != null) 
            {
                ViewBag.InsertMessage = TempData["InsertMessage"].ToString();
            }

            var data = db.Users.ToList();
            ViewBag.userArrayData = data;
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(User user)
        {
            if (user != null)
            {
                db.Users.Add(user);
                db.SaveChanges();
                TempData["InsertMessage"] = "Created a new user successfully.";
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditUser(int? userId =  null)
        {
            Debug.WriteLine("editing user with ID: " + userId);
            if (userId == null)
            {
                TempData["InsertMessage"] = "id is required!!!";
                return RedirectToAction("Index");
            }
            var user = db.Users.Find(userId);
            if (user == null){
                TempData["InsertMessage"] = "User not found.";
                RedirectToAction("Index");
            }
            
            return PartialView("_EditUser", user);
        }

        public ActionResult UpdatedUser( User user)
        {
            Debug.WriteLine("UPDATED user with ID: ");

            if (user == null){
                TempData["InsertMessage"] = "User Profile did not updated successfully!!";
            }
            else
            {
                db.Users.AddOrUpdate(user);
                db.SaveChanges();
                TempData["InsertMessage"] = "User profile updated successfully";
            }
            return RedirectToAction("Index");
        }

        
        public ActionResult DeleteUser(int? userId = null)
        {
            Debug.WriteLine("Deleting user with ID: " + userId);

            if (userId == null){
                 ViewBag.InsertMessage = "id is required!!!";
            }
            
            var user = db.Users.Find(userId);
            if (user != null){
                db.Users.Remove(user);
                db.SaveChanges();
                TempData["InsertMessage"] = "Delete a user successfully.";
            }else{
                TempData["InsertMessage"] = "User not found.";
            }

            return RedirectToAction("Index");
        }
    }
}
