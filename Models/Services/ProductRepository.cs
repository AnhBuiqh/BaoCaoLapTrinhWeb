using AnhBui.Data;
using AnhBui.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace AnhBui.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly AnhBuiDbContext _dbContext; 

        public ProductRepository(AnhBuiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _dbContext.Products; 
        }

        public Product? GetProductDetail(int id)
        {
            return _dbContext.Products.FirstOrDefault(p => p.Id == id); 
        }

        public IEnumerable<Product> GetTrendingProducts()
        {
            return _dbContext.Products.Where(p => p.IsTrendingProduct); 
        }
    }
}
