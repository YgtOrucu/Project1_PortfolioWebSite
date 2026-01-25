using Microsoft.AspNetCore.Mvc;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersHead:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/UsersViewComponent/UsersHead.cshtml");
        }
    }
}
