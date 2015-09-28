using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class UnicodeCharacters
{
    static void Main()
    {
        string text = Console.ReadLine();
        string unicode = "";
        foreach (char i in text)
        {
            unicode += "\\u" + ((int)i).ToString("X4");
        }
        Console.WriteLine(unicode);
    }
}