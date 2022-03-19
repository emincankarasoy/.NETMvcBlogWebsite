using BusinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager();
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
            var blogList = blogManager.getAll();
            return PartialView(blogList);
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
        
        public ActionResult BlogDetails()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult BlogCover() 
        {
            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult BlogDetailsContent()
        {
            return PartialView();
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }

            
    }
}