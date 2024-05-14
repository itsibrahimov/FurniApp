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
    public class OurTeamManager : IOurTeamService
    {
        IOurTeamDal _ourTeamDal;

        public OurTeamManager(IOurTeamDal ourTeamDal)
        {
            _ourTeamDal = ourTeamDal;
        }

        public void GetBYID(int id)
        {
            _ourTeamDal.GetById(id);
        }

        public OurTeam GetByID(int id)
        {
            return _ourTeamDal.GetById(id);
        }

        public List<OurTeam> GetList()
        {
            return _ourTeamDal.List();
        }

        public void TAdd(OurTeam t)
        {
            _ourTeamDal.Add(t);
        }

        public void TRemove(OurTeam t)
        {
            _ourTeamDal.Remove(t);
        }

        public void TUpdate(OurTeam t)
        {
            _ourTeamDal.Update(t);
        }
    }
}
