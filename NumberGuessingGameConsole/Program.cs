using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGameConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ksay;
            int tsay;
            int say = 0;
            Random rand = new Random();
            tsay = rand.Next(1, 10);

            Console.WriteLine("welcome to the number guessing game");
            Console.WriteLine("please find the number I keep 1-10");
            string input = Console.ReadLine(); //get the input
            if (!int.TryParse(input, out ksay))
            {
                Console.WriteLine("Not a number, type again ");
            }

            while (true)
            {
                if (ksay > tsay)
                {
                    if (!int.TryParse(input, out ksay))
                    {
                        Console.WriteLine("Not a number, type again ");
                        input = Console.ReadLine(); //get the input
                        say++;
                    }
                    else
                    {
                        Console.WriteLine("The number you entered is slightly larger than my number.");
                        input = Console.ReadLine(); //get the input
                        say++;

                    }
                }
                else if (ksay < tsay)
                {

                    if (!int.TryParse(input, out ksay))
                    {
                        Console.WriteLine("Not a number, type again ");
                        input = Console.ReadLine(); //get the input
                        say++;
                    }
                    else
                    {
                        Console.WriteLine("The number you entered is slightly smaller than my number.");
                        input = Console.ReadLine(); //get the input
                        say++;

                    }
                }
                else
                {
                    say++;
                    Console.WriteLine("Congratulations you won the game with " + say + " guess!");
                    Console.ReadKey();
                    break;
                }

            }
        }
    }
}
