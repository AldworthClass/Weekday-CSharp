using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekday
{
    class Program
    {
        // This method will accept an integer representing the day of the week, and return a string representation of that day
        public static string WeekdayName(int day)
        {
            string result = "";
            if (day == 1)
            {
                result = "Monday";
            }
            else if (day == 2)
            {
                result = "Tuesday";
            }
            // Add the remaining 'else if' statements for the rest of the days of the week.
            // Make result be 'error' if a number other than 1-7 is entered.

            return result;
        }
        static void Main(string[] args)
        {
            // This will get the current date from the computer
            DateTime localDate = DateTime.Now;
            int today = (int)localDate.DayOfWeek;

            Console.WriteLine("Weekday 1: " + WeekdayName(1));
            Console.WriteLine("Weekday 2: " + WeekdayName(2));
            Console.WriteLine("Weekday 3: " + WeekdayName(3));
            Console.WriteLine("Weekday 4: " + WeekdayName(4));
            Console.WriteLine("Weekday 5: " + WeekdayName(5));
            Console.WriteLine("Weekday 6: " + WeekdayName(6));
            Console.WriteLine("Weekday 7: " + WeekdayName(7));
            Console.WriteLine("Weekday 0: " + WeekdayName(0));
            Console.WriteLine();
            Console.WriteLine("Weekday 43: " + WeekdayName(43));
            Console.WriteLine("Weekday 17: " + WeekdayName(17));
            Console.WriteLine("Weekday -1: " + WeekdayName(-1));
            Console.WriteLine();
            Console.WriteLine("Today's is a " + WeekdayName(today) + ".");

            Console.ReadLine(); // Keeps program from automatically closing
        }
    }
}
