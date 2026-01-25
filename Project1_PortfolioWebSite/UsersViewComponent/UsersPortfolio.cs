using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using ResumeProjectDemo.Models.ViewModelForAboutArea;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersPortfolio:ViewComponent
    {
        private readonly PortfolioWebSiteContext _context;

        public UsersPortfolio(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Portfolios.ToList();
            return View("~/Views/Shared/UsersViewComponent/UsersPortfolio.cshtml", values);
        }
    }
}
