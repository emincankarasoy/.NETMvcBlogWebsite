using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogManager
    {
        private Repository<Blog> repositoryBlog = new Repository<Blog>();

        public List<Blog> getAll()
        {
            return repositoryBlog.List();
        }
    }
}
