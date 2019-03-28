using System;
using System.Collections.Generic;
using System.Text;

namespace NonPrimitiveTypes
{
    public static class NonPrimitiveTypes
    {
        public static void DivisibleByThree()
        {
            var counter = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0) counter++;
            }
            Console.WriteLine($"There are {counter} numbers between 0 and 100 that are divisible by 3 with no reminder.");
        }

        public static void SumOfEnteredNumbers() {
            Console.WriteLine("Enter the numbers, please. Text \'ok\' when you done:");
            int summ = 0;
            while (true)
            {
                var userInput = Console.ReadLine();
                if (userInput == "ok")
                {
                    Console.WriteLine($"The summ of all entered numbers is {summ}");
                    break;
                }
                else
                {
                    summ += Convert.ToInt32(userInput);
                }
            }
        }

        public static int Factorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }

        public static void CalculateFactorial()
        {
            Console.Write("Enter the number to calculate its factorial, please: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Its factorial equals to {Factorial(number)}");
        }

        public static void GuessTheNumber()
        {
            var random = new Random();
            while (true)
            {
                var secretNumber = random.Next(0, 10);
                Console.WriteLine("Guess the number between one to ten. You have four tries.");
                for (int i = 1; i <= 4; i++)
                {
                    Console.Write($"{i}: ");
                    var guess = Convert.ToInt32(Console.ReadLine());
                    if (guess == secretNumber)
                    {
                        Console.WriteLine("Congratilations!!! You win!!!");
                        break;
                    }
                    else if (i == 4)
                    {
                        Console.WriteLine($"Sorry, but you loose. The correct answer was {secretNumber}");
                    }
                }
                Console.Write("Wish to repeat? (Y/N): ");
                if (Console.ReadLine() == "N") break;
            }
        }
    }
}