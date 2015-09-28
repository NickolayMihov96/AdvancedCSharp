using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ReverseString
{
    static void Main()
    {
        string input = Console.ReadLine();
        char[] array = input.ToCharArray();
        Array.Reverse(array);
        Console.WriteLine(array);
    }
}