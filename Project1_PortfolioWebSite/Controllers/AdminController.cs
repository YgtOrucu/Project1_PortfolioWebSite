using Microsoft.AspNetCore.Mvc;
using Project1_PortfolioWebSite.Context;
using Project1_PortfolioWebSite.Entities;
using Project1_PortfolioWebSite.Models.ContactİnfoForAdminPage;

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
        #endregion

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

        #region CategoryOperation

        #region CategoryList
        public IActionResult Category()
        {
            var values = _context.Categories.ToList();
            return View(values);
        }

        #endregion

        #region CategoryAdd
        public IActionResult CategoryAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryAdd(Category c)
        {
            _context.Categories.Add(c);
            _context.SaveChanges();
            return RedirectToAction("Category");
        }
        #endregion

        #region CategoryEditAndUpdate

        public IActionResult CategoryEdit(int id)
        {
            var values = _context.Categories.Find(id);
            return View("CategoryEdit", values);
        }

        [HttpPost]
        public IActionResult CategoryUpdate(Category c)
        {
            _context.Categories.Update(c);
            _context.SaveChanges();
            return RedirectToAction("Category");
        }
        #endregion


        #endregion

        #region ContactOperations

        #region AboutList
        public IActionResult Contact()
        {
            var values = new ContactInfoForAdmin
            {
                Contact = _context.Contacts.Take(2).ToList(),
                ContactList = _context.Contacts.ToList()
            };
            return View(values);
        }
        #endregion

        #region ContactAdd
        [HttpGet]
        public IActionResult ContactAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
        {
            _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("Contact");
        }
        #endregion

        #region ContactDelete
        public IActionResult ContactDelete(int id)
        {
            var values = _context.Contacts.Find(id);
            _context.Contacts.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Contact");
        }
        #endregion

        #region ContactWithAndUpdate
        public IActionResult ContactEdit(int id)
        {
            var values = _context.Contacts.Find(id);
            return View("ContactEdit", values);
        }

        [HttpPost]
        public IActionResult ContactUpdate(Contact contact)
        {
            _context.Contacts.Update(contact);
            _context.SaveChanges();
            return RedirectToAction("Contact");
        }
        #endregion

        #endregion

        #region EducationOperations

        #region EducationList
        public IActionResult Education()
        {
            var values = _context.Educations.ToList();
            return View(values);
        }

        #endregion

        #region EducationAdd
        [HttpGet]
        public IActionResult EducationAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult EducationAdd(Education education)
        {
            _context.Educations.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Education");
        }
        #endregion

        #region EducationDelete
        public IActionResult EducationDelete(int id)
        {
            var values = _context.Educations.Find(id);
            _context.Educations.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Education");
        }
        #endregion

        #region EducationWithAndUpdate
        public IActionResult EducationEdit(int id)
        {
            var values = _context.Educations.Find(id);
            return View("EducationEdit", values);
        }

        [HttpPost]
        public IActionResult EducationUpdate(Education education)
        {
            _context.Educations.Update(education);
            _context.SaveChanges();
            return RedirectToAction("Education");
        }
        #endregion

        #endregion
    }
}