using System;
using LogicalComputation;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("welcome to my logical programmes, please chose your option :  ");
        bool end = true;

        while (end)
        {
            Console.WriteLine("1.fibonacciseries\n 2.perfectnumber\n end the programme. ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FibonacciSeries series = new FibonacciSeries();
                    series.fibibonacciseries();
                    break;
                case 2:
                    PerfectNumber n = new PerfectNumber();
                    n.perfectnumber();
                    break;
                

                default:
                    Console.WriteLine("choose a proper number to execute");
                    break;
            }
        }
    }
}

