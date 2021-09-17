using System;

namespace Flip_Coin
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Number of times Coin Needs to flip");
            int Freq = Convert.ToInt32(Console.ReadLine());

            int Head = 0, Tail = 0;
            for (int i = 1; i <= Freq; i++)
            {
                Random random = new Random();
                int Num = random.Next(0, 2);

                if (Num == 0)
                {
                    Head++;
                }
                else if (Num == 1)
                {
                    Tail++;
                }
            }

            int perHead = Head;
            int perTail = Tail;
            Console.WriteLine("Head occourance is"+ " "+ perHead);
            Console.WriteLine("Tail occourance is" + " " + perTail);

        }
    }
}
