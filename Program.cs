using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the array elements separated by spaces:");
        string input = Console.ReadLine();

        int[] array = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                           .Select(int.Parse)
                           .ToArray();

        int evenCount = CountEvenNumbers(array);
        int oddCount = CountOddNumbers(array);
        int uniqueCount = CountUniqueNumbers(array);

        Console.WriteLine($"Number of even elements: {evenCount}");
        Console.WriteLine($"Number of odd elements: {oddCount}");
        Console.WriteLine($"Number of unique elements: {uniqueCount}");

        Console.ReadLine(); // Pause the console
    }

    static int CountEvenNumbers(int[] array)
    {
        return array.Count(x => x % 2 == 0);
    }

    static int CountOddNumbers(int[] array)
    {
        return array.Count(x => x % 2 != 0);
    }

    static int CountUniqueNumbers(int[] array)
    {
        return array.Distinct().Count();
    }
}
