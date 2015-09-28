using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class categorizeNums
{
    static void Main()
    {
        double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        List<double> roundNums = new List<double>();
        List<double> floatingPointNums = new List<double>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 1 == 0)
            {
                roundNums.Add(numbers[i]);
            }
            else
            {
                floatingPointNums.Add(numbers[i]);
            }
        }
        
        string floatingPoint = '[' + String.Join(", ", floatingPointNums) + ']';
        string round = '[' + String.Join(", ", roundNums) + ']';

        Console.WriteLine("{0} -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                   floatingPoint, floatingPointNums.Min(),
                   floatingPointNums.Max(), floatingPointNums.Sum(), floatingPointNums.Average());
        
        Console.WriteLine();

        Console.WriteLine("{0} -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
                   round, roundNums.Min(),
                   roundNums.Max(), roundNums.Sum(), roundNums.Average());
        Console.WriteLine();
    }
}