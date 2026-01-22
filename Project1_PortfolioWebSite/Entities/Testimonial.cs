namespace Project1_PortfolioWebSite.Entities
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string NameSurname { get; set; }
        public string TitleAndCompany { get; set; }
        public string CommentDetails { get; set; }
        public string ImageUrl { get; set; }
        public bool IsConfirm { get; set; }
    }
}
