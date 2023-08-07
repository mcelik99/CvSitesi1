using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Core_Project.Controllers
{
    public class DashboardController : Controller
    {
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            ViewBag.v1 = "Dashboard";
            ViewBag.v2 = "İstatistikler";
            ViewBag.v3 = "İstatistik Sayfası";
            return View();
        }
    }
}
