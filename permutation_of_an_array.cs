using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        // Create a random number generator
        Random rand = new Random();

        // Perform Fisher-Yates shuffle
        for (int i = array.Length - 1; i > 0; i--)
        {
            // Generate a random index between 0 and i (inclusive)
            int j = rand.Next(0, i + 1);

            // Swap array[i] and array[j]
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        // Print the shuffled array
        Console.WriteLine("Random permutation of the array:");
        foreach (var element in array)
        {
            Console.Write(element + " ");
        }

        Console.WriteLine();
    }
}
