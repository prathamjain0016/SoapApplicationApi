using SoapCore;
using System.Runtime.Serialization;
namespace SoapApplication.Models
{
    [DataContract]
    public class MyCalculatorRequest
    {
        [DataMember]
        public double number1 { get; set; }

        [DataMember]
        public double number2 { get; set; }
    }

    [DataContract]
    public class MyCalculatorResponse
    {
        [DataMember]
        public double result { get; set; }
    }
}

