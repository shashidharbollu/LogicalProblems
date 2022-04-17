using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalComputation
{
    public class BinaryConversion
    {
        public void Binary_conversion()
        {
            int i = 0, j;
            Console.WriteLine("Enter your number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[num];

            while (num > 0)
            {
                a[i] = num % 2;
                num = num / 2;
                i++;
            }
            for (j = i - 1; j >= 0; j--)
            { 
                Console.WriteLine(" "  + a[j]);
            
            }

        }
    }
}