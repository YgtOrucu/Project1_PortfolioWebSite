using Project1_PortfolioWebSite.Entities;

namespace Project1_PortfolioWebSite.Models.DashboardForAdminPage
{
    public class DashboardForAdminPage
    {
        public int TotalMessage { get; set; }
        public int UnReadMessage { get; set; }
        public int ReadMessage { get; set; }
        public int TotalProject { get; set; }
        public int TotalCategory { get; set; }
        public int TotalTestimoial { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public List<Message> Messages { get; set; }
        public List<CategoryProjectCountDto> Portfolios { get; set; }
    }
}
