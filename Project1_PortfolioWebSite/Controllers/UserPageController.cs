using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using Project1_PortfolioWebSite.Entities;

namespace Project1_PortfolioWebSite.Controllers
{
    public class UserPageController : Controller
    {
        private readonly PortfolioWebSiteContext _context;

        public UserPageController(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        public IActionResult HomePage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            message.SendDate = DateTime.Now;
            _context.Messages.Add(message);
            _context.SaveChanges();
            return View();
        }

        public IActionResult DownloadCV()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/files/MuhsinYiğitÖrücüCV.pdf");
            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/pdf", "Yigit_CV.pdf");
        }
    }
}
