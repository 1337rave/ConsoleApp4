using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence:");
        string sentence = Console.ReadLine();

        string reversedSentence = ReverseWords(sentence);

        Console.WriteLine($"Reversed sentence: {reversedSentence}");

        Console.ReadLine(); // Pause the console
    }

    static string ReverseWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = ReverseString(words[i]);
        }
        return string.Join(" ", words);
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
