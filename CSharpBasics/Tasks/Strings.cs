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
        /// doesn't provide any values, consider it as invalid format. 
        /// </summary>
        public static void TimeFormatCheck()
        {
            Console.WriteLine("Enter a time value in the 24-hour time " +
                "format (e.g. 19:00): ");
            var time = Console.ReadLine();
            try
            {
                var timeParts = Array.ConvertAll<string, int>(time.Split(':'), Convert.ToInt32);
                var timeSpan = new TimeSpan(timeParts[0], timeParts[1], 0);
                if (timeSpan.TotalDays < 1)
                {
                    Console.WriteLine($"Ok");
                }
                else
                {
                    Console.WriteLine($"Invalid Time");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid format");
            }
        }

        /// <summary>
        /// Write a program and ask the user to enter a few words separated by a space.
        /// Use the words to create a variable name with PascalCase.For example, if the 
        /// user types: "number of students", display "NumberOfStudents". Make sure that 
        /// the program is not dependent on the input. So, if the user types "NUMBER OF 
        /// STUDENTS", the program should still display "NumberOfStudents".
        /// </summary>
        public static void ToPascalCase()
        {
            Console.WriteLine("Enter a few words separated by a space");

            var words = Console.ReadLine().Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = Char.ToUpperInvariant(words[i][0]) + words[i].Substring(1);
            }

            var sb = new StringBuilder();

            foreach (var word in words)
            {
                sb.Append(word);
            }

            Console.WriteLine(sb);
        }

        /// <summary>
        /// Write a program and ask the user to enter an English word. Count the number of 
        /// vowels (a, e, o, u, i) in the word. So, if the user enters "inadequate", the 
        /// program should display 6 on the console.
        /// </summary>
        public static void VowelsCount()
        {
            Console.WriteLine("Enter an English word");
            var charArray = Console.ReadLine().ToCharArray();
            var amountOfVowels = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i].IsVowel()) amountOfVowels++;
            }

            Console.WriteLine($"{amountOfVowels}");
        }
    }
}