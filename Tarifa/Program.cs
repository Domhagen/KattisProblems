using System;

namespace Tarifa
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many months you want to calculate usage for?");
            int theseMonths = Convert.ToInt32(Console.ReadLine());
            int megaBytesPerMonth = 10;
            int usedMB = megaBytesCalculateUsage();
            int megaBytesCalculateUsage()
            {
                int total = 0;
                for (int i = 0; i < theseMonths; i++)
                {
                    int maxValue = megaBytesPerMonth * (i + 1) - total;
                    Console.WriteLine($"Mb used month {i + 1}");
                    int MbEveryMonth = Convert.ToInt32(Console.ReadLine());
                    if (MbEveryMonth > maxValue)
                    {
                        megaBytesCalculateUsageToMuch();
                    }
                    total = total + MbEveryMonth;
                    int megaBytesCalculateUsageToMuch()
                    {
                        Console.WriteLine($"Cant be more than {maxValue}");
                        int MbEveryMonthNew = Convert.ToInt32(Console.ReadLine());
                        if (MbEveryMonthNew <= maxValue)
                        {
                            MbEveryMonth = MbEveryMonthNew;
                            return MbEveryMonth;
                        }
                        else return megaBytesCalculateUsageToMuch();
                    }
                }
                return total;
            }
            Console.WriteLine($"You have {megaBytesPerMonth * theseMonths - usedMB}MB left after {theseMonths} months");
        }
    }
}