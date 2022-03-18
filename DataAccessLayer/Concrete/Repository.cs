using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private Context context = new Context();
        private DbSet<T> _object;

        public Repository()
        {
            _object = context.Set<T>();
        }

        public int Delete(T parameter)
        {
            _object.Remove(parameter);
            return context.SaveChanges();
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public int Insert(T parameter)
        {
            _object.Add(parameter);
            return context.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public int Update(T parameter)
        {
            return context.SaveChanges();
        }
    }
}
