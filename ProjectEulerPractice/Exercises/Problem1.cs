using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerPractice.Exercises
{
    internal class Problem1
    {
        private List<int> _inputs = new List<int>() { 10, 49, 1000, 8456, 19564};

        //Problem 1: Multiples of 3 and 5

        //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

        //Find the sum of all the multiples of 3 or 5 below the provided parameter value number.

        //multiplesOf3and5(10) should return a number.
        //multiplesOf3and5(49) should return 543.
        //multiplesOf3and5(1000) should return 233168.
        //multiplesOf3and5(8456) should return 16687353.
        //multiplesOf3and5(19564) should return 89301183.

        public int MultiplesOf3And5(int number)
        {
            var sum = 0;

            //find all numbers less than 'number' divisible by 3 or 5
            for (var i = 0; i < number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0) //modulo % - returns remainder
                {
                    sum += i;
                }
            }

            return sum;
        }

        public void Execute()
        {
            foreach (var input in _inputs)
            {
                Console.WriteLine($"input: {input}  result {MultiplesOf3And5(input)}");
            }
        }
    }
}
