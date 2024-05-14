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
    public class CartManager : ICartService
    {
        ICartDal _cartDal;

        public CartManager(ICartDal cartDal)
        {
            _cartDal = cartDal;
        }

        public void GetBYID(int id)
        {
        }

        public Cart GetByID(int id)
        {
            return _cartDal.GetById(id);
        }

        public List<Cart> GetList()
        {
            return _cartDal.List();
        }

        public void TAdd(Cart t)
        {
            _cartDal.Add(t);
        }

        public void TRemove(Cart t)
        {
            _cartDal.Remove(t);
        }

        public void TUpdate(Cart t)
        {
            _cartDal.Update(t);
        }
    }
}
