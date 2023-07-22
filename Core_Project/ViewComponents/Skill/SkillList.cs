using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;

namespace Core_Project.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {

        SkillManager skillManager = new SkillManager(new EfSkillDal());

        public IViewComponentResult Invoke()
        {
            var values =skillManager.TGetList();
            return View(values);
        }
    }
}
