using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using ResumeProjectDemo.Models.ViewModelForAboutArea;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersService:ViewComponent
    {
        private readonly PortfolioWebSiteContext _context;

        public UsersService(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Services.ToList();
            return View("~/Views/Shared/UsersViewComponent/UsersService.cshtml", values);
        }
    }
}
