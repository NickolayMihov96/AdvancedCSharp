using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class equalStrings
{
    static void Main()
    {
        string[] stringSequence = Console.ReadLine().Split(' ').ToArray();

        for (int i = 0; i < stringSequence.Length; i++)
        {

            if (i == stringSequence.Length-1)
            {
                if (stringSequence[i-1] == stringSequence[i])
                {
                    Console.Write("{0} " , stringSequence[i]);
                }
                else
                {
                    Console.WriteLine("{0} ", stringSequence[i]);
                }
            }

            else if (stringSequence[i] == stringSequence[i + 1])
            {
                Console.Write(stringSequence[i] + " ");
            }
            else if (stringSequence[i] != stringSequence[i + 1])
            {
                Console.WriteLine(stringSequence[i]);
            }
        }
        Console.WriteLine();
    }
}