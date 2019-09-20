using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineAuctioningSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly OnlineAuctioning _db = new OnlineAuctioning();
        // GET: Home
        public ActionResult Index()
        {
            var result = _db.Products.Where(p => p.isDeleted == false && isDateReached(p.endDate)).ToList();
             return View(result);
        }


        public bool isDateReached(DateTime? endDateTime)
        {
            if (endDateTime.Value.Day <= DateTime.Now.Day
                &&
                endDateTime.Value.Month <= DateTime.Now.Month
                &&
                endDateTime.Value.Year <= DateTime.Now.Year
               )
            {
                return true;
            }else
            {
                return false;
            }
        }
        
    }
}