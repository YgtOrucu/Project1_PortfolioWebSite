namespace Project1_PortfolioWebSite.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string NameSurname { get; set; }
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string MessageDetails { get; set; }
        public bool IsRead { get; set; }
        public DateTime SendDate { get; set; }
    }
}
