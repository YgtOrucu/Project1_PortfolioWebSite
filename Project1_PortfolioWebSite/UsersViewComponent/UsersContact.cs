using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using ResumeProjectDemo.Models.ViewModelForAboutArea;

namespace Project1_PortfolioWebSite.UsersViewComponent
{
    public class UsersContact:ViewComponent
    {
        private readonly PortfolioWebSiteContext _context;

        public UsersContact(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _context.Contacts.FirstOrDefault();
            return View("~/Views/Shared/UsersViewComponent/UsersContact.cshtml", values);
        }
    }
}
