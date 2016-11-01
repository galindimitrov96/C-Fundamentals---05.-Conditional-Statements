using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
                if (1 <= a && a <= 3)
                {
                        int newScore = a * 10;
                        Console.WriteLine(newScore);
                }
                else if (4 <= a && a <= 6)
                {
                    int newScore = a * 100;
                    Console.WriteLine(newScore);
                }
                else if (7 <= a && a <= 9 )
                {
                  int newScore = a * 1000;
                  Console.WriteLine(newScore);
                }
            
            else
            {
                Console.WriteLine("invalid score");
            }
        }
    }
}
