using System;
using System.Collections.Generic;
using System.Text;

namespace NonPrimitiveTypes
{
public static class Cifer
    {
        public static string GenerateCifer(int numberOfCharacters)
        {
            var random = new Random();
            var buffer = new char[numberOfCharacters];
            for (int i = 0; i < numberOfCharacters; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }
            return new string(buffer);
        }
    }
}
