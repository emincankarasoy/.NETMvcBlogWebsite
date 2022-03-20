using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class AuthorController : Controller
    {
        BlogManager blogManager = new BlogManager(); 
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult AuthorAbout(int id)
        {
            var author = blogManager.GetBlogByID(id);
            return PartialView(author);
        }
        [ChildActionOnly]
        public PartialViewResult AuthorPopularPost()
        {
            return PartialView();
        }
    }
}