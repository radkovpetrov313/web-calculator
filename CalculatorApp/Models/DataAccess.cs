using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp.Models
{
    public class DataAccess
    {
        public static List<Calculator> CalculatorHystory { get; set; } = new List<Calculator>();
    }
}
