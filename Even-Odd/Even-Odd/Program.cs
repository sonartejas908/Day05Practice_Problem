using System;

namespace Even_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num % 2 == 0)
                Console.WriteLine("It is even Number");
            else
                Console.WriteLine("It is odd Number");
        }
    }
}
