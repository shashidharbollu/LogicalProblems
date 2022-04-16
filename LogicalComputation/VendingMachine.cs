using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalComputation
{
    public class VendingMachine
    {
        public void vending_machine()
        {
            int[] notes = { 1000, 500, 100, 50, 50, 20, 10, 5, 2, 1 };
            int[] frequency = new int[notes.Length];
            Console.WriteLine("enter your amount");
            int amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < frequency.Length; i++)
            {
                if (amount > 0)
                {

                    frequency[i] = amount / notes[i];
                    amount -= frequency[i]*notes[i];
                        
                }
            }
            for (int i = 0; i < frequency.Length; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine(notes[i] + " -------->" + frequency[i]);
                }

            }

        }
    }
}
