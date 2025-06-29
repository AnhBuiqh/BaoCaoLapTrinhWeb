
namespace AnhBui.Models.Interfaces
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
        string? GetOrderById(int orderId);
        IEnumerable<Order> GetOrdersByUser(object value);
        void PlaceOrder(Order order);

    }
}
