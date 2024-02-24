using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers separated by spaces:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Enter the sequence to find:");
        string sequenceInput = Console.ReadLine();

        string[] sequence = sequenceInput.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int count = CountSequenceOccurrences(numbers, sequence);

        Console.WriteLine($"Number of times the sequence appears: {count}");

        Console.ReadLine(); // Pause the console
    }

    static int CountSequenceOccurrences(string[] numbers, string[] sequence)
    {
        int count = 0;

        for (int i = 0; i <= numbers.Length - sequence.Length; i++)
        {
            bool sequenceFound = true;

            for (int j = 0; j < sequence.Length; j++)
            {
                if (numbers[i + j] != sequence[j])
                {
                    sequenceFound = false;
                    break;
                }
            }

            if (sequenceFound)
            {
                count++;
            }
        }

        return count;
    }
}
