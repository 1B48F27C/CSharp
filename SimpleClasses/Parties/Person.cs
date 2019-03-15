using SimpleClasses.Math;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClasses.Parties
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public void Introduce()
        {
            var _currentDate = DateTime.Now;
            var age = Calculator.CalcAge(BirthDate);
            Console.WriteLine($"Hey, my name is {FirstName} {LastName}. I'm {age} years old.");
        }
    }
}
