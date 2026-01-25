using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
  internal class compountIntersest

    {
public  static void cint()
        {
            int principle, rate, time, ci;
                        Console.WriteLine("Enter Principle Amount:");
            principle = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Rate of Interest:");
            rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Time in years:");
            time = Convert.ToInt32(Console.ReadLine());
            ci = (int)(principle * Math.Pow((1 + rate / 100.0), time) - principle);
            Console.WriteLine("Compound Interest is: " + ci);
        }


    }
}
