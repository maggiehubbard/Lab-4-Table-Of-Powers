using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_Table_of_Powers
{
    class Program
    {
       static int squared(int a)
        {
            return a * a;
        }

        static int cubed(int a)
        {
            return a * a * a;
        }
        static void Main(string[] args)
        {
            {
                //declare variables
                int num;
                string userNum;
                string test = "y";
                bool isItANum;

                //Introduces program
                Console.WriteLine("Learn your squares & cubes!");
                Console.WriteLine("------------------------------\n");

                //while loop to so user has an option to keep running the program
                while (test == "y")
                {
                    //user prompts
                    Console.Write("Please enter an integer:");
                    userNum = Console.ReadLine();

                    //converts the string to an int
                    isItANum = int.TryParse(userNum, out num);
                    while (!isItANum)
                    {
                        Console.WriteLine("Error you did enter a valid number. Please try again.");
                        Console.Write("Please enter an integer: ");
                        userNum = Console.ReadLine();
                        isItANum = int.TryParse(userNum, out num);
                    }

                    //output
                    Console.WriteLine("\n");
                    Console.WriteLine("Number \t Squared   Cubed");
                    Console.WriteLine("=======  ========  =======");
                    for (int x = 1; x < num+1; x++)
                    {
                        Console.WriteLine(x + " \t " + squared(x) + " \t    " + cubed(x));
                    }

                    //gives user option to continue or exit program
                    Console.WriteLine("\nWould you like to contine? (y/n)");
                    test = Console.ReadLine().ToLower();
                }

            }

            //Pause before application code
            Console.WriteLine("\n You did not enter 'y' \nPress any key to exit. .");
            Console.ReadKey();

        }
    }
}
