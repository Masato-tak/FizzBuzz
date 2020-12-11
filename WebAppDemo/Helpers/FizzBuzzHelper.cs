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
        public static List<ICondition> conditions = new List<ICondition>()
        {
            new InvalidMessage(),
            new FizzBuzzMessage(),
            new FizzMessage(),
            new BuzzMessage(),
        };

        public static List<ICondition> conditionsContinuation = new List<ICondition>
        {
            new OperationThreeMessage(),
            new OperationFiveMessage(),
        };

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
            //for those condition, exit out as soon as one condition is met
            foreach (var condition in conditions)
            {
                if (condition.Matches(input))
                {
                    output.Add(condition.GetMessage());
                    return;
                }
            }
            
            //conditions that need to be checked continously
            foreach(var condition in conditionsContinuation)
            {
                if (condition.Matches(input))
                {
                    output.Add(condition.GetMessage());
                }
            }
        }
    }
}