using WatchShop.Model;

namespace WatchShop.Service
{
    public class ReviewService
    {
        private List<Review> reviews = new()
        {
            new Review
            {
                ProductId = 1,
                UserName = "Ahmed",
                Comment = "ساعة ممتازة وخفيفة.",
                Rating = 5,
                CreatedAt = DateTime.Now.AddDays(-2)
            },
            new Review
            {
                ProductId = 2,
                UserName = "Sara",
                Comment = "جميلة بس البطارية مش قوية.",
                Rating = 3,
                CreatedAt = DateTime.Now.AddDays(-3)
            },
            new Review
            {
                ProductId = 3,
                UserName = "Omar",
                Comment = "شكلها عصري وسعرها مناسب.",
                Rating = 4,
                CreatedAt = DateTime.Now.AddDays(-1)
            },
            new Review
            {
                ProductId = 4,
                UserName = "Laila",
                Comment = "فخمة جدًا والتوصيل سريع.",
                Rating = 5,
                CreatedAt = DateTime.Now.AddDays(-4)
            }
        };

        public List<Review> GetReviewsForProduct(int productId)
            => reviews.Where(r => r.ProductId == productId).ToList();

        public void AddReview(Review review)
        {
            review.CreatedAt = DateTime.Now;
            reviews.Add(review);
        }
    }
}
