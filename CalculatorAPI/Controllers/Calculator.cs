using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Calculator : ControllerBase
    {
        [Route("/add/{num1}/{num2}")]
        [HttpGet]
        public float Add(float num1, float num2)
        {

            return num1 + num2;
        }

        [Route("/subtract/{smallnumber}/{bignumber}")]
        [HttpGet]
        public float Subtract(float smallnumber, float bignumber)
        {
            if (bignumber < smallnumber) { return 0.0f; }
            return bignumber - smallnumber;
        }

        [Route("/multiply/{num1}/{num2}")]
        [HttpGet]
        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        [Route("/divide/{smallnumber}/{bignumber}")]
        [HttpGet]
        public float Divide(float smallnumber, float bignumber)
        {
            if (bignumber < smallnumber) { return 0f; }
            return bignumber / smallnumber;
        }

        [Route("/modulo/{smallnumber}/{bignumber}")]
        [HttpGet]
        public float Modulo(float smallnumber, float bignumber)
        {
            if (bignumber < smallnumber) { return 0f; }
            return bignumber % smallnumber;
        }
    }
}
