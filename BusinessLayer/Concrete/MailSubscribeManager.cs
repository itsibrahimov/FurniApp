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
    public class MailSubscribeManager : IMailSubscribeService
    {
        IMailSubscribeDal _mailsubscribeDal;

        public MailSubscribeManager(IMailSubscribeDal mailsubscribeDal)
        {
            _mailsubscribeDal = mailsubscribeDal;
        }

        public void GetBYID(int id)
        {
            _mailsubscribeDal.GetById(id);
        }

        public MailSubscribe GetByID(int id)
        {
            return _mailsubscribeDal.GetById(id);
        }

        public List<MailSubscribe> GetList()
        {
           return _mailsubscribeDal.List();
        }

        public void TAdd(MailSubscribe t)
        {
             _mailsubscribeDal.Add(t);
        }

        public void TRemove(MailSubscribe t)
        {
            _mailsubscribeDal.Remove(t);
        }

        public void TUpdate(MailSubscribe t)
        {
            _mailsubscribeDal.Update(t);
        }
    }
}
