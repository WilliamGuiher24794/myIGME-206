using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace VariableAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            int num = 0;
            int total = 1;
            bool valid;
            Console.WriteLine("Enter four numbers");
            for(int i = 0; i < 4; i++)
            {
                valid = false;
                do
                {
                    input = Console.ReadLine();
                    try
                    {
                       num = Convert.ToInt32(input);
                        valid = true;
                    }
                    catch
                    {
                        Console.WriteLine("Enter a valid number");
                    }
                } while (!valid);
                total *= num;
            }
            Console.WriteLine("The product of those four numbers are: " + total);
        }

    }
}
