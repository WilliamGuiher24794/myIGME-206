using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquashTheBugs
{
    // Class Program
    // Author: David Schuh
    // Purpose: Bug squashing exercise
    // Restrictions: None
    class Program
    {
        // Method: Main
        // Purpose: Loop through the numbers 1 through 10 
        //          Output N/(N-1) for all 10 numbers
        //          and list all numbers processed
        // Restrictions: None
        static void Main(string[] args)
        {
            // declare int counter

            //int i = 0 Missing a semicolon
            int i = 0;
            string allNumbers = null;

            // loop through the numbers 1 through 10
            for (i = 1; i < 10; ++i) 
            {
                // declare string to hold all numbers
                //string allNumbers = null; move this before the for loop so your not initallizing the string each time through

                // output explanation of calculation

                //Console.Write(i + "/" + i - 1 + " = "); need parenthesis around the i - 1
                Console.Write(i + "/" + (i - 1) + " = ");

                // output the calculation based on the numbers
                //Console.WriteLine(i / (i - 1)); can cause a divide by zero error

                //testing for a divide by zero error if it does it will equal Undefined instead of crashing
                try
                {
                    Console.WriteLine(i / (i - 1));
                }
                catch
                {
                    Console.WriteLine("Undefined (Divide by zero)");
                }

                // concatenate each number to allNumbers
                allNumbers += i + " ";

                // increment the counter
                i = i + 1;
            }

            // output all numbers which have been processed
            //Console.WriteLine("These numbers have been processed: " allNumbers); need a + between the string and the variable
            Console.WriteLine("These numbers have been processed: " + allNumbers);
        }
    }
}

