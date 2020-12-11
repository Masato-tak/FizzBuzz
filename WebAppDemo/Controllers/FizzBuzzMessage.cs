using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppDemo.Controllers
{
    public class FizzBuzzMessage : ICondition
    {
        public bool Matches(string input)
        {
            var isNumeric = int.TryParse(input, out int num);
            
            return isNumeric == true && (num % 3 == 0 && num % 5 == 0);
        }

        public string GetMessage()
        {
            return "FizzBuzz";
        }
    }
}