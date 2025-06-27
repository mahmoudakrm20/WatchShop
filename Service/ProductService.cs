using WatchShop.Model;
namespace WatchShop.Service
{
    public class ProductService
    {
        private List<Product> products = new()
        {
            new Product { Id = 1, Name = "Watch 1", Price = 1000, Description = "", ImgURL = "" },
            new Product { Id = 2, Name = "Watch 2", Price = 2000, Description = "", ImgURL = "" }
        };
        public List<Product> GetAll() => products;
        public Product? GetById(int id) => products.FirstOrDefault(p => p.Id == id);
    }
}
