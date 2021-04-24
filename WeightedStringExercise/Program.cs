using System;
using System.Collections.Generic;
using System.Linq;

namespace WeightedStringExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //string of number to be sorted 
            string intList = "56 65 74 100 99 68 86 180 90 343";

            //split the string of numbers by value
            var orderedWeight = intList.Split(' ')

                //order the sum of digits of the values
                .OrderBy(value => value.Sum(digit => digit - '0'))

                //order values as sorted sum 
                .ThenBy(value => value);

            //store the result to be printed
            var result = string.Join(" ", orderedWeight);

            Console.WriteLine(result);

        }

    }
}
