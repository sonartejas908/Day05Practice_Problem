using System;

namespace SwapTwoNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int Num1 = Convert.ToInt32(Console.ReadLine()); //45
            Console.WriteLine("Enter Second Number");
            int Num2 = Convert.ToInt32(Console.ReadLine()); //25

            int Num02 = Num2;
            int Num01 = Num1;
            Num1 = Num02;
            Num2 = Num01;
            Console.WriteLine("Num1 is" + " "+ Num1 );
            Console.WriteLine("Num2 is" + " "+ Num2 );
        }
    }
}
