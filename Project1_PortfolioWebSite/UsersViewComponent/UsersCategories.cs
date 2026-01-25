using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using ResumeProjectDemo.Models.ViewModelForAboutArea;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersCategories:ViewComponent
    {
        private readonly PortfolioWebSiteContext _context;

        public UsersCategories(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Categories.ToList();
            return View("~/Views/Shared/UsersViewComponent/UsersCategories.cshtml", values);
        }
    }
}
