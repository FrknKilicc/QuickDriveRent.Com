using Microsoft.AspNetCore.Mvc;

namespace QuickDriveRentComWebUI.Controllers
{
    public class AdminCarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
