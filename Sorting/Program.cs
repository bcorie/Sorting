/*
 * Corie Beale
 * IGME 206
 * E12 - Sorting
 */

using System.Globalization;

namespace Sorting;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter an odd size for the array: ");
        string input = Console.ReadLine()!;
        while (!Int32.TryParse(input, out int value) || Int32.Parse(input) % 2 != 1 || Int32.Parse(input) < 1)
        {
            Console.WriteLine("Invalid input. Must be a positive, odd, non-zero integer.");
            Console.WriteLine("Enter a size for the array: ");
            input = Console.ReadLine()!;
        }
        int size = Int32.Parse(input);
        string[][] array = CreateArray(size);

        Console.WriteLine("Array created:\n");
        PrintArray(array);

        array = SortArray(array);
        Console.WriteLine("Sorted array:\n");
        PrintArray(array);
    }
    
    public static string[][] CreateArray(int columns)
    {
        string[][] array = new string[columns][];
        Random rand = new Random();
        int rowSize;
        for (int i = 0; i < columns; i++)
        {
            rowSize = rand.Next(0, 4); // 0 to 3 inclusive
            array[i] = new string[rowSize];
        }
        return array;
    }

    public static void PrintArray(string[][] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            foreach (string s in array[i])
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }

    public static string[][] SortArray(string[][] array)
    {
        int 
        // traversal
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i+1] )
        }
        /*
         * find largest row size
         * add to 0 index
         * find second largest
         * add to 1
         * etc.
         */
    }
}