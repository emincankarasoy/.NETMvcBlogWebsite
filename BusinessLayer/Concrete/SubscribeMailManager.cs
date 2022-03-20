using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail> repositorySubscribeMail = new Repository<SubscribeMail>();
        public int Add(SubscribeMail parameter)
        {
            if(parameter.Mail.Length <= 10 || parameter.Mail.Length > 50)
            {
                return -1;
            }
            return repositorySubscribeMail.Insert(parameter);
        }
    }
}
