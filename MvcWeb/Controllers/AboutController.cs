using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            return PartialView();
        }
    }
}