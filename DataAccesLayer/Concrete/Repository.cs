using DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Context y = new Context();
        DbSet<T> _object;
        public Repository()
        {
            _object = y.Set<T>();
        }
        public void Add(T x)
        {
            var addedEntity = y.Entry(x);
            addedEntity.State = EntityState.Added;
            y.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> where)
        {
            return _object.FirstOrDefault(where);
        }

        public T GetById(int id)
        {
            return _object.Find(id);
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Remove(T x)
        {
            var removedEntity = y.Entry(x);
            removedEntity.State = EntityState.Deleted;
            y.SaveChanges();
        }

        public void Update(T x)
        {
            var updateEntity = y.Entry(x);
            updateEntity.State = EntityState.Modified;
            y.SaveChanges();
        }
    }
}

