using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputIntList = new List<int> { 1, 2, 3 };



            FizzBuzz fb = new FizzBuzz();
            List<string> result = fb.GetResult(inputIntList);
        }
    }

    public class FizzBuzz
    {
        public List<string> GetResult(List<int> Input)
        {
            List<string> result = new List<string>(3);
            for (int i = 0; i < Input.Count; i++)
            {
                if (Input[i] % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else
                {
                    result.Add(Input[i].ToString());
                }

            }
            return result;
        }
    }
}
