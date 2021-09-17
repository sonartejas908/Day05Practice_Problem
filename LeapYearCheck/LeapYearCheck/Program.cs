using System;

namespace LeapYearCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Four Digit Year to Check");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 400 == 0)
            {
                Console.WriteLine("it is leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine("is not a leap year");
            }
            else if (year % 4 ==0)
            {
                Console.WriteLine("it is leap year");
            }
            else
            {
                Console.WriteLine("it is not a leap year");
            }
        }
    }
}
