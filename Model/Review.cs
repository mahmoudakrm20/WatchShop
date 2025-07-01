namespace WatchShop.Model
{
    public class Review
    {
        public int ProductId { get; set; } 
        public string UserName { get; set; } = "";
        public string Comment { get; set; } = "";
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
