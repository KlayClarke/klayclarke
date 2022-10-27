﻿using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 51;

            // TODO: if-else 
            if (theVal == 50) {
              Console.WriteLine("theVal is equal to 50");
            }
            else if (theVal >= 51 && theVal <= 60) {
              Console.WriteLine("theVal is between 51 and 60");
            }
            else {
              Console.WriteLine("theVal is not equal to 50");
            }

            // -----------------------
            // TODO: Using the ternary operator ?:

            // a two-case if-then
            /*
            if (theVal < 50) {
                Console.WriteLine("theVal is small");
            }
            else {
                Console.WriteLine("theVal is large");
            }
            */

            Console.WriteLine(theVal < 50 ? "theVal is small" : "theVal is large");

            // TODO: can be replaced by a ternary operator ?:

        }
    }
}
