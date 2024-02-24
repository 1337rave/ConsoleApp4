using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter elements for the first array separated by spaces:");
        string input1 = Console.ReadLine();
        Console.WriteLine("Enter elements for the second array separated by spaces:");
        string input2 = Console.ReadLine();

        string[] array1 = input1.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string[] array2 = input2.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string[] commonElements = FindCommonElements(array1, array2);

        Console.WriteLine("Common elements without duplicates:");
        Console.WriteLine(string.Join(" ", commonElements));

        Console.ReadLine(); // Pause the console
    }

    static string[] FindCommonElements(string[] array1, string[] array2)
    {
        // Об'єднання двох масивів та видалення дублікатів
        string[] combinedArray = array1.Union(array2).ToArray();
        return combinedArray;
    }
}
