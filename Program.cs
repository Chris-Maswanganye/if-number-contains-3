using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_number_contains_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 87501;
            int digitToCheck = 3;

            bool containsDigit = number.ToString().Contains(digitToCheck.ToString());

            if (containsDigit)
                Console.WriteLine(number + "Contains the digit " + digitToCheck);

            else
                Console.WriteLine(number + " does not contain" + digitToCheck);
            Console.WriteLine();
        }
    }
}
