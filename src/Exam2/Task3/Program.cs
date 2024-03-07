using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static string ModifyString(string s)
    {
        string cleanString = Regex.Replace(s, @"[^a-zA-Z0-9_ $]", "");

        cleanString = cleanString.Replace('_', ' ');
        cleanString = cleanString.Replace('$', ' ');

        cleanString = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cleanString.ToLower());

        cleanString = Regex.Replace(cleanString, @"\s+", " ").Trim();

        return cleanString;
    }
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            Console.WriteLine(ModifyString(s));
        }
    }
}