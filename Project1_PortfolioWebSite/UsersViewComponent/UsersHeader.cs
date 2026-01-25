using Microsoft.AspNetCore.Mvc;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersHeader:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/UsersViewComponent/UsersHeader.cshtml");
        }
    }
}
