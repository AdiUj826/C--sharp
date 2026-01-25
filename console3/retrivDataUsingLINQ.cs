using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
    internal class retrivDataUsingLINQ
    {

        public static void linq()
        {
           int[] age = { 22,11,54,56,78,23,23,11,12,12};
          var a  = from i in age where i > 20 orderby i select i;////orderby means sorting 
            foreach (var item in a)/// var means data type is decided at runtime
            {
                Console.WriteLine(item);
            }
     
        }
        }
}
