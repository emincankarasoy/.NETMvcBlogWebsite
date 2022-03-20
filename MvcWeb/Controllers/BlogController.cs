using BusinessLayer.Concrete;
using PagedList;
using PagedList.Mvc;
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
            var postFirst = blogManager.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 2);
            var postSecond = blogManager.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 3);
            var postThird = blogManager.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 4);
            var postFourth = blogManager.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 1);
            var postFifth = blogManager.GetAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 5);

            ViewBag.postTitleFirst = postFirst.Select(x => x.BlogTitle).FirstOrDefault();
            ViewBag.postImageFirst = postFirst.Select(x => x.BlogImage).FirstOrDefault();
            ViewBag.postDateFirst  = postFirst.Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitleSecond = postSecond.Select(x => x.BlogTitle).FirstOrDefault();
            ViewBag.postImageSecond = postSecond.Select(x => x.BlogImage).FirstOrDefault();
            ViewBag.postDateSecond  = postSecond.Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitleThird = postThird.Select(x => x.BlogTitle).FirstOrDefault();
            ViewBag.postImageThird = postThird.Select(x => x.BlogImage).FirstOrDefault();
            ViewBag.postDateThird  = postThird.Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitleFourth = postFourth.Select(x => x.BlogTitle).FirstOrDefault();
            ViewBag.postImageFourth = postFourth.Select(x => x.BlogImage).FirstOrDefault();
            ViewBag.postDateFourth = postFourth.Select(x => x.BlogDate).FirstOrDefault();

            ViewBag.postTitleFifth = postFifth.Select(x => x.BlogTitle).FirstOrDefault();
            ViewBag.postImageFifth = postFifth.Select(x => x.BlogImage).FirstOrDefault();
            ViewBag.postDateFifth = postFifth.Select(x => x.BlogDate).FirstOrDefault();
            ViewBag.postCategoryFifth = postFifth.Select(x => x.Category.CategoryName).FirstOrDefault();

            return PartialView();
        }
        [ChildActionOnly]
        public PartialViewResult BlogList(int page = 1)
        {
            var blogList = blogManager.GetAll().ToPagedList(page,6);
            return PartialView(blogList);
        }
        [ChildActionOnly]
        public PartialViewResult NewBlogs() 
        {
            return PartialView();
        }
        public ActionResult BlogDetails()
        {

            return View();
        }
        [ChildActionOnly]
        public PartialViewResult BlogCover(int id) 
        {
            var blogDetailsContent = blogManager.GetBlogByID(id);
            return PartialView(blogDetailsContent);
        }
        [ChildActionOnly]
        public PartialViewResult BlogDetailsContent(int id)
        {
            var blogDetailsContent = blogManager.GetBlogByID(id);
            return PartialView(blogDetailsContent);
        }
        public ActionResult BlogByCategory()
        {
            return View();
        }    
    }
}