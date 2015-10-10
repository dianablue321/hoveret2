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
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(" Your test mark is:");
                markTest = double.Parse(Console.ReadLine());
                if (markTest < 60)
                {
                    markTest = markTest * 1.1;
                }

                avg = +markTest;
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
        static void Targil6()
        {
            int Bhavilot, Shavilot;
            Console.WriteLine("what is the number of bought packages");
            Bhavilot = int.Parse(Console.ReadLine());
            Bhavilot = Bhavilot * 5;
            Console.WriteLine("what is the number of sold packages");
            Shavilot = int.Parse(Console.ReadLine());
            Shavilot = Shavilot * 10;
            if (Bhavilot >= Shavilot)
            {
                Console.WriteLine("you are going broke");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("you are getting more money");
                Console.ReadLine();
            }


        }
        static void Targil7()
        {
            List<int> palindrom = new List<int>();
            int number;
            bool truth_flag = true;
            Console.WriteLine("Show me what you got");
            number = int.Parse(Console.ReadLine());
            while (number > 0)
            {
                palindrom.Add(number % 10);
                number = (number - (number % 10)) / 10;
            }
            int list_length = palindrom.Count;
            for (int i = 0; i < list_length; i++)
            {
                if (!palindrom[i].Equals(palindrom[(list_length - 1) - i]))
                {
                    truth_flag = false;
                }
            }

            if (truth_flag)
            {
                Console.WriteLine("I like what you got");
            }
            else
            {
                Console.WriteLine("Prepare to be destroyed");
            }
            Console.ReadLine();
        }
        static void Targil8()
        {
            int students = 0 , bus, places;
            //Console.WriteLine("How much students are going in class ?");
            //students = int.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(" The ammount of students in the class is:");
                students =+ int.Parse(Console.ReadLine());
            }
            Console.WriteLine("How much places are there in each bus? ");
            places = int.Parse(Console.ReadLine());
            bus = students / places;
            if (students > places)
            {
                Console.WriteLine("you need to order {0} bus", bus);
            }
            else
            {
                Console.WriteLine(" we have enough buses, USE 1 and GO GO GO!");
            }
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            //Program.Targil2();
            //rogram.Targill3a();
            //Program.Targil6();
            //Program.Targil7();
            Program.Targil8();
        }
    }
}
