using Microsoft.AspNetCore.Mvc;

namespace WebApiAuctionMangementSystem.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
