using Login.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Login.Controllers
{
    public class LoginController : Controller
    {
        UserDb db = new UserDb();
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            if (IsValid(user))
            {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                string data = db.users.Where(x => x.UserName == user.UserName).FirstOrDefault().Role;
                if (data == "Mentor")
                {
                  return   RedirectToAction("MentorView", "Admin");
                }
                else 
                {
                  return  RedirectToAction("Index", "Admin");
                }
            }
            else
            {
               return  RedirectToAction("Login", "Login");
            }
        }
      
        private bool IsValid(User user)
        {
            //Db Work
           User result = db.users.ToList().FirstOrDefault(m => m.UserName == user.UserName && m.PassWord == user.PassWord);
            
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login","Login");
        }

       
    }
}