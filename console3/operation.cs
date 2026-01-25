using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
    internal class operation
    {

        int a, b, c;
       public void user()
        {
            Console.WriteLine("Enter first number :");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number :");
            b = int.Parse(Console.ReadLine());
        }
       public  void add()
        {
            c = a + b;
            Console.WriteLine(c);
        }
      public  void sub()
        {

            c = a - b;
            Console.WriteLine(c);
        }
      public  void mul()
        {
            c = a * b;
            Console.WriteLine(c);

        }
    public    void div()
        {
            c = a / b;
            Console.WriteLine(c);

        }

    }
}
