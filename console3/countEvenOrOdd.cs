using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console3
{
    internal class countEvenOrOdd
    {
        public static void countNumber()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int evenNumber = 0;
            int OddNumber = 0;
            for(int i=0; i < arr.Length; i++)
            {
                if (arr[i]  %2==0)
                {
                    evenNumber++;

                }
                if(arr[i] %2 != 0)
                {
                    OddNumber++;
                }
               
            }
            Console.WriteLine("EvenNumber is :" + evenNumber);
            Console.WriteLine("OddNumber is :" + OddNumber);

        }
    }
}
