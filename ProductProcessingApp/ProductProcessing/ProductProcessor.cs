namespace ProductProcessing
{
    public interface IProductService
    {
        void ProcessProduct(string product, int quantity);
    }

    public class ProductProcessor
    {
        private readonly IProductService _productService;

        public ProductProcessor(IProductService productService)
        {
            _productService = productService;
        }

        public void Process(string product, int quantity)
        {
            _productService.ProcessProduct(product, quantity);
        }
    }
}
