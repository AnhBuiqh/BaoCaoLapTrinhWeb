using AnhBui.Data;
using AnhBui.Models;
using AnhBui.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AnhBui.Models.Services
{
    public class OrderRepository : IOrderRepository
    {
        private readonly AnhBuiDbContext dbContext;
        private readonly IShoppingCartRepository shoppingCartRepository;

        public OrderRepository(AnhBuiDbContext dbContext, IShoppingCartRepository shoppingCartRepository)
        {
            this.dbContext = dbContext;
            this.shoppingCartRepository = shoppingCartRepository;
        }

        public void CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public string? GetOrderById(int orderId)
        {
            throw new NotImplementedException();
        }



        public IEnumerable<Order> GetOrdersByUser(object value)
        {
            throw new NotImplementedException();
        }

        public void PlaceOrder(Order order)
        {
            var shoppingCartItems = shoppingCartRepository.GetAllShoppingCartItems();
            order.OrderDetails = new List<OrderDetail>();

            foreach (var item in shoppingCartItems)
            {
                var orderDetail = new OrderDetail
                {
                    Quantity = item.Qty,
                    ProductId = item.Product.Id,
                    Price = item.Product.Price
                };
                order.OrderDetails.Add(orderDetail);
            }

            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = shoppingCartRepository.GetShoppingCartTotal();

            dbContext.Order.Add(order);
            dbContext.SaveChanges();
        }
    }
}