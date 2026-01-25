using Project1_PortfolioWebSite.Entities;

namespace ResumeProjectDemo.Models.ViewModelForAboutArea
{
    public class ModelsForAboutArea
    {
        public About Abouts { get; set; }
        public IEnumerable<Experience> Experiences { get; set; }
        public IEnumerable<Education> Educations { get; set; }
    }
}
