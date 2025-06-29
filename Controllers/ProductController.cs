using AnhBui.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AnhBui.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Shop()
        {
            var products = _productRepository.GetAllProducts();
            return View(products);
        }
        public IActionResult Detail(int id)
        {
            var product = _productRepository.GetProductDetail(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
    }
}
