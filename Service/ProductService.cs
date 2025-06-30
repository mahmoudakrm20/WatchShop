using WatchShop.Model;
namespace WatchShop.Service
{
    public class ProductService
    {
        private List<Product> products = new()
{
    new Product {
        Id = 1,
        Name = "Rolex Submariner Black Steel",
        Price = 9100,
        Description = "Classic stainless steel Submariner, 41 mm black ceramic bezel.",
        ImgURL = "https://www.reedsmayfaire.com/pub/media/wysiwyg/rolex/model/top/desktop/m126610lv-0002.jpg"
    },
    new Product {
        Id = 2,
        Name = "Rolex Submariner Blue Two‑Tone",
        Price = 16150,
        Description = "Stainless steel & yellow gold, blue dial and ceramic bezel.",
        ImgURL = "https://s3.us-east-1.amazonaws.com/ISHOWIMAGES/ROLEX+V7/wp/upright_watch_assets_landscape/m126619lb-0003.webp"
    },
    new Product {
        Id = 3,
        Name = "Rolex Submariner Green Bezel",
        Price = 10800,
        Description = "Stainless steel Submariner Date with iconic green bezel (‘Kermit’).",
        ImgURL = "https://www.reedsmayfaire.com/pub/media/wysiwyg/rolex/model/top/desktop/m126610lv-0002.jpg"
    },
    new Product {
        Id = 4,
        Name = "Rolex Submariner White Gold",
        Price = 43700,
        Description = "Premium 18 kt white gold, blue bezel & dial.",
        ImgURL = "https://s3.us-east-1.amazonaws.com/ISHOWIMAGES/ROLEX+V7/wp/upright_watch_assets_landscape/m126619lb-0003.webp"
    }
};
        public List<Product> GetAll() => products;
        public Product? GetById(int id) => products.FirstOrDefault(p => p.Id == id);
    }
}
