using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class StringLenght
{
    static void Main()
    {
        string input = Console.ReadLine();
        string sub = "";        
        if (input.Length > 20)
        {
            sub = input.Substring(0, 20);
        }
        else if (input.Length < 20)
        {
            Console.Write(input);
            for (int i = input.Length; i < 20; i++)
            {
                Console.Write("*");

            }
        }
        Console.WriteLine(sub);

    }
}