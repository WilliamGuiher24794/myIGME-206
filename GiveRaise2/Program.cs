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

        struct employee{
            public string sName;
            public double dSalary;
            
            
        }

        static void Main(string[] args)
        {
            employee worker;
            worker = new employee();
            worker.dSalary = 30000;
            Console.WriteLine("What is your name: ");
            worker.sName = Console.ReadLine();


            GiveRaise(worker);

            Console.WriteLine("Name: " + worker.sName);
            Console.WriteLine("Salary: " + worker.dSalary);
        }

        static bool GiveRaise(employee worker)
        {
            bool returnVal = false;
            if (worker.sName == "william")
            {
                returnVal = true;
                worker.dSalary += 19999.99;
            }
            return returnVal;
        }
    }
}
