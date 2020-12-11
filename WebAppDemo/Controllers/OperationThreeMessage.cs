using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppDemo.Controllers
{
    public class OperationThreeMessage : ICondition
    {
        public int Input { get; set; }

        public bool Matches(string input)
        {
            var isNumeric = int.TryParse(input, out int num);

            Input = num;

            return isNumeric == true && (num % 3 != 0);
        }

        public string GetMessage()
        {
            return $"Divided { Input } by 3";
        }
        
    }
}