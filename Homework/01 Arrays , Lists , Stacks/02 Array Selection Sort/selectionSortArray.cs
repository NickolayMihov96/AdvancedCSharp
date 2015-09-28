using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class selectionSortArray
{
    static void Main()
    {
        int[] arrayOfNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int temp;

        for (int i = 0; i < arrayOfNums.Length; i++)
        {
            for (int j = 0; j < arrayOfNums.Length-1; j++)
            {
                if (arrayOfNums[j] > arrayOfNums[j + 1])
                {
                    temp = arrayOfNums[j + 1];
                    arrayOfNums[j + 1] = arrayOfNums[j];
                    arrayOfNums[j] = temp;
                }
            }
        }
        foreach (int number in arrayOfNums)
        {
            Console.Write(number);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}