using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalComputation
{
    public class PrimeNumber
    {
        public void primenumber()
        { 
        int num, count = 0;
            Console.WriteLine("enter your number : ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > 1)
            {
                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        count++;
                }
                if (count == 2)
                {
                    Console.WriteLine(" entered number is a prime number");
                }
                else
                { 
                Console.WriteLine("this is not a prime number");
                }

            }
            else
            {
                Console.WriteLine("this is not a prime number");
            }
        }
    }
}
