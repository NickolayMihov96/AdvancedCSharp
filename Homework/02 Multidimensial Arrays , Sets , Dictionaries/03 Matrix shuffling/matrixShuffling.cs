using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class matrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
                
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        string command = Console.ReadLine();
        do
        {           
            string[] commandArray = command.Split(' ');
            
            if (commandArray[0] == "swap")
            {
                
                int x1 = int.Parse(commandArray[1]);
                int y1 = int.Parse(commandArray[2]);
                int x2 = int.Parse(commandArray[3]);
                int y2 = int.Parse(commandArray[4]);

                if (x1 < rows && y1 < cols && x2 < rows && y2 < cols)
                {
                    string tempMatrix = matrix[x1, y1];
                    matrix[x1,y1] = matrix[x2,y2];
                    matrix[x2, y2] = tempMatrix;

                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            Console.Write("{0} " , matrix[i,j]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");

            }
            command = Console.ReadLine();
        } while (command != "END");

    }
}