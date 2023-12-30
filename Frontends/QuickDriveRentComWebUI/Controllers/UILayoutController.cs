using Microsoft.AspNetCore.Mvc;

namespace QuickDriveRentComWebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
