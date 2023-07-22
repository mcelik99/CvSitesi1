using BusinessLayer.Concrete;
using Core_Project.Areas.Writer.Models;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Authorize]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncementDal());
        public IActionResult Index()
        {
            var values=announcementManager.TGetList();
            return View(values);
        }

        public IActionResult AnnouncementDetails(int id)
        {
            Announcement announcement = announcementManager.TGetById(id);
            return View(announcement);
        }

        
    }
}
