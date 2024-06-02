namespace OrderProcessing
{
    public interface IOrderService
    {
        void PlaceOrder(string product, int quantity);
    }

    public class OrderProcessor
    {
        private readonly IOrderService _orderService;

        public OrderProcessor(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public void ProcessOrder(string product, int quantity)
        {
            _orderService.PlaceOrder(product, quantity);
        }
    }
}
