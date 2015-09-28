using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSubstring
{
    static void Main()
    {
        string stringInput = Console.ReadLine().ToLower();
        string stringToCheck = Console.ReadLine().ToLower();

        int count = stringInput.Select((c,i) => stringInput.Substring(i)).Count(sub => sub.StartsWith(stringToCheck));
        Console.WriteLine(count);
    }
}
