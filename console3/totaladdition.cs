using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
    internal class totaladdition
    {
  public static  void addition()
        {

            int sum = 0;
            int[] total = { 1, 2, 3, 4 };
            for (int i = 0; i < total.Length; i++)
            {
                sum = sum + total[i];
            }
            Console.WriteLine(sum);
        }
    }
}
