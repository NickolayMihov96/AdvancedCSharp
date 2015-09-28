using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseNumber
{
    static void Main()
    {
        double inputNumber = double.Parse(Console.ReadLine());

        double reversed = GetReversedNumber(inputNumber);
        Console.WriteLine(reversed);
    }

    private static double GetReversedNumber(double numberToReverse)
    {
        bool isNegative = numberToReverse < 0;
        string input = string.Join("", numberToReverse.ToString().TrimStart('-').Reverse());
        double number = double.Parse(input);
        return isNegative ? -number : number;
    }
}