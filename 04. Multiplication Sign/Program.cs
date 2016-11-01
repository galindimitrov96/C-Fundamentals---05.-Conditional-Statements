using System;

namespace HW04MultiplicationSign
{
    class SignDisplayer
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());
            if (A == 0 || B == 0 || C == 0)
            {
                Console.WriteLine("0");
            }
            else if ((A > 0 && B > 0 && C > 0) || (A > 0 && B < 0 && C < 0) || (A < 0 && B < 0 && C > 0) || (A < 0 && B > 0 && C < 0))
            {
                Console.WriteLine("+");
            }
            else
                Console.WriteLine("-");
        }
    }
}