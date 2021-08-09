using ConsoleApp2;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestProject1
{

    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public static void GivenMemberIsDivisibleby3or5()
        {
            List<int> inputIntList = new List<int> { 1, 2, 3 };

            

            FizzBuzz fb = new FizzBuzz();
            List<string> result = fb.GetResult(inputIntList);


            List<string> ExpectedString = new List<string> { "1", "2", "Fizz" };
           

            //OutString = { }
            Assert.AreEqual(ExpectedString,result);
        }
    }
}