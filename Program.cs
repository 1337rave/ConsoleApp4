using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the array elements separated by spaces:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter the threshold value:");
        int threshold = int.Parse(Console.ReadLine());

        string[] elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] array = new int[elements.Length];

        for (int i = 0; i < elements.Length; i++)
        {
            array[i] = int.Parse(elements[i]);
        }

        int countBelowThreshold = CountValuesBelowThreshold(array, threshold);

        Console.WriteLine($"Number of values below {threshold}: {countBelowThreshold}");

        Console.ReadLine(); // Pause the console
    }

    static int CountValuesBelowThreshold(int[] array, int threshold)
    {
        int count = 0;
        foreach (int num in array)
        {
            if (num < threshold)
            {
                count++;
            }
        }
        return count;
    }
}
