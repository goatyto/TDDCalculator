using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TDDCalculator.Core;
using TDDCalculator.Core.Abstractions;

namespace TDDCalculator.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController()
        {

        }

        [HttpGet("~/api/[controller]")]
        public IActionResult Index()
        {
            var sbWelcomeMessage = new StringBuilder();

            sbWelcomeMessage.AppendLine("Welcome to the TDD presentation!");
            sbWelcomeMessage.AppendLine();
            sbWelcomeMessage.AppendLine(
                "This is a simple calculator API that allows you to do basic math with two operands.");
            sbWelcomeMessage.AppendLine();
            sbWelcomeMessage.AppendLine(
                "Use the following routes for calculating different operations over two operands:");
            sbWelcomeMessage.AppendLine($"\t1. {Url.Action(nameof(Add))}?a=<decimal>&b=<decimal> for addition;");
            sbWelcomeMessage.AppendLine($"\t2. {Url.Action(nameof(Subtract))}?a=<decimal>&b=<decimal> for subtraction;");
            sbWelcomeMessage.AppendLine($"\t3. {Url.Action(nameof(Multiply))}?a=<decimal>&b=<decimal> for multiplication;");
            sbWelcomeMessage.AppendLine($"\t4. {Url.Action(nameof(Divide))}?a=<decimal>&b=<decimal> for division;");

            return Ok(sbWelcomeMessage.ToString());
        }

        [HttpGet]
        public IActionResult Add(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Subtract(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Multiply(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public IActionResult Divide(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }
    }
}
