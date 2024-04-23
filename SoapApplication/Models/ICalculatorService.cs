using SoapCore;
using System.ServiceModel;
namespace SoapApplication.Models
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        MyCalculatorResponse Add(MyCalculatorRequest request);

        [OperationContract]
        MyCalculatorResponse Subtract(MyCalculatorRequest request);

        [OperationContract]
        MyCalculatorResponse Multiply(MyCalculatorRequest request);

        [OperationContract]
        MyCalculatorResponse Divide(MyCalculatorRequest request);

    }
}
