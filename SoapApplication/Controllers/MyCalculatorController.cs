

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SoapApplication.Models;


namespace SoapApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyCalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public MyCalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost("add")]
        public ActionResult<double> Add(double num1 , double num2) 
        {
            try
            {
                var request = new MyCalculatorRequest { number1 = num1, number2 = num2 };
                var response = _calculatorService.Add(request);
                return Ok(response.result);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("subtract")]
        public ActionResult<double> Subtract(double num1, double num2)
        {
            try
            {
                var request = new MyCalculatorRequest { number1 = num1, number2 = num2 };
                var response = _calculatorService.Subtract(request);
                return Ok(response.result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost("Multiply")]
        public ActionResult<double> Multiply(double num1, double num2)
        {
            try
            {
                var request = new MyCalculatorRequest { number1 = num1, number2 = num2 };
                var response = _calculatorService.Multiply(request);
                return Ok(response.result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Divide")]
        public ActionResult<double> Divide(double num1, double num2)
        {
            try
            {
                var request = new MyCalculatorRequest { number1 = num1, number2 = num2 };
                var response = _calculatorService.Divide(request);
                return Ok(response.result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
