using System;

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
        }
    }
}