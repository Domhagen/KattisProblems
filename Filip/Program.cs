using System;

namespace Filip
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a three digit long number");
            var inputNumber = Console.ReadLine();
            if (int.TryParse(inputNumber, out int number1))
            {
                int checkIfThreeDigits = 0;
                for (int i = 0; number1 > 0; i++)
                {
                    number1 = number1 / 10;
                    checkIfThreeDigits++;
                }
                if (checkIfThreeDigits != 3)
                {
                    Console.WriteLine("It is not three digits long");
                }
                else
                {
                    Console.WriteLine("It is a correct number! Enter another one");
                }
                var inputNumber2 = Console.ReadLine();
                if (int.TryParse(inputNumber2, out int number2))
                {
                    int checkSecondNumberIfThreeDigits = 0;
                    for (int i = 0; number2 > 0; i++)
                    {
                        number2 = number2 / 10;
                        checkSecondNumberIfThreeDigits++;
                    }
                    if (checkSecondNumberIfThreeDigits != 3)
                    {
                        Console.WriteLine("It is not three digits long");
                    }
                    else
                    {
                        Console.WriteLine("Both numbers are correct!");
                    }
                    
                    int BiggestNumber(int nmr1, int nmr2)
                    {
                        int number = 0;
                        if (nmr1 > nmr2)
                        {
                            number = nmr1;
                            return number;
                        }
                        else
                        {
                            number = nmr2;
                            return number;
                        }
                    }
                    Console.WriteLine($"The biggest number is {BiggestNumber(Convert.ToInt32(inputNumber),Convert.ToInt32(inputNumber2))}");
                    
                    int ReverseNumber(int Biggstnum)
                    {
                        int result = 0;
                        int num = Biggstnum;
                        while (num > 0)
                        {
                            result = result * 10 + num % 10;
                            num = num / 10;
                        }
                        return result;
                    }
                    Console.WriteLine($"Biggest number in reverse is {ReverseNumber(BiggestNumber(Convert.ToInt32(inputNumber), Convert.ToInt32(inputNumber2)))}");

                }
            }
            else
            {
                Console.WriteLine($"{inputNumber} is not a number");
            }
        }
    }
}
