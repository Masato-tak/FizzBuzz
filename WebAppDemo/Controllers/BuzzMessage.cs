using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppDemo.Controllers
{
    public class BuzzMessage : ICondition
    {
        public bool Matches(string input)
        {
            var isNumeric = int.TryParse(input, out int num);

            return isNumeric == true && (num % 5 == 0);
        }

        public string GetMessage()
        {
            return "Buzz";
        }
    }
}