using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppDemo.Controllers
{
    public class InvalidMessage: ICondition
    {
        public bool Matches(string input)
        {
            return int.TryParse(input, out int num) == false;
        }

        public string GetMessage()
        {
            return "Invalid Item";
        }

        
    }
}