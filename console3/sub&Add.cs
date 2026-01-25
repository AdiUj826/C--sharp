using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{

    internal class sub_Add
    {
        public int num1, num2, sum;

        public void add()
        {
            sum = num1 + num2;
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public void sub()
        {
            sum = num1 - num2;
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
