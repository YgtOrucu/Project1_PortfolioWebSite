using Microsoft.AspNetCore.Mvc;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersFooter:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View("~/Views/Shared/UsersViewComponent/UsersFooter.cshtml");
        }
    }
}
