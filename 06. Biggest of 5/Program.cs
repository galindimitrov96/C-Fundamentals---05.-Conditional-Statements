﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Biggest_of_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            double num4 = double.Parse(Console.ReadLine());
            double num5 = double.Parse(Console.ReadLine());
            if ((num1 == num2) && (num2 == num3) && (num3 == num4) && (num4 == num5))
            {
                Console.WriteLine(num3);
            }
            else if ((num1 > num2) && (num1 > num3) && (num1 > num4) && (num1 > num5))
            {
                Console.WriteLine(num1);
            }
            else if ((num2 > num1) && (num2 > num3) && (num2 > num4) && (num2 > num5))
            {
                Console.WriteLine(num2);
            }
            else if ((num3 > num1) && (num3 > num2) && (num3 > num4) && (num3 > num5))
            {
                Console.WriteLine(num3);
            }
            else if ((num4 > num1) && (num4 > num2) && (num4 > num3) && (num4 > num5))
            {
                Console.WriteLine(num4);
            }
            else 
            {
                Console.WriteLine(num5);
            }
          
        }
    }
}
