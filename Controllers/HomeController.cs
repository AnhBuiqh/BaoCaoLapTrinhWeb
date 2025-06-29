using System.Diagnostics;
using System.Linq;
using AnhBui.Models;
using AnhBui.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AnhBui.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;

        public HomeController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public IActionResult Index()
        {
            var trendingProducts = _productRepository.GetTrendingProducts();
            return View(trendingProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
