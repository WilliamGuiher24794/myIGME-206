using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace GiveRaise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            double dSalary = 30000;

            Console.WriteLine("What is your name: ");
            name = Console.ReadLine();
            

            GiveRaise(name, ref dSalary);

            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + dSalary);
        }

        static bool GiveRaise(string name, ref  double salary)
        {
            bool returnVal = false;
            if (name == "william")
            {
                returnVal = true;
                salary += 19999.99;
            }
            return returnVal;
        }
    }
}
