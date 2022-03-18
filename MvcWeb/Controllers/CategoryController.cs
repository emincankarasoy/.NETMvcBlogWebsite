using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryManager categoryManager = new CategoryManager();
        public ActionResult Index()
        {
            var categoryvalues = categoryManager.GetAll();
            return View(categoryvalues);
        }
    }
}