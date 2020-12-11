using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppDemo.Controllers
{
    public class FizzMessage : ICondition
    {
        public bool Matches(string input)
        {
            var isNumeric = int.TryParse(input, out int num);

            return isNumeric && (num % 3 == 0);
        }

        string ICondition.GetMessage()
        {
            return "Fizz";
        }
    }
}