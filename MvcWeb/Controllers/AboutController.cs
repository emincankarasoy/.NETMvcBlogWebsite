using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class AboutController : Controller
    {
        private AboutManager aboutManager = new AboutManager();
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult Footer()
        {
            var abouts = aboutManager.GetAll();
            return PartialView(abouts);
        }
        [ChildActionOnly]
        public PartialViewResult MeetTheTeam()
        {
            return PartialView();
        }
    }
}