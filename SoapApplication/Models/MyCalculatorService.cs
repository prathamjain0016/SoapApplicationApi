namespace SoapApplication.Models
{
    public class MyCalculatorService : ICalculatorService
    {
        public MyCalculatorResponse Add(MyCalculatorRequest request)
        {
            return new MyCalculatorResponse { result = request.number1 + request.number2 };
        }

        public MyCalculatorResponse Divide(MyCalculatorRequest request)
        {
            if(request.number2 == 0) 
            {
                throw new DivideByZeroException("The Number can not be divided by zero. ");
            }
            return new MyCalculatorResponse { result = request.number1 / request.number2};
        }

        public MyCalculatorResponse Multiply(MyCalculatorRequest request)
        {
            return new MyCalculatorResponse { result = request.number1 * request.number2 };
        }

        public MyCalculatorResponse Subtract(MyCalculatorRequest request)
        {
            return new MyCalculatorResponse { result = request.number1 - request.number2 };
        }
    }
}
