using AnhBui.Models;
using System.Collections.Generic;

namespace AnhBui.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable <Product> GetAllProducts();
        IEnumerable<Product> GetTrendingProducts();
        Product? GetProductDetail(int id);
    }
}
