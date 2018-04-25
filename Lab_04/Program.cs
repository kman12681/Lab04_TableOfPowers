using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t=======================");
            Console.WriteLine("\t|     Amazing         |\n\t|       Table         |\n\t|         of          |\n\t|          Powers     |");
            Console.WriteLine("\t=======================");

            while (true)
            {
                string input;

                while (true) // input validation, loop runs until integer >= 1 is entered
                {
                    Console.Write("\nEnter a whole number greater than zero: ");
                    input = Console.ReadLine();
                    if (!int.TryParse(input, out int digit) || (Convert.ToInt32(input) < 1))
                    {
                        Console.WriteLine("\nIncorrect Entry.");
                        continue;
                    }
                    break;
                }
                
                Console.WriteLine();
                Console.WriteLine("\tNumber\tSquared\tCubed");
                Console.WriteLine("\t=======\t=======\t=======");

                int userNum = Convert.ToInt32(input); // passes validated user input from a string to an integer

                for (int i = 1; i <= userNum; i++)
                {

                    Console.WriteLine($"\t{i}\t {Math.Pow(i, 2)}\t {Math.Pow(i, 3)}");
                }

                string response = DoAgain(); // method call for running the program again or not.

                if (response == "Y")

                {
                    continue;
                }

                else
                {
                    break;
                }

            }
            Console.WriteLine("\nThanks for using the...\n");
            Console.WriteLine("\t=======================");
            Console.WriteLine("\t|     Amazing         |\n\t|       Table         |\n\t|         of          |\n\t|          Powers     |");
            Console.WriteLine("\t=======================");
            Console.WriteLine("\nSee Ya!");
            Console.ReadKey();

        }

        static string DoAgain()

        {
            while (true) // will run program again if user enters "Y" (or "y"), will exit if "N" (or "n")

            {

                Console.Write("\nDo you want to try again? (Y or N) ");
                string input = Console.ReadLine().ToUpper();

                if (input == "Y" || input == "N")

                {
                    return input;
                }

                else

                {
                    Console.WriteLine("\nNot a valid entry.");
                }

            }
        }
    }
}
