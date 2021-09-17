using System;

namespace PowerOfTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            int sum = 1;
            for (int i=1; i<=Num; i++)
            {
                sum = (sum * 2);
                Console.WriteLine(sum);
                    
            }
        }
    }
}
