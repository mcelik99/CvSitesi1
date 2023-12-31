﻿using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;

namespace Core_Project.ViewComponents.Contact
{
    public class ContactDetails : ViewComponent
    {
        ContactManager contactManager = new ContactManager (new EfContactDal());

        public IViewComponentResult Invoke()
        {
            var values = contactManager.TGetList();
            return View(values);
        }
    }
}
