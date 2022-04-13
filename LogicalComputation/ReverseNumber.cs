using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalComputation
{
    public class ReverseNumber
    {
        public void revese_number()
        {
            int num, rev = 0;
            Console.WriteLine("enter your number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine(rev + " " + "is the reversed number");
           
        }
    }
}
