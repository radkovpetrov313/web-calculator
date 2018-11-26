using Microsoft.AspNetCore.Mvc;
using CalculatorApp.Models;

namespace CalculatorApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index(Calculator calculator)
        {
            return View(calculator);
        }

        [HttpPost]
        public IActionResult Calculate (Calculator calculator)
        {  
            if (calculator.RightOperand == 0 && calculator.Operator == "/")
            {
                TempData["divideByZeroError"] = "*You can't divide by Zero!";
            }

            calculator.CalculateResult();

            DataAccess.CalculatorHystory.Add(calculator);
       
            return RedirectToAction("Index", calculator);
        }

        public IActionResult Hystory ()
        {
            return View(DataAccess.CalculatorHystory);
        }
    }
}
