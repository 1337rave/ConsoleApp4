using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows in the 2D array:");
        int rows = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of columns in the 2D array:");
        int columns = int.Parse(Console.ReadLine());

        int[,] array = new int[rows, columns];

        Console.WriteLine("Enter the elements of the 2D array:");

        for (int i = 0; i < rows; i++)
        {
            string input = Console.ReadLine();
            string[] elements = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < columns; j++)
            {
                array[i, j] = int.Parse(elements[j]);
            }
        }

        int min = FindMinValue(array);
        int max = FindMaxValue(array);

        Console.WriteLine($"Minimum value in the 2D array: {min}");
        Console.WriteLine($"Maximum value in the 2D array: {max}");

        Console.ReadLine(); // Pause the console
    }

    static int FindMinValue(int[,] array)
    {
        int min = array[0, 0];
        foreach (int element in array)
        {
            if (element < min)
            {
                min = element;
            }
        }
        return min;
    }

    static int FindMaxValue(int[,] array)
    {
        int max = array[0, 0];
        foreach (int element in array)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }
}
