using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the input string:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the substring to search for:");
        string substring = Console.ReadLine();

        int occurrences = CountSubstringOccurrences(input, substring);

        Console.WriteLine($"Number of occurrences of the substring: {occurrences}");

        Console.ReadLine(); // Pause the console
    }

    static int CountSubstringOccurrences(string input, string substring)
    {
        int count = 0;
        int index = 0;

        while ((index = input.IndexOf(substring, index, StringComparison.OrdinalIgnoreCase)) != -1)
        {
            count++;
            index += substring.Length;
        }

        return count;
    }
}
