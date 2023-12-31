﻿using BusinessLayer.Abstract;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class MessageManager : IMessageService
    {
        EfMessageDal _messageDal;

        public MessageManager(EfMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void TAdd(Message t)
        {
           _messageDal.Insert(t);
        }

        public void TDelete(Message t)
        {
            _messageDal.Delete(t);
        }

        public Message TGetById(int id)
        {
          return _messageDal.GetById(id);
        }

        public List<Message> TGetList()
        {
            return _messageDal.GetList();
        }

        public List<Message> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Message t)
        {
            throw new NotImplementedException();
        }
    }
}
