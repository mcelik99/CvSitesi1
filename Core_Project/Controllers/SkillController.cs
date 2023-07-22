using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Windows.Markup;

namespace Core_Project.Controllers
{
    public class SkillController : Controller
    {

        SkillManager skillManager = new SkillManager(new EfSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.TGetList();
            
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddSkill( Skill skill) 
        {
            skillManager.TAdd(skill);
            return RedirectToAction("Index");
        }
        public IActionResult  DeleteSkill(int id)
        {
           var  values = skillManager.TGetById(id);
            skillManager.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {
            var values = skillManager.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill( Skill skill)
        {
            skillManager.TUpdate(skill);
            return RedirectToAction("Index");
        }
        
    }
}
