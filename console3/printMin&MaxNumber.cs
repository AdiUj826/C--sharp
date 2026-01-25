using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
    internal class printMin_MaxNumber
    {
        public static void printMinMax()
        {
            int[] total = { 1, 2, 3, 4, -5, -6, 7, 8, 9 };
            int min = total[0];
            int max = total[0];
            for (int i = 1; i < total.Length; i++)
            {
                if (total[i] < min)
                {
                    min = total[i];
                }
                if (total[i] > max)
                {
                    max = total[i];
                }
            }
          
            Console.WriteLine("Minimum number is: " + min);
            Console.WriteLine("Maximum number is: " + max);

        }
    }
}         