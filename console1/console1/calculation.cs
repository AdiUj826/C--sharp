using System;
using System.Collections.Generic;
using System.Text;

namespace console1
{
    internal class program
    {

        int a = 10, b = 20, c;
        internal void add()
        {
            c = a + b;
            Console.WriteLine(c);
        }
        internal void sub()
        {
            c = a - b;
            Console.WriteLine(c);
        }
        internal void mul()
        {
            c = a * b;
            Console.WriteLine(c);
        }
        internal void div()
        {
            c = a / b;
            Console.WriteLine(c);
        }

    }
}
