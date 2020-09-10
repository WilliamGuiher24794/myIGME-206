using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaCalculate
{
    class Program
    {
        //calcuate z based on the following x and y values
        static void Main(string[] args)
        {
            double[,,] aZfunction = new double[21, 31, 3];

            double dx, dy, dz;
            int nX, nY;

            nX = 0;


            for(dx = -1; dx <= 1; dx += 0.1)
            {
                dx = Math.Round(dx, 1);
                nY = 0;
                for(dy = -1; dy <= 4; dy += .1)
                {
                    dy = Math.Round(dy, 1);
                    dz = 3 * dy * dy + 2 * dx - 1;
                    dz = Math.Round(dz, 2);

                    aZfunction[nX, nY, 0] = dx;
                    aZfunction[nX, nY, 1] = dy;
                    aZfunction[nX, nY, 2] = dz;
                    nY++;
                }

                nX++;

            }
        }
    }
}
