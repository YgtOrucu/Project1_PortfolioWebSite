using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersSkills:ViewComponent
    {
        private readonly PortfolioWebSiteContext _context;
        public UsersSkills(PortfolioWebSiteContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke()
        {
            var values = _context.Skills.ToList();
            return View("~/Views/Shared/UsersViewComponent/UsersSkills.cshtml", values);
        }
    }
}
