using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableCodeLibrary
{
    public class Date
    {
        public static void datetoday(DateTime Today)
        {
            Console.WriteLine("DISPLAYING NOW " + Today);
            Console.WriteLine("Year : " + Today.Year);
            Console.WriteLine("Month : " + Today.Month);
            Console.WriteLine("Day : " + Today.Day);
            Console.WriteLine("Hour : " + Today.Hour);
            Console.WriteLine("Minutes : " + Today.Minute);
            Console.WriteLine("Seconds : " + Today.Second);
            Console.WriteLine("Milliseconds : " + Today.Millisecond);
            Console.WriteLine("Long date : "  + Today.ToLongDateString());
            Console.WriteLine("Short date : " + Today.ToShortDateString());
            Console.WriteLine("Long Time : " + Today.ToLongTimeString());
            Console.WriteLine("Short Time : " + Today.ToShortTimeString());
            Console.WriteLine("Adding 2 days : " + Today.AddDays(2));
            Console.WriteLine("Converting to UTC Time : " + Today.ToUniversalTime());
            Console.WriteLine("Whether year is leap year : " + DateTime.IsLeapYear(Today.Year));

            Console.ReadLine();

        }
    }
}
