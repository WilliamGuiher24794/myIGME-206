using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            string input = "";
            bool valid = false;
            Console.Write("Enter a number: ");
            do
            {
                input = Console.ReadLine();
                try
                {
                    number = Convert.ToInt32(input);
                    valid = true;
                }
                catch
                {
                    Console.Write("Enter a number: ");
                }

            } while (!valid);

            for (int i = 1; i < number; i++)
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
