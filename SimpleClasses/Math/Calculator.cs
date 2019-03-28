using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleClasses.Math
{
    class Calculator
    {
        public static int CalcAge(DateTime BirthDate)
        {
            var _currentDate = DateTime.Now;
            var age = Convert.ToInt32((_currentDate - BirthDate).TotalDays / 365);

            return age;
        }
    }
}