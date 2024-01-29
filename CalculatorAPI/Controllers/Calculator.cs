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
    }
}
