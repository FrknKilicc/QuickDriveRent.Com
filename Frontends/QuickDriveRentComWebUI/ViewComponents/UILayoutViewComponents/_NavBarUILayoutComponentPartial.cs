using Microsoft.AspNetCore.Mvc;

namespace QuickDriveRentComWebUI.ViewComponents.UILayoutViewComponents
{
    public class _NavBarUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
