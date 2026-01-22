namespace Project1_PortfolioWebSite.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string DataFilter { get; set; }
        public List<Portfolio> Portfolios { get; set; }
    }
}
