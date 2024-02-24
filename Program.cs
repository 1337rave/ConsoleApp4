using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        int wordCount = CountWords(sentence);

        Console.WriteLine($"Number of words in the sentence: {wordCount}");

        Console.ReadLine(); // Pause the console
    }

    static int CountWords(string sentence)
    {
        // Розділення речення на слова за пробілами та пунктуацією
        string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', '?', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}
