namespace CalculatorApp
{
    public interface IWebService
    {
        void SendData(string data);
    }

    public class Calculator
    {
        private readonly IWebService _webService;

        public Calculator(IWebService webService)
        {
            _webService = webService;
        }

        public int Add(int a, int b)
        {
            int result = a + b;
            _webService.SendData($"Add operation: {a} + {b} = {result}");
            return result;
        }
    }
}
