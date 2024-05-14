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
    public class ShopManager : IShopService
    {
        IShopDal _shopDal;

        public ShopManager(IShopDal shopDal)
        {
            _shopDal = shopDal;
        }
        public List<Shop> GetList()
        {
           return _shopDal.List();
        }

        public void TAdd(Shop t)
        {
            _shopDal.Add(t);
        }

        public void TRemove(Shop t)
        {
            _shopDal.Remove(t);
        }

        public void TUpdate(Shop shop)
        {
            throw new NotImplementedException();
        }
        public void ShopStatusFalseSp(int id)
        {
            Shop shop = _shopDal.Find(x => x.ProductID == id);
            shop.ProductStatus = false;
            _shopDal.Update(shop);
        }
        public void ShopStatusTrueSp(int id)
        {
            Shop shop = _shopDal.Find(x => x.ProductID == id);
            shop.ProductStatus = true;
            _shopDal.Update(shop);
        }
        public void ShopUpdate(Shop shop)
        {
            _shopDal.Update(shop);
        }

        public Shop GetByID(int id)
        {
            return _shopDal.GetById(id);
        }
    }
}
