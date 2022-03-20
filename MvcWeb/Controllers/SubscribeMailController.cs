using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class SubscribeMailController : Controller
    {
        [HttpGet]
        [ChildActionOnly]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [HttpPost]
        [ChildActionOnly]
        public PartialViewResult AddMail(SubscribeMail parameter)
        {
            SubscribeMailManager subscribeMailManager = new SubscribeMailManager(); 
            subscribeMailManager.Add(parameter);
            return PartialView();
        }

    }
}