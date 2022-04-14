using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalComputation
{
    public class monthlypayment
    {
        public void monthly_payment()
        {
            
            Console.WriteLine("enter your principle : ");
            float P = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter no of year : ");
            float Y = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("enter rate of interest : ");
            float R = Convert.ToSingle(Console.ReadLine());

            float n = 12 * Y;
            float r = R / (12 * 100);
            float payment = 0;

            payment = (float)(P * r / 1 - Math.Pow((1+r),(-n)));
            Console.WriteLine(payment);
        }
    }
}
