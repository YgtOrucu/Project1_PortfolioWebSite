using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using ResumeProjectDemo.Models.ViewModelForAboutArea;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersAbout:ViewComponent
    {
        private readonly PortfolioWebSiteContext _context;

        public UsersAbout(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var modelsForAbout = new ModelsForAboutArea
            {
                Abouts = _context.Abouts.FirstOrDefault(),
                Experiences = _context.Experiences.Take(2).ToList(),
                Educations = _context.Educations.ToList()
            };

            return View("~/Views/Shared/UsersViewComponent/UsersAbout.cshtml", modelsForAbout);
        }
    }
}
