using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedLimit
{
    class Program
    {
        static int hoursDriven;
        static void Main(string[] args)
        {
            Console.WriteLine("Total time driving");
            int totalHoursDriven = int.Parse(Console.ReadLine());

            List<int> casesTimeDriven = new List<int>();

            List<int> speedCases = new List<int>();

            int a = 1;
            while(totalHoursDriven > hoursDriven)
            {
                Console.WriteLine($"Speed in case {a}");
                int speedCase = int.Parse(Console.ReadLine());
                speedCases.Add(speedCase);
                Console.WriteLine($"Hours in case {a}");
                int hoursCase = int.Parse(Console.ReadLine());
                speedCases.Add(hoursCase);

                int caseTimeDriven = speedCase * hoursCase;
                casesTimeDriven.Add(caseTimeDriven);

                a++;

                hoursDriven = hoursDriven + hoursCase;
            }

            int total = 0;
            foreach(int item in casesTimeDriven)
            {
                total = total + item;
            }
            
            Console.WriteLine(total);
        }
    }
}
