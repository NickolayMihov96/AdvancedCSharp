using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class fillTheMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix1 = new int[n, n];
        int[,] matrix2 = new int[n, n];
        int counter1 = 1;  // counter for matrix1
        int counter2 = 1; // counter for matrix2
        
        //fill the matrix1
       
        Console.WriteLine();
       
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {                
                matrix1[row, col] = counter1;
                Console.Write(matrix1[row, col] + " ");
                counter1 += n;

                if (col == n - 1)
                {
                    counter1 = row+2;
                    break;                   
                }
            }
            Console.WriteLine();
        }

        //fill the matrix2
       
        for (int col = 0; col < n; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix2[row, col] = counter2;
                    counter2++;
                }
            }
            else
            {
                for (int row = n - 1; row >= 0; row--)
                {
                    matrix2[row, col] = counter2;
                    counter2++;
                }
            }
        }
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}