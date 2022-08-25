using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AssigmnetMvc.Models;

namespace AssigmnetMvc.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult AddorEdit()
        {
            User userModel = new User();
            
            return View(userModel);
        }

        public ActionResult Index(User userModel)
        {
            using(DbModel dbModel=new DbModel())
            {
               dbModel.Users.Add(userModel);
                dbModel.SaveChanges();
            }
           ModelState.Clear();
            ViewBag.SucessMessage = "";
            return View("AddorEdit", new User());
        }
    }
}