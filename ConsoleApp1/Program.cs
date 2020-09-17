using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class Program
    {
        static void Main(string[] args)
        {
            double[][] dArray = new double[2][]; //needs to be a new double[2][];
            dArray[1] = new double[2];
            dArray[2] = new double[1]; //needs semicolon


            dArray[1][2] = 5.67; //out of bounds error



        }
    }


}
