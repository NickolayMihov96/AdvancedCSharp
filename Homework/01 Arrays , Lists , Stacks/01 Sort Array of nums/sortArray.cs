using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class sortArray
{
    static void Main()
    {
        int[] arrayOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Array.Sort(arrayOfNums);

        foreach (int number in arrayOfNums)
        {
            Console.Write(number);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}