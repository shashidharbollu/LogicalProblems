using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalComputation
{
    public class temperature
    {
        public static void temp_()
        {
          float  c, fh;
            Console.WriteLine("enter temperature in centigrade");
          c = Convert.ToSingle(Console.ReadLine());

            fh = (float) ((c * 9/5.0) + 32);
            Console.WriteLine("TEMPERATURE IN FAHRENHEIT IS " + " " + fh);
        }
        
        
    }
}
