using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoToYes
{
    class Program
    {
        //read through the string and turn all the "no"s into "yes"
        static void Main(string[] args)
        {
            string temp = "";
            string newString= "";
            string input;
            int yescounter = 0;
            int counter = 0;

            Console.WriteLine("Enter a string");
            input = Console.ReadLine();
            input = input.ToLower();
            for(int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'n' && input[i + 1] == 'o')
                {
                    try
                    {
                        temp = input.Substring(newString.Length - yescounter, counter);
                    }
                    catch
                    {
                        temp = "";
                    }

                    newString += temp + "yes";
                    yescounter++;
                    counter = 0;
                    
                }
                Console.WriteLine(newString);
                counter++;
            }
            
        }
    }
}
