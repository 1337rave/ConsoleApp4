using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        int vowelCount = CountVowels(sentence);

        Console.WriteLine($"Number of vowels in the sentence: {vowelCount}");

        Console.ReadLine(); // Pause the console
    }

    static int CountVowels(string sentence)
    {
        int count = 0;
        foreach (char c in sentence)
        {
            if (IsVowel(c))
            {
                count++;
            }
        }
        return count;
    }

    static bool IsVowel(char c)
    {
        switch (char.ToLower(c))
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                return true;
            default:
                return false;
        }
    }
}
