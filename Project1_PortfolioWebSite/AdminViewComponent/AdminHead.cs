using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace Project1_PortfolioWebSite.AdminViewComponent
{
    public class AdminHead : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/AdminViewComponent/AdminHead.cshtml");
        }
    }
}
