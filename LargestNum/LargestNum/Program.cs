using System;

namespace LargestNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Three Numbers");
            int Num1 = Convert.ToInt32(Console.ReadLine());
            int Num2 = Convert.ToInt32(Console.ReadLine());
            int Num3 = Convert.ToInt32(Console.ReadLine());

            if (Num1 > Num2 && Num1 > Num3)
                Console.WriteLine(Num1+ " "+ "is Greater");
            else if (Num2 > Num1 && Num2 > Num3)
                Console.WriteLine(Num2 + " " + "is Greater");
            else
                Console.WriteLine(Num3 + " " + "is Greater");
        }
    }
}
