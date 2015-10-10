using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hoveret2
{
    class Program
    {
        private static object args;

        static void Targil2()
        {
            int number1, number2;
            Console.WriteLine("what is the first number");
            number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("what is the seconed number");
            number2 = int.Parse(Console.ReadLine());
            if (number1 % number2 == 0)
            {
                Console.WriteLine("yes");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("???");
                Console.ReadLine();
            }
        }
        static void Targil3a()
        {
            int avg;
            Console.WriteLine("what is the avg number");
            avg = int.Parse(Console.ReadLine());
            if ( avg == 100)
            {
                Console.WriteLine(" Nice Job ya dork");
                Console.ReadLine();
            }
             else



        }

        static void Main(string[] args)
        {
                Program.Targil2();
        }
    }
}
