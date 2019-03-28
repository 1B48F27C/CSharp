using System;
using System.Collections.Generic;
using System.Text;

namespace ArraysAndLists
{
    public static class Tasks
    {
        /*
         * When you post a message on Facebook, depending 
         * on the number of people who like your post, 
         * Facebook displays different information.
         * If no one likes your post, it doesn't display anything.
         * If only one person likes your post, it displays: [Friend's Name] likes your post.
         * If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
         * If more than two people like your post, it displays: [Friend 1], [Friend 2] and 
         * [Number of Other People] others like your post.
         * Write a program and continuously ask the user to enter different names, until the user 
         * presses Enter (without supplying a name). Depending on the number of names provided, 
         * display a message based on the above pattern.
         */
        public static void Task1()
        {
            Console.WriteLine("Keep enter the names of users that have liked the post (To enter text \'q\'):");
            var userList = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "q") break;
                userList.Add(input);
                switch (userList.Count)
                {
                    case 1:
                        Console.WriteLine($"{userList[0]} likes your post");
                        break;
                    case 2:
                        Console.WriteLine($"{userList[0]} and {userList[1]} like your post");
                        break;
                    default:
                        Console.WriteLine($"{userList[0]}, {userList[1]} and {userList.Count - 2} others like your post");
                        break;
                }
            }
        }

        /*
         * Write a program and ask the user to enter their name. Use an array to reverse the name and then
         * store the result in a new string. Display the reversed name on the console. 
         */
        public static void Task2()
        {
            Console.Write("Please, enter your name: ");
            char[] array = new char[100];
            array = Console.ReadLine().ToCharArray();
            Array.Reverse(array);
            var reversedName = new string(array);
            Console.WriteLine($"Reversed name is {reversedName}");
        }

        /*
         * Write a program and ask the user to enter 5 numbers.If a number has been previously 
         * entered, display an error message and ask the user to re-try. Once the user successfully 
         * enters 5 unique numbers, sort them and display the result on the console.
         */
        public static void Task3()
        {
            Console.WriteLine("Enter five uniq numbers, pls: ");
            var numbers = new List<int>();
            while (numbers.Count != 5)
            {
                try
                {
                    numbers.Add(Convert.ToInt32(Console.ReadLine()));

                }
                catch (Exception)
                {
                    Console.WriteLine("Try to re-enter the number.");
                }
            }
            numbers.Sort();
            Console.Write("Excellent! Here your numbers in sorteed order: ");
            foreach (var number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        /*
         * Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
         * The list of numbers may include duplicates.Display the unique numbers that the user has entered.
         */
        public static void Task4()
        {
            Console.WriteLine("Enter a number or type \"Quit\" to exit, please:");
            var uniqNumbers = new List<decimal>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Quit") break;
                var newNumber = Convert.ToDecimal(input);
                if (uniqNumbers.Contains(newNumber))
                {
                    continue;
                }
                uniqNumbers.Add(newNumber);
            }
            Console.WriteLine("The list of uniq numbers:");
            foreach (var item in uniqNumbers)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        /* 
         * Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
         * If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to 
         * re-try; otherwise, display the 3 smallest numbers in the list.
         */
        public static void Task5()
        {
            Console.WriteLine("Supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10)");
     
            while (true)
            {
                var numbers = new List<decimal>();
                var input = Console.ReadLine();
                if (input == "q") break;

                try
                {
                    var stringNumbers = input.Split(", ");
                    foreach (var item in stringNumbers)
                    {
                        numbers.Add(Convert.ToDecimal(item));
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid list. Try to re-enter.");
                    continue;
                }

                if (numbers.Count < 5)
                {
                    Console.WriteLine("Invalid list. Try to re-enter.");
                    continue;
                }

                numbers.Sort();

                Console.Write("Three smallest numbers in the list are ");

                for (int i = 0; i < 3; i++)
                {
                    Console.Write($"{numbers[i]} ");
                }

                Console.WriteLine();
            }
        }
    }
}