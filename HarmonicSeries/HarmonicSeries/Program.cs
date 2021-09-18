using System;

namespace HarmonicSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Number");
            int Num = Convert.ToInt32(Console.ReadLine());
            float sum = 0;
            for (int i=1; i<=Num; i++)
            {
                sum += 1/i;
                Console.WriteLine(sum);
            }
            
        }
    }
}
