using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TextFilter
{
    static void Main()
    {
        var bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string text = Console.ReadLine();

        text = bannedWords.Aggregate(text, (current, word) => current.Replace(word, new string('*', word.Length)));
        Console.WriteLine(text);
    }
}