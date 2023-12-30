using Microsoft.AspNetCore.Mvc;

namespace QuickDriveRentComWebUI.ViewComponents.UILayoutViewComponents
{
    public class _MainCoverUILayoutComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
