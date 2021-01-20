using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegnvejrsStatistik
{
    class Calculate
    {
        public static void SelectionMenu(int NumberOfDays, List<double> ValueOfEachDay)
        {
            Program.WriteToConsole("Calculating please wait", 30);
            Program.WriteToConsole("..........", 500);
            Console.Clear();
            Program.WriteToConsole("Calculation complete", 30);
            Console.Clear();
            Program.WriteToConsole("What to you want to display?\n1: All data\n2: RainFall from each day\n3: The average, maximum, minimum rainfall\nB: Back\nX: Exit", 30);
            string key = Console.ReadKey().KeyChar.ToString();
            Console.Clear();
            switch (key)
            {
                case "1":
                    AllData(NumberOfDays, ValueOfEachDay);
                    break;
                case "2":
                    DataTable(NumberOfDays, ValueOfEachDay);
                    break;
                case "3":
                    AverageData(ValueOfEachDay);
                    break;
                case "b":
                    Program.Menu();
                    break;
                case "x":
                    Environment.Exit(0);
                    break;
                default:
                    SelectionMenu(NumberOfDays, ValueOfEachDay);
                    break;
            }
        }
        /// <summary>
        /// Writes the table from DataTable() and all other infomation from AverageData()
        /// </summary>
        /// <param name="NumberOfDays"></param>
        /// <param name="ValueOfEachDay"></param>
        private static void AllData(int NumberOfDays, List<double> ValueOfEachDay)
        {
            int index = 1;
            double average = ValueOfEachDay.Average();
            double maximum = ValueOfEachDay.Max();
            double minimum = ValueOfEachDay.Min();
            Console.WriteLine("|{0,3} | {1,10}|", " Day", "Rainfall in mm");
            Console.WriteLine("-----------------------");
            foreach (double Data in ValueOfEachDay)
            {
                Console.WriteLine("|{0,4} | {1,14}|", index, Data);
                index++;
            }
            Program.WriteToConsole($"The average rainfall is: {average}\nThe biggest amount of rain was: {maximum}\nThe smallest amount of rain was: {minimum}\nPress any key to go back", 30);
            Console.ReadKey();
            Console.Clear();
            SelectionMenu(NumberOfDays, ValueOfEachDay);
        }
        /// <summary>
        /// Takes all data from lsit and puts it in a table
        /// </summary>
        /// <param name="NumberOfDays"></param>
        /// <param name="ValueOfEachDay"></param>
        private static void DataTable(int NumberOfDays, List<double> ValueOfEachDay)
        {
            int index = 1;
            Console.WriteLine("|{0,3} | {1,10}|", " Day", "Rainfall in mm");
            Console.WriteLine("-----------------------");
            foreach (double Data in ValueOfEachDay)
            {
                Console.WriteLine("|{0,4} | {1,14}|", index, Data);
                index++;
            }
            Program.WriteToConsole("Press any key to go back", 30);
            Console.ReadKey();
            Console.Clear();
            SelectionMenu(NumberOfDays, ValueOfEachDay);
        }
        /// <summary>
        /// Finds the average, lowest, highst values form the list
        /// </summary>
        /// <param name="ValueOfEachDay"></param>
        private static void AverageData(List<double> ValueOfEachDay)
        {
            double average = ValueOfEachDay.Average();
            double maximum = ValueOfEachDay.Max();
            double minimum = ValueOfEachDay.Min();
            int NumberOfDays = ValueOfEachDay.Count();
            Program.WriteToConsole($"The average rainfall is: {average}\nThe biggest amount of rain was: {maximum}\nThe smallest amount of rain was: {minimum}\nPress any key to go back", 30);
            Console.ReadKey();
            Console.Clear();
            SelectionMenu(NumberOfDays, ValueOfEachDay);
        }
    }
}