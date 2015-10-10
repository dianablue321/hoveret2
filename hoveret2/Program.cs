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
            double avg = 0;
            double markTest;
            for (int i=0;i<3;i++)
            {
                Console.WriteLine(" Your test mark is:");
                markTest = double.Parse(Console.ReadLine());
                if (markTest < 60)
                {
                    markTest = markTest * 1.1;
                }

                avg =+ markTest;     
            }
            avg = avg / 3; 
            if (avg.Equals(100))
            {
                Console.WriteLine(" Nice Job ya dork");
                Console.ReadLine();
            }
            else
            Console.WriteLine(" too bad stupid");
            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            //Program.Targil2();
            Program.Targil3a();
        }
    }
}
