using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalComputation
{
    public class PerfectNumber
    {
        public void perfectnumber()
        {
            int number, i, rem, sum = 0;
            Console.WriteLine("enter your number: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i < number; i++) //6 5
            {
                rem = number % i;
                if (rem == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine(number +"  " + "is a perfect number");
            }
            else
            { 
            Console.WriteLine(number + "  " + "is not a perfect number");
            }


        }
    }
}
