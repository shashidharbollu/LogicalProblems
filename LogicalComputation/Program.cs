﻿using System;
using LogicalComputation;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("welcome to my logical programmes, please chose your option :  ");
        bool end = true;

        while (end)
        {
            Console.WriteLine("1.fibonacciseries\n 2.perfectnumber\n 3.primenumber\n 4.reversesumber\n 5.temperature\n 6.dayofweek\n 7.monthlypayment\n end the programme. ");
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
                case 3:
                    PrimeNumber p = new PrimeNumber();
                    p.primenumber();
                    break;
                case 4:
                    ReverseNumber r = new ReverseNumber();
                    r.revese_number();
                    break;
                case 5:
                    temperature.temp_();
                    break;
                case 6: 
                    dayofweek week = new dayofweek();
                    week.dayofweekk();
                    break;
                case 7:
                    monthlypayment montly = new monthlypayment();
                    montly.monthly_payment();
                    break;
                

                default:
                    Console.WriteLine("choose a proper option to execute");
                    break;
            }
        }
    }
}

