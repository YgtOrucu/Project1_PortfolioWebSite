using Microsoft.AspNetCore.Mvc;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersScript: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/UsersViewComponent/UsersScript.cshtml");
        }
    }
}
