using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Project1_PortfolioWebSite.Context;

namespace Project1_PortfolioWebSite.AdminViewComponent
{
    public class AdminSidebar : ViewComponent
    {
        private readonly PortfolioWebSiteContext _portfolioWebSiteContext;

        public AdminSidebar(PortfolioWebSiteContext portfolioWebSiteContext)
        {
            _portfolioWebSiteContext = portfolioWebSiteContext;
        }

        public IViewComponentResult Invoke()
        {
            int messageReadCount = _portfolioWebSiteContext.Messages.Where(x => !x.IsRead).Count();
            return View("~/Views/Shared/AdminViewComponent/AdminSidebar.cshtml",messageReadCount);
        }
    }
}
