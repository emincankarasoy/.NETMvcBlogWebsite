using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repositoryComment = new Repository<Comment>();
        public List<Comment> GetAll()
        {
            return repositoryComment.List();
        }
        public List<Comment> GetCommentsByBlog(int id)
        {
            return repositoryComment.List(x => x.BlogID == id);
        }
        public int CommentAdd(Comment c)
        {
            if(CheckCommentConditions(c))
            {
                return -1;
            }
            return repositoryComment.Insert(c);
        }
        private bool CheckCommentConditions(Comment c)
        {
            if(c.CommentText.Length <= 4 || c.CommentText.Length > 500 || c.UserName.ToString() != " " || c.UserMail.ToString() != " " || c.UserName.Length < 5)
            {
                return false;
            }
            return true;
        }

    }
}
