using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcWeb.Controllers
{
    public class CommentController : Controller
    {
        CommentManager commentManager = new CommentManager();
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult CommentList(int id)
        {
            var commentList = commentManager.GetCommentsByBlog(id);
            return PartialView(commentList);
        }
        [ChildActionOnly]
        [HttpGet]
        public PartialViewResult LeaveComment() 
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult LeaveComment(int id,Comment c)
        {
            c.CommentDateTime = DateTime.Now;
            c.BlogID = id;
            commentManager.CommentAdd(c);
            return PartialView();
        }
    }
}