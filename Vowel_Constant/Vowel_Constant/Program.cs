using System;

namespace Vowel_Constant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Character");
            char MyChar = (char)Console.Read();
            
            if ( MyChar == 'a' || MyChar == 'e' || MyChar == 'i' || MyChar == 'o' || MyChar == 'u')
            {
                Console.WriteLine(MyChar+" "+"Is a Vowel");
            }
            else
            {
                Console.WriteLine(MyChar+" "+"It is a Consonant");
            }

        }
    }
}
