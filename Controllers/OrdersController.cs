using AnhBui.Models;
using AnhBui.Models.Interfaces;
using AnhBui.Models.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnhBui.Controllers
{
    public class OrdersController : Controller
    {
        private IOrderRepository orderRepository;
        private IShoppingCartRepository shoppingCartRepository;
        private IEnumerable<Order> order;
        private readonly object dbContext;

        public OrdersController(IOrderRepository oderRepository,IShoppingCartRepository shoppingCartRepossitory)
        {
            this.orderRepository = oderRepository;
            this.shoppingCartRepository = shoppingCartRepossitory;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            orderRepository.PlaceOrder(order);
            shoppingCartRepository.ClearCart();

            return RedirectToAction("CheckoutComplete");
        }

        public IActionResult CheckoutComplete()
        {
            return View();
        }

        public IActionResult Invoice(int orderId)
        {
            var order = orderRepository.GetOrderById(orderId);
            if (order == null)
            {
                return NotFound();
            }
            return View(order);
        }

        public IActionResult List()
        {

            order = orderRepository.GetOrdersByUser(null);
            return View(order);
        }

    }
}
