using System;
using System.Collections.Generic;
using System.Text;

namespace DateAndTime
{
    public static class Tasks
    {
        /// <summary>
        /// Write a C# Sharp program to extract the Date property and display the DateTime value in the formatted output.
        /// </summary>
        public static void FormatDateTimeValue()
        {
            var date = new DateTime();

            Console.WriteLine($"Current date and time to local time = \"{date.ToLocalTime()}\"");
            Console.WriteLine($"Current date and time to short date string = \"{date.ToShortDateString()}\"");
            Console.WriteLine($"Current date and time to short time string = \"{date.ToShortTimeString()}\"");
        }
    }
}