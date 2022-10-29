using MudBlazorModal.Models;

namespace MudBlazorModal.Services
{
    public class ProductService : IProductService
    {
        public static List<Product> db = new List<Product>()
        {
            new Product()
            {
                Name = "Apple",
                Category = "Fruit",
                Quantity = 25
            },
            new Product()
            {
                Name = "BMW",
                Category = "Car",
                Quantity = 1
            },
            new Product()
                {
                Name = "Onion",
                Category = "Vegetable",
                Quantity = 7
            }
        };

        public void CreateProduct(Product product)
        {
            db.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            db.Remove(product);
        }

        public List<Product> GetAllProducts()
        {
            return db;
        }

        public Product GetProductById(string id)
        {
            return db.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateProduct(Product product)
        {
            var productFromDb = db.FirstOrDefault(x => x.Id == product.Id);

            productFromDb.Name = product.Name;
            productFromDb.Category = product.Category;
            productFromDb.Quantity = product.Quantity;
        }
    }
}
