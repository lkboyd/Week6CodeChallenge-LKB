using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week6CodeChallenge_LKB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())            
                return PartialView();                       
            
                return View();            
        }

        public ActionResult Careers()
        {
            return PartialView();
        }

        public ActionResult About()
        {
            return PartialView();
        }

        public ActionResult Work()
        {
            return PartialView();
        }
       
        
        [HttpGet]
        public ActionResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Contact(Models.Week6Contacts contactForm)
        {
            Models.sp6LauraEntities db = new Models.sp6LauraEntities();
            db.Week6Contacts.Add(contactForm);
            db.SaveChanges();
            return Content("Thank you for getting in touch with us!  We will get back to you as soon as possible!");
        }
    }
}