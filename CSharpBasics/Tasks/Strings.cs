using System;
using System.Collections.Generic;
using System.Text;
using ExtensionMethods;

namespace Strings
{
    public static class StringsTasks
    {
        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen.
        /// Work out if the numbers are consecutive. For example, if the input is 
        /// "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, 
        /// display "Not Consecutive". 
        /// </summary>
        public static void ConsecutyCheck()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen");
            var stringOfNumbers = Console.ReadLine();

            try
            {
                var numbers = Array.ConvertAll<string, decimal>(stringOfNumbers.Split('-'), Convert.ToDecimal);
                if (numbers.IsDecimalArraySorted())
                {
                    Console.WriteLine("Consecutive");
                }
                else
                {
                    Console.WriteLine("Not Consecutive");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid format");
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a few numbers separated by a hyphen.
        /// If the user simply presses Enter, without supplying an input, exit immediately; 
        /// otherwise, check to see if there are duplicates.If so, display "Has duplicate" 
        /// on the console.
        /// </summary>
        public static void ShowDuplicates()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen.");
            var stringOfNumbers = Console.ReadLine();
            try
            {
                var numbers = Array.ConvertAll<string, decimal>(stringOfNumbers.Split('-'), Convert.ToDecimal);
                if (numbers.HasDuplicates())
                {
                    Console.WriteLine("Has Duplicates");
                }
                else
                {
                    Console.WriteLine("No Duplicates");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid format");
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a time value in the 24-hour time 
        /// format(e.g. 19:00). A valid time should be between 00:00 and 23:59. If the 
        /// time is valid, display "Ok"; otherwise, display "Invalid Time". If the user 
        /// doesn't provide any values, consider it as invalid time. 
        /// </summary>
        public static void TimeFormatCheck()
        {

        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space.
        /// Use the words to create a variable name with PascalCase.For example, if the 
        /// user types: "number of students", display "NumberOfStudents". Make sure that 
        /// the program is not dependent on the input. So, if the user types "NUMBER OF 
        /// STUDENTS", the program should still display "NumberOfStudents".
        /// </summary>
        public static void ToPascalcase()
        {

        }

        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of 
        /// vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the 
        /// program should display 6 on the console.
        /// </summary>
        public static void VowelsCount()
        {

        }
    }
}