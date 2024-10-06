using StudentManagement2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentManagement2.Controllers
{
    public class LoginController : Controller
    {
        private StudinfoEntities db = new StudinfoEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        

        public ActionResult Index(user objchk)
        {
            
                    var obj = db.users.Where(a => a.username.Equals(objchk.username) && a.password.Equals(objchk.password)).FirstOrDefault();

                    if (obj != null)
                    {

                        Session["UserId"] = obj.id.ToString();

                        Session["Username"] = obj.username.ToString();

                        return RedirectToAction("Index","Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "The Username or Password is incorrect");
                        return View();
                    }


                


            
            
        }
        public ActionResult loggedin()
        {
            {
                if (Session["UserId"] != null)
                {
                    return RedirectToAction("loggedin","Login");
                }
                else
                { return View(); }
            }
        }
       
        

    }

}

            
            