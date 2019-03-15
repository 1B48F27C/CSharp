 using System;

namespace NonPrimitiveTypes
{
    public enum DocumentTypes {
        Visa = 000,
        DomesticPassport = 111,
        MigrationCard = 222
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            var arrayOfNumbers = new int[] {
                4, 43, 34
            };
            foreach (var item in arrayOfNumbers)
            {
                Console.WriteLine("{0}", item);
            }
            Console.WriteLine();
            var arrayOfStrings = new string[] {
                "Hello",
                "World"
            };
            foreach (var item in arrayOfStrings)
            {
                Console.Write("{0}", item);
            }
            Console.WriteLine();
            #endregion Arrays

            #region Enums
            var myDocumentType = DocumentTypes.DomesticPassport;
            Console.WriteLine("My document type is {0}. Its number is {1}", myDocumentType, (int) myDocumentType);
            #endregion Enums

            #region String
            var password = Cifer.GenerateCifer(10);
            Console.WriteLine($"Password is: {password}");
            #endregion String

            #region Tasks
            Tasks.DivisibleByThree();
            Tasks.SumOfEnteredNumbers();
            Tasks.CalculateFactorial();
            Tasks.GuessTheNumber();
            #endregion Tasks
        }
    }
}
