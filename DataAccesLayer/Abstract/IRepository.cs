using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IRepository <T>
    {
        List<T> List ();
        void Add (T x);
        void Remove (T x);
        void Update (T x);
        T GetById (int id);
        List<T> List(Expression<Func<T,bool>> filter);
        T Find(Expression<Func<T,bool>> where);
    }
}
