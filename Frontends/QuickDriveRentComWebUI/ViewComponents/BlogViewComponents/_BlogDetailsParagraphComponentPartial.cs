using Microsoft.AspNetCore.Mvc;

namespace QuickDriveRentComWebUI.ViewComponents.BlogViewComponents
{
    public class _BlogDetailsParagraphComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
