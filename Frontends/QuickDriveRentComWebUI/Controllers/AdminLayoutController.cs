using Microsoft.AspNetCore.Mvc;

namespace QuickDriveRentComWebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult AdminHeaderPartial()
        {
            return PartialView();
        }
        public PartialViewResult AdminNavBarPartial()
        {
            return PartialView();
        }
    }
}
