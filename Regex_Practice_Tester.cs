```CSharp
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Enter a regex pattern:");
            string pattern = Console.ReadLine();

            if (string.IsNullOrEmpty(pattern))
            {
                break;
            }

            Console.WriteLine("Enter some input to test against the pattern:");
            string input = Console.ReadLine();

            Regex regex = new Regex(pattern);

            if (regex.IsMatch(input))
            {
                Console.WriteLine("Match found!");
            }
            else
            {
                Console.WriteLine("No match found.");
            }
        }
    }
}
```