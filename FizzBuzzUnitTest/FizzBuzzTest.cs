using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppDemo.Helpers;

namespace FizzBuzzUnitTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void TestPrint_Fizz()
        {
            var input = new string[] { "3" };

            var output = FizzBuzzHelper.Print(input);

            Assert.AreEqual("Fizz", output[0]);
        }

        [TestMethod]
        public void TestPrint_Buzz()
        {
            var input = new string[] { "5" };

            var output = FizzBuzzHelper.Print(input);

            Assert.AreEqual("Buzz", output[0]);
        }

        [TestMethod]
        public void TestPrint_FizzBuzz()
        {
            var input = new string[] { "15" };

            var output = FizzBuzzHelper.Print(input);

            Assert.AreEqual("FizzBuzz", output[0]);
        }

        [TestMethod]
        public void TestPrint_DivideBy3()
        {
            var input = new string[] { "1" };

            var output = FizzBuzzHelper.Print(input);

            Assert.AreEqual("Divided 1 by 3", output[0]);
        }

        [TestMethod]
        public void TestPrint_DivideBy5()
        {
            var input = new string[] { "1" };

            var output = FizzBuzzHelper.Print(input);

            Assert.AreEqual("Divided 1 by 5", output[1]);
        }

        [TestMethod]
        public void TestPrint_InvalidItem()
        {
            var input = new string[] { "A" };

            var output = FizzBuzzHelper.Print(input);

            Assert.AreEqual("Invalid Item", output[0]);
        }

        [TestMethod]
        public void TestPrint_InvalidItemEmpty()
        {
            var input = new string[] { "" };

            var output = FizzBuzzHelper.Print(input);

            Assert.AreEqual("Invalid Item", output[0]);
        }

        [TestMethod]
        public void TestPrint_List()
        {
            var input = new string[] { "1","3","5","15","A"," ","","100" };

            var output = FizzBuzzHelper.Print(input);

            Assert.AreEqual("Divided 1 by 3", output[0]);
            Assert.AreEqual("Divided 1 by 5", output[1]);
            Assert.AreEqual("Fizz", output[2]);
            Assert.AreEqual("Buzz", output[3]);
            Assert.AreEqual("FizzBuzz", output[4]);
            Assert.AreEqual("Invalid Item", output[5]);
            Assert.AreEqual("Invalid Item", output[6]);
            Assert.AreEqual("Invalid Item", output[7]);
            Assert.AreEqual("Buzz", output[8]);
            
        }
    }
}
