using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult FeaturedBlogs()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult BlogList()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult NewBlogs() 
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult MailSubscribe() 
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}