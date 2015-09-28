using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LastDigitOfNumber
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        string[] digitAsWord = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        Console.WriteLine(digitAsWord[GetLastDigitAsWord(input)]);
    }
    static int GetLastDigitAsWord(int number)
    {
        int lastDigit = number % 10;
        return lastDigit;
    }
}