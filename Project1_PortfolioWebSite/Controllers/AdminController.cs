using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project1_PortfolioWebSite.Context;
using Project1_PortfolioWebSite.Entities;
using Project1_PortfolioWebSite.Models.ContactİnfoForAdminPage;
using Project1_PortfolioWebSite.Models.DashboardForAdminPage;

namespace Project1_PortfolioWebSite.Controllers
{
    public class AdminController : Controller
    {
        private readonly PortfolioWebSiteContext _context;

        public AdminController(PortfolioWebSiteContext context)
        {
            _context = context;
        }

        #region Dashboard
        public IActionResult Dashboard()
        {
            var model = new DashboardForAdminPage
            {
                TotalMessage = _context.Messages.Count(),
                ReadMessage = _context.Messages.Where(x => x.IsRead).Count(),
                UnReadMessage = _context.Messages.Where(x => !x.IsRead).Count(),
                TotalProject = _context.Portfolios.Count(),
                TotalCategory = _context.Categories.Count(),
                TotalTestimoial = _context.Testimonials.Count(),
                Testimonials = _context.Testimonials.OrderByDescending(x => x.TestimonialId).Take(3).ToList(),
                Messages = _context.Messages.OrderByDescending(x => x.SendDate).Take(3).ToList(),
                Portfolios = _context.Categories.GroupJoin(_context.Portfolios, c => c.CategoryId, p => p.CategoryId, (c, portfolios) => new CategoryProjectCountDto
                {
                    CategoryName = c.Name,
                    ToplamProje = portfolios.Count()
                }).ToList()
            };
            return View(model);
        }
        #endregion


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

        #region ExperienceOperations

        #region ExperienceList
        public IActionResult Experience()
        {
            var values = _context.Experiences.ToList();
            return View(values);
        }

        #endregion

        #region ExperienceAdd
        [HttpGet]
        public IActionResult ExperienceAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ExperienceAdd(Experience experience)
        {
            _context.Experiences.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("Experience");
        }
        #endregion

        #region ExperienceDelete
        public IActionResult ExperienceDelete(int id)
        {
            var values = _context.Experiences.Find(id);
            _context.Experiences.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Experience");
        }
        #endregion

        #region ExperienceWithAndUpdate
        public IActionResult ExperienceEdit(int id)
        {
            var values = _context.Experiences.Find(id);
            return View("ExperienceEdit", values);
        }

        [HttpPost]
        public IActionResult ExperienceUpdate(Experience experience)
        {
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("Experience");
        }



        #endregion

        #endregion

        #region MessageOperations

        #region MessageList
        public IActionResult Message()
        {
            #region GetIstatisticWithViewbag

            ViewBag.TotalMessage = _context.Messages.Count();
            ViewBag.IsUnReadMessage = _context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.IsReadMessage = _context.Messages.Where(x => x.IsRead == true).Count();
            ViewBag.TodaysMessages = _context.Messages.Where(x => x.SendDate.Day == DateTime.Now.Day).Count();


            #endregion

            var values = _context.Messages.ToList();
            return View(values);
        }

        public IActionResult MessageDetails(int id)
        {
            var values = _context.Messages.Find(id);
            return View("MessageDetails", values);
        }

        #endregion

        #endregion

        #region PortfolioOperations

        #region PortfolioList
        public IActionResult Portfolio()
        {
            var values = _context.Portfolios.Include(x => x.Category).ToList();
            return View(values);
        }

        #endregion

        #region PortfolioAdd
        [HttpGet]
        public IActionResult PortfolioAdd()
        {
            #region GetCategories
            var values = _context.Categories.Select(x => new SelectListItem
            {
                Value = x.CategoryId.ToString(),
                Text = x.Name
            }).ToList();

            ViewBag.categories = values;
            #endregion

            return View();
        }
        [HttpPost]
        public IActionResult PortfolioAdd(Portfolio portfolio)
        {
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("Portfolio");
        }
        #endregion

        #region PortfolioDelete
        public IActionResult PortfolioDelete(int id)
        {
            var values = _context.Portfolios.Find(id);
            _context.Portfolios.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Portfolio");
        }
        #endregion

        #region PortfolioWithAndUpdate
        public IActionResult PortfolioEdit(int id)
        {
            #region GetCategories
            var getcategory = _context.Categories.Select(x => new SelectListItem
            {
                Value = x.CategoryId.ToString(),
                Text = x.Name
            }).ToList();

            ViewBag.categories = getcategory;
            #endregion

            var values = _context.Portfolios.Find(id);
            return View("PortfolioEdit", values);
        }

        [HttpPost]
        public IActionResult PortfolioUpdate(Portfolio portfolio)
        {
            _context.Portfolios.Update(portfolio);
            _context.SaveChanges();
            return RedirectToAction("Portfolio");
        }



        #endregion

        #endregion

        #region SkillsOperations

        #region SkillsList
        public IActionResult Skills()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }

        #endregion

        #region SkillsAdd
        [HttpGet]
        public IActionResult SkillsAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult SkillsAdd(Skills Skills)
        {
            _context.Skills.Add(Skills);
            _context.SaveChanges();
            return RedirectToAction("Skills");
        }
        #endregion

        #region SkillsDelete
        public IActionResult SkillsDelete(int id)
        {
            var values = _context.Skills.Find(id);
            _context.Skills.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Skills");
        }
        #endregion

        #region SkillsWithAndUpdate
        public IActionResult SkillsEdit(int id)
        {
            var values = _context.Skills.Find(id);
            return View("SkillsEdit", values);
        }

        [HttpPost]
        public IActionResult SkillsUpdate(Skills Skills)
        {
            _context.Skills.Update(Skills);
            _context.SaveChanges();
            return RedirectToAction("Skills");
        }



        #endregion

        #endregion

        #region TestimonialsOperations

        #region TestimonialsList
        public IActionResult Testimonials()
        {
            var values = _context.Testimonials.ToList();
            return View(values);
        }

        #endregion

        #region TestimonialsAdd
        [HttpGet]
        public IActionResult TestimonialsAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult TestimonialsAdd(Testimonial Testimonial)
        {
            _context.Testimonials.Add(Testimonial);
            _context.SaveChanges();
            return RedirectToAction("Testimonials");
        }
        #endregion

        #region TestimonialsDelete
        public IActionResult TestimonialsDelete(int id)
        {
            var values = _context.Testimonials.Find(id);
            _context.Testimonials.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Testimonials");
        }
        #endregion

        #region TestimonialsWithAndUpdate
        public IActionResult TestimonialsEdit(int id)
        {
            var values = _context.Testimonials.Find(id);
            return View("TestimonialsEdit", values);
        }

        [HttpPost]
        public IActionResult TestimonialsUpdate(Testimonial Testimonial)
        {
            _context.Testimonials.Update(Testimonial);
            _context.SaveChanges();
            return RedirectToAction("Testimonials");
        }



        #endregion

        #endregion

        #region ServicesOperation

        #region ServicesList
        public IActionResult Services()
        {
            var values = _context.Services.ToList();
            return View(values);
        }

        #endregion

        #region ServicesAdd
        [HttpGet]
        public IActionResult ServicesAdd()
        {
            return View();
        }


        [HttpPost]
        public IActionResult ServicesAdd(Service Service)
        {
            _context.Services.Add(Service);
            _context.SaveChanges();
            return RedirectToAction("Services");
        }
        #endregion

        #region ServicesDelete
        public IActionResult ServicesDelete(int id)
        {
            var values = _context.Services.Find(id);
            _context.Services.Remove(values);
            _context.SaveChanges();
            return RedirectToAction("Services");
        }
        #endregion

        #region ServicesWithAndUpdate
        public IActionResult ServicesEdit(int id)
        {
            var values = _context.Services.Find(id);
            return View("ServicesEdit", values);
        }

        [HttpPost]
        public IActionResult ServicesUpdate(Service Service)
        {
            _context.Services.Update(Service);
            _context.SaveChanges();
            return RedirectToAction("Services");
        }


        #endregion

        #endregion
    }
}