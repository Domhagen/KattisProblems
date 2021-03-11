using System;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            int theseMonths = Convert.ToInt32(Console.ReadLine());
            int megaBytes = 100;
            int megaBytesPerMonth()
            {
                int total = 0;
                for (int i = 0; i < theseMonths; i++)
                {
                    Console.WriteLine($"Mb used month {i + 1}");
                    int MbEveryMonth = Convert.ToInt32(Console.ReadLine());
                    total = total + MbEveryMonth;
                }
                return total;
            }
            Console.WriteLine($"{megaBytesPerMonth()}");
        }
    }
}
