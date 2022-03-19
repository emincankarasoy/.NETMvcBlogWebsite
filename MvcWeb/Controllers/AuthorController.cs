using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult AuthorAbout()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult AuthorPopularPost()
        {
            return PartialView();
        }
    }
}