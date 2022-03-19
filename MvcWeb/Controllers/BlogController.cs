﻿using BusinessLayer.Concrete;
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
            var postFirst = blogManager.getAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 2);
            var postSecond = blogManager.getAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 3);
            var postThird = blogManager.getAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 4);
            var postFourth = blogManager.getAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 1);
            var postFifth = blogManager.getAll().OrderByDescending(x => x.BlogID).Where(x => x.CategoryID == 5);

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