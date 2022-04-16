using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalComputation

{
    public class Coupon
    {


        public void PrintCouponNumber()//n=25
        {

            Random random = new Random();
            int n = random.Next(1, 100);
            int count = 0;
            int check = RandomNumber(n);//21
            Console.WriteLine("the coupon number is:" + n);
            Console.WriteLine("the random number got:" + check);
            while (n > 0)
            {
                if (check == n)//21!=25 25==25
                {
                    Console.WriteLine("Congrats!!got the coupon number in first attempt");
                    break;

                }
                count++;//1 2
                Console.WriteLine("count to get coupon number is:" + count);
                n--;
            }
            Console.WriteLine("to get distinct coupon number, the number of times random number used:" + count);//total no of count=2
        }
        private static int RandomNumber(int n)
        {
            Random random = new Random();
            n = random.Next(1, 100);
            return n;
        }
    }
}
                