using MudBlazorModal.Models;

namespace MudBlazorModal.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProductById(string id);

        void DeleteProduct(Product product);
        void UpdateProduct(Product product);
        void CreateProduct(Product product);
    }
}
