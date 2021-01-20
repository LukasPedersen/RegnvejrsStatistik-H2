using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegnvejrsStatistik
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Menu();
        }
        public static void Menu()
        {
            int NumberOfDays = 0;
            List<double> ValueOfEachDay = new List<double>();
            ValueOfEachDay.Clear();
            Console.Clear();
            WriteToConsole("Hello and welcome", 30);
            WriteToConsole("...", 400);
            Console.Clear();
            WriteToConsole("How many days do you want to work with?\n", 30);
            //Check if input is a int and not to large
            try
            {
                NumberOfDays = Convert.ToUInt16(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.Clear();
                WriteToConsole("An error occurred remember to input a numer between 0 and 65535\n", 30);
                WriteToConsole("Error meassage: ", 30);
                Console.WriteLine(e.Message);
                WriteToConsole("Press any key to return", 30);
                Console.ReadKey();
                Menu();
                throw;
            }
            Console.Clear();
            WriteToConsole($"You chose to work with: {NumberOfDays} days is this correct?\n Y/N", 30);
            string key = Console.ReadKey().KeyChar.ToString();
            Console.Clear();
            switch (key)
            {
                case "y":
                    break;
                case "n":
                    WriteToConsole("Okey we will try again", 30);
                    WriteToConsole("...", 400);
                    Menu();
                    break;
                default:
                    WriteToConsole("Please input an y for yes or an n for no", 30);
                    Console.ReadKey();
                    Menu();
                    break;
            }
            for (int i = 1; i <= NumberOfDays; i++)
            {
                WriteToConsole($"How much rainfall in mm was there on day: {i}\n", 30);
                double value = Convert.ToDouble(Console.ReadLine());
                ValueOfEachDay.Add(value);
                Console.Clear();
            }
            Calculate.SelectionMenu(NumberOfDays, ValueOfEachDay);
        }
        /// <summary>
        /// Writes each char from input text and makes a little pause
        /// </summary>
        /// <param name="text"></param>
        /// <param name="speed"></param>
        public static void WriteToConsole(string text, int speed)
        {
            foreach (char letter in text)
            {
                Console.Write(letter);
                System.Threading.Thread.Sleep(speed);
            }
        }
    }
}
