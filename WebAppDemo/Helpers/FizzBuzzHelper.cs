using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace WebAppDemo.Helpers
{
    public static class FizzBuzzHelper
    {
        public static List<string> Print(string[] inputList)
        {
            var output = new List<string>();

            for (var i = 0; i < inputList.Length; i++)
            {
                var isNumeric = int.TryParse(inputList[i], out int num);

                if (isNumeric == false)
                {
                    output.Add("Invalid Item");
                }
                else if (num % 3 == 0 && num % 5 == 0)
                {
                    output.Add("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    output.Add("Fizz");
                }
                else if (num % 5 == 0)
                {
                    output.Add("Buzz");
                }
                else 
                {
                    if (num % 3 != 0) {

                        output.Add($"Divided { inputList[i] } by 3");
                    }

                    if (num % 5 != 0)
                    {
                        output.Add($"Divided { inputList[i] } by 5");
                    }
                }
            }

            return output;
        }
    }
}