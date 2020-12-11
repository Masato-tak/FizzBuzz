using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppDemo.Controllers
{
    public class FizzBuzzFactory
    {
        public List<ICondition> GetConditions()
        {
            return new List<ICondition>()
            {
                new InvalidMessage(),
                new FizzBuzzMessage(),
                new FizzMessage(),
                new BuzzMessage(),
            };
        }

        public List<ICondition> GetContinuousConditions()
        {
            return new List<ICondition>() {
                new OperationThreeMessage(),
                new OperationFiveMessage(),
            };
        }
    }
}