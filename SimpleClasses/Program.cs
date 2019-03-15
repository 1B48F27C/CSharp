using SimpleClasses.Parties;
using System;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var man = new Person();

            man.FirstName = "John";
            man.LastName = "Bolton";
            man.BirthDate = DateTime.Parse("04.07.1984");

            man.Introduce();
        }
    }
}
