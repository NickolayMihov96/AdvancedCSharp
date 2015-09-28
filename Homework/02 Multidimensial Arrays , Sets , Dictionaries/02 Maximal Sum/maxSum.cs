using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class maxSum
{
    static void Main()
    {
        int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[,] matrix = new int[inputArray[0] , inputArray[1]];
        int[,] insideMatrix = new int[3, 3];
        List<int> bestMatrixNumbers = new List<int>();
        int bestSum = int.MinValue;
        int counterRow = 0;
        int counterCol = 0;

        for (int row = 0; row < inputArray[0]; row++)
        {
            string inputNumber = Console.ReadLine();
            string[] elements = inputNumber.Split(' ');

            for (int col = 0; col < inputArray[1]; col++)
            {               
                matrix[row, col] = int.Parse(elements[col]);
            }
         }

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row , col + 2] + 
                          matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                          matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestMatrixNumbers.Clear();

                    for (int i = 0; i < 3; i++)
                    {

                        for (int j = 0; j < 3; j++)
                        {
                            bestMatrixNumbers.Add(matrix[i + counterRow, j + counterCol]);

                        }

                    }
                }              
            }
              counterRow++;
              counterCol++;
        }
        Console.WriteLine("Sum = {0}" , bestSum);
        int counter = 0;

        while (counter < 9)
        {
            Console.Write("{0} ", bestMatrixNumbers[counter]);
            if (counter == 2 || counter == 5 || counter == 8)
            {
                Console.WriteLine();
            }
            counter++;
        }
    }
}