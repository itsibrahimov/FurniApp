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
    public class AdminManager : IAdminService
    {
        IAdminDal _admin;

        public AdminManager(IAdminDal admin)
        {
            _admin = admin;
        }

        public void GetBYID(int id)
        {
             _admin.GetById(id);
        }

        public Admin GetByID(int id)
        {
            return _admin.GetById(id);
        }

        public List<Admin> GetList()
        {
            return _admin.List();
        }

        public void TAdd(Admin t)
        {
            _admin.Add(t);
        }

        public void TRemove(Admin t)
        {
            _admin.Remove(t);
        }

        public void TUpdate(Admin t)
        {
            _admin.Update(t);
        }
    }
}
