using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _aboutdal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutdal = aboutDal;

        }

        public About TGetById(int id)
        {
            return _aboutdal.GetById(id);
        }

        public void TAdd(About t)
        {
            _aboutdal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutdal.Delete(t);
        }

        public List<About> TGetList()
        {
            return _aboutdal.GetList();
        }

        public void TUpdate(About t)
        {
            _aboutdal.Update(t);
        }

        public List<About> TGetListByFilter()
        {
            throw new NotImplementedException();
        }
    }
}
