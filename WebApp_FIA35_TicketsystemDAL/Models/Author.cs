namespace WebApp_FIA35_TicketsystemDAL.Models
{
    public class Author
    {
        public int AId { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
        public DateTime ActiveSince { get; set; }
        public DateTime LastPost { get; set; }

    }
}
