using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
  
    internal class swaping
    {

     static int a = 10, b = 20;
      public  void swap()
        {
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("after swapping a:{0} b:{1}",a,b);
           
           
        }

    }
}
