using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Calculator : ControllerBase
    {
        [Route("/add/{num1}/{num2}")]
        [HttpGet]
        public decimal Add(decimal num1, decimal num2)
        {

            return num1 + num2;
        }

        [Route("/subtract/{smallnumber}/{bignumber}")]
        [HttpGet]
        public decimal Subtract(decimal smallnumber, decimal bignumber)
        {
            if (bignumber < smallnumber) { return 0.0m; }
            return bignumber - smallnumber;
        }

        [Route("/multiply/{num1}/{num2}")]
        [HttpGet]
        public decimal Multiply(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        [Route("/divide/{smallnumber}/{bignumber}")]
        [HttpGet]
        public decimal Divide(decimal smallnumber, decimal bignumber)
        {
            if (bignumber < smallnumber) { return 0m; }
            return bignumber / smallnumber;
        }

        [Route("/modulo/{smallnumber}/{bignumber}")]
        [HttpGet]
        public decimal Modulo(decimal smallnumber, decimal bignumber)
        {
            if (bignumber < smallnumber) { return 0m; }
            return bignumber % smallnumber;
        }
    }
}
