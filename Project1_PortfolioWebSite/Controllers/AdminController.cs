using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using Project1_PortfolioWebSite.Entities;

namespace Project1_PortfolioWebSite.Controllers
{
    public class AdminController : Controller
    {
        private readonly PortfolioWebSiteContext _context;

        public AdminController(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        #region AboutOperations

        #region AboutList
        public IActionResult About()
        {
            var values = _context.Abouts.ToList();
            return View(values);
        }

        #endregion

        #region AboutAdd
        [HttpGet]
        public IActionResult AboutAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AboutAdd(About about)
        {
            _context.Abouts.Add(about);
            _context.SaveChanges();
            return RedirectToAction("About");
        }
        #endregion

        #region AboutDelete
        public IActionResult AboutDelete(int id)
        {
            var values = _context.Abouts.Find(id);
            _context.Abouts.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("About");
        }

        #region AboutWithAndUpdate
        public IActionResult AboutEdit(int id)
        {
            var values = _context.Abouts.Find(id);
            return View("AboutEdit", values);
        }

        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {
            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("About");
        }

        #endregion

        #endregion

        #endregion
    }
}
