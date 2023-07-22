﻿using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Project.ViewComponents.About
{
    public class AboutList : ViewComponent
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        public IViewComponentResult Invoke()
        {
            var values = aboutManager.TGetList();
            return View(values);
        }

    }
}
