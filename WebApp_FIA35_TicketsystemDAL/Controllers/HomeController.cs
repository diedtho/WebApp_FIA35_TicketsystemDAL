using Microsoft.AspNetCore.Mvc;

namespace WebApp_FIA35_TicketsystemDAL.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
    }
}
