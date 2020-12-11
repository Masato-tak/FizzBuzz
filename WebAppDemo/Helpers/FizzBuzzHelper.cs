using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using WebAppDemo.Controllers;

namespace WebAppDemo.Helpers
{
    public static class FizzBuzzHelper
    {
        public static List<string> Print(string[] inputList)
        {
            var output = new List<string>();
           
            for (var i = 0; i < inputList.Length; i++)
            {
                PopulateList(inputList[i], output);
            }

            return output;
        }

        public static void PopulateList(string input, List<string> output)
        {
            var factory = new FizzBuzzFactory();
            
            //for those condition, exit out as soon as one condition is met
            foreach (var condition in factory.GetConditions())
            {
                if (condition.Matches(input))
                {
                    output.Add(condition.GetMessage());
                    return;
                }
            }
            
            //conditions that need to be checked continuously
            foreach(var condition in factory.GetContinuousConditions())
            {
                if (condition.Matches(input))
                {
                    output.Add(condition.GetMessage());
                }
            }
        }
    }
}