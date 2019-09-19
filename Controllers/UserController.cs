using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAuctioningSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly SecureOnlineActioningSystemEntities1 _db = new SecureOnlineActioningSystemEntities1();
        // GET: User
        /* this action will return either sign up or login
         * view according to that formType parameter
         * and which type of user is trying to signup "admin",
         * "seller" or "customer"
         */
        public ActionResult Index(string formType,string userType)
        {
            ViewBag.userType = userType;
            return formType.Equals("login") ? View() : View("signup");
        }

        [HttpPost]
        public ActionResult Signup(User user)
        {
            if (ModelState.IsValid)
            {
                _db.Users.Add(user);
                _db.SaveChanges();
                Session["currentUser"] = user.id;
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json("Error", JsonRequestBehavior.AllowGet);
            }
        }
    }
}