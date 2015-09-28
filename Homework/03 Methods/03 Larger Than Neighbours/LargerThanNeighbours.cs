using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LargerThanNeighbours
{
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsBiggerThanNeighbours(numbers, i));
        }
    }

    static bool IsBiggerThanNeighbours(int[] testArr, int testPosition)
    {
        bool isBigger = false;
        if (testPosition == 0)
        {
            if (testArr[testPosition] > testArr[testPosition + 1])
            {
                isBigger = true;
            }
        }
        else if (testPosition == testArr.Length - 1)
        {
            if (testArr[testPosition] > testArr[testPosition - 1])
            {
                isBigger = true;
            }
        }
        else
        {
            if (testArr[testPosition] > testArr[testPosition - 1] && testArr[testPosition] > testArr[testPosition + 1])
            {
                isBigger = true;
            }
        }

        return isBigger;
    }
}