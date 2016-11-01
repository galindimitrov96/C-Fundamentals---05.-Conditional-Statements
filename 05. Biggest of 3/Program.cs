using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Biggest_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            if ((num1  > num2) && (num1 > num3))
            {
                Console.WriteLine("{0}", num1);
            }
            else if ((num2 > num1) && (num2 > num3))
            {
             Console.WriteLine("{0}",num2);
            }
            else if ((num3 > num1) && (num3 > num2))
            {
                Console.WriteLine("{0}", num3);
            }
            else if ((num1 == num2) && (num2 == num3))
            {
                Console.WriteLine("{0}", num2);
            }
        }
    }
}
