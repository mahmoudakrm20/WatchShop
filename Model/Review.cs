using System.ComponentModel.DataAnnotations;
namespace WatchShop.Model
{
    public class Review
    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Name is required.")]
        public string UserName { get; set; } = "";
        [Required(ErrorMessage = "Comment is required.")]
        public string Comment { get; set; } = "";
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
