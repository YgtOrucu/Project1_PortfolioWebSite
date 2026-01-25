using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using Project1_PortfolioWebSite.Entities;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersFeature:ViewComponent
    {
        private readonly PortfolioWebSiteContext _context;

        public UsersFeature(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Abouts.Select(x => new About
            {
                NameSurname = x.NameSurname,
                Title = x.Title,
                ImageUrl = x.ImageUrl
            }).FirstOrDefault();

            return View("~/Views/Shared/UsersViewComponent/UsersFeature.cshtml", values);
        }
    }
}
