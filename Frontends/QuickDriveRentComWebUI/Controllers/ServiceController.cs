using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using QuickDriveRentCom.Dto.ServiceDtos;

namespace QuickDriveRentComWebUI.Controllers
{
    public class ServiceController : Controller
    {
    

        public IActionResult Index()
        {
            return View();
        }
    }
}
