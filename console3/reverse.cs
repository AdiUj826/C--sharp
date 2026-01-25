using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
    internal class reverse
    {
        public static void rev()
        {
            int num, reversedNum = 0, remainder;
            Console.WriteLine("Enter an integer to reverse:");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                remainder = num % 10;
                reversedNum = reversedNum * 10 + remainder;
                num /= 10;
            }
            Console.WriteLine("Reversed Number: " + reversedNum);
        }



    }
}
