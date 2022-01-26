using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerPractice.Exercises
{
    internal class Problem3
    {
        //Problem 3: Largest prime factor

        //The prime factors of 13195 are 5, 7, 13 and 29.
        //What is the largest prime factor of the given number?

        //largestPrimeFactor(2) should return a number.
        //largestPrimeFactor(2) should return 2.
        //largestPrimeFactor(3) should return 3.
        //largestPrimeFactor(5) should return 5.
        //largestPrimeFactor(7) should return 7.
        //largestPrimeFactor(8) should return 2.
        //largestPrimeFactor(13195) should return 29.
        //largestPrimeFactor(600851475143) should return 6857.

        public long LargestPrimeFactor(long number)
        {
            long largestPrime = 0;
            //List<int> factors = new List<int>();
            // ? indicates a nullable type
            //bool can only be true or false
            //bool? can be true, false or null
            Dictionary<int, bool?> factorDict = new Dictionary<int, bool?>();

            //find the factors
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    factorDict.Add(i, null);
                }
            }

            //find prime factors
            foreach (var item in factorDict)
            {
                List<int> tempFac = new List<int>();

                for (int i = 2; i < item.Key; i++)
                {
                    if (item.Key % i == 0)
                    {
                        tempFac.Add(i);
                    }
                }

                //if a factor is prime, set its value from null to true
                //if it isn't prime, set its value from null to false
                if (item.Key == 2)
                {
                    factorDict[item.Key] = true;
                } 
                else if (item.Key % 2 == 0 || tempFac.Count > 0)
                {
                    factorDict[item.Key] = false;
                }
                else
                {
                    factorDict[item.Key] = true;
                }
            }
             
            List<int> primeFactors = factorDict.Where(f => f.Value == true).Select(kvp => kvp.Key).ToList();

            //find largest prime factor
            largestPrime = primeFactors.Max();

            return largestPrime;
        }

        public void Execute()
        {
            Console.WriteLine(LargestPrimeFactor(2)); //should return a number.
            Console.WriteLine(LargestPrimeFactor(2)); //should return 2.
            Console.WriteLine(LargestPrimeFactor(3)); //should return 3.
            Console.WriteLine(LargestPrimeFactor(5)); //should return 5.
            Console.WriteLine(LargestPrimeFactor(7)); //should return 7.
            Console.WriteLine(LargestPrimeFactor(8)); //should return 2.
            Console.WriteLine(LargestPrimeFactor(13195)); //should return 29.
            Console.WriteLine(LargestPrimeFactor(600851475143)); //should return 6857.
        }
    }
}
