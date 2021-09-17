using System;

namespace Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            int min = 2;
            for (int i=min; i<=Num/2; i++) //20
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i);
                    Num = Num / i;
                    min = 2;
                }
            }
        }
    }
}
