using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using ResumeProjectDemo.Models.ViewModelForAboutArea;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersTestimonial:ViewComponent
    {
        private readonly PortfolioWebSiteContext _context;

        public UsersTestimonial(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Testimonials.ToList();
            return View("~/Views/Shared/UsersViewComponent/UsersTestimonial.cshtml", values);
        }
    }
}
