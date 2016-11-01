using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Int__Double_and_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string value = Console.ReadLine();
            switch (type)
            {
                case "integer":
                    int result = Convert.ToInt32(value);
                    Console.WriteLine(++result); break;
                case "real":
                    double result1 = Convert.ToDouble(value);
                    Console.WriteLine("{0:F2}", ++result1);
                    break;
                case "text":
                    Console.WriteLine("{0}*",value);
                    break;
                default:
                    break;
            }
        }
    }
}
