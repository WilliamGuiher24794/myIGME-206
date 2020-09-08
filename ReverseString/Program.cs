using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        //gets input from the user
        //and displays the input backwords
        static void Main(string[] args)
        {
            string input;
            
            //have user enter the string
            Console.WriteLine("Enter any string that you want");
            input = Console.ReadLine();

            //start from the end of the string and work back to the front entering one leter at a time
            for(int i = input.Length-1; i >= 0; i--)
            {
                Console.Write(input[i]);
            }
            Console.WriteLine();
        }
    }
}
