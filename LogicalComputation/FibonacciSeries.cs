using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalComputation
{
    public class FibonacciSeries
    {
        public void fibibonacciseries()
        {
            int num1 = 0, num2 = 1, sum = 0 ;

            Console.WriteLine(num1+" "+num2);
            for (int i = 2; i < 10; i++)
            { 
            sum = num1 + num2;

                  num1 = num2;
                  num2 = sum;
                Console.WriteLine("  " + sum);
            }

        }
    }
}
