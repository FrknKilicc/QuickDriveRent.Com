using Microsoft.AspNetCore.Mvc;

namespace QuickDriveRentComWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
