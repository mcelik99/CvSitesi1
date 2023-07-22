using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core_Project.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }
        
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.v = values.Name + " " + values.SurName;

           
            //string api = "e025f92c1dd427531cad04c8c43ca9d3";
            //string url = "http://api.openweathermap.org/data/2.5/weather?q=London,uk&APPID=" + api;

            //using (HttpClient client = new HttpClient())
            //{
            //    HttpResponseMessage response = await client.GetAsync(url);

            //    if (response.IsSuccessStatusCode)
            //    {
            //        string json = await response.Content.ReadAsStringAsync();
            //        JObject data = JObject.Parse(json);

            //        double kelvinTemperature = (double)data["main"]["temp"];
            //        double celsiusTemperature = kelvinTemperature - 273.15;
            //        string temperatureInCelsius = celsiusTemperature.ToString("0.##");

            //        ViewBag.v5 = temperatureInCelsius;
            //    }
            //}

            //Statitics
            Context c = new Context();
            ViewBag.v1 = c.WriterMessages.Where(x=> x.Reciever == values.Email).Count();
            ViewBag.v2 = c.Announcements.Count();
            ViewBag.v3 = c.Users.Count();
            ViewBag.v4 = c.Skills.Count();

            return View();
        }
    }
}
