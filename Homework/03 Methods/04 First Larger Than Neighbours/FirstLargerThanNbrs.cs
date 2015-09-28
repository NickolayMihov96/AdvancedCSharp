using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FirstLargerThanNbrs
{
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceThree = { 1, 1, 1 };

        Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(IndexOfFirstElementLargerThanNeighbours(sequenceThree));
    }

    private static int IndexOfFirstElementLargerThanNeighbours(int[] seq)
    {
        for (int i = 0; i < seq.Length; i++)
        {
            if (IsBiggerThanNeighbours(seq, i))
            {
                return i;
            }
        }
        return -1;
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