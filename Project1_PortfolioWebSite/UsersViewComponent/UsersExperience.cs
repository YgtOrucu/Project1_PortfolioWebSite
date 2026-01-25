using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using ResumeProjectDemo.Models.ViewModelForAboutArea;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersExperience:ViewComponent
    {
        private readonly PortfolioWebSiteContext _context;

        public UsersExperience(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Experiences.ToList();
            return View("~/Views/Shared/UsersViewComponent/UsersExperience.cshtml", values);
        }
    }
}
