using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userdal;

        public UserManager(IUserDal userdal)
        {
            _userdal = userdal;
        }

        public void GetBYID(int id)
        {
            _userdal.GetById(id);
        }

        public User GetByID(int id)
        {
            return _userdal.GetById(id);
        }

        public List<User> GetList()
        {
            return _userdal.List();
        }

        public void TAdd(User t)
        {
           _userdal.Add(t);
        }

        public void TRemove(User t)
        {
            _userdal.Remove(t);
        }

        public void TUpdate(User t)
        {
            _userdal.Update(t);
        }
    }
}
