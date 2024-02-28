/* Here is the Bubble sort Algorithms. No input is required for the script. It will execute without input against two pre-populated arrays
 * Auther:Vasudeva reddy Bolleddula
 * Publish: 28th Feb 2024*/




using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        int[] array = { 5,72,3,14,7,1 };

        Console.WriteLine("Here is the original array that will be used to execute the Bubble Sort Algorithm:");
        PrintArray(array);

        BubbleSortArray(array);

        Console.WriteLine("\nHere is the array after the execution of the Bubble Sort Algorithm:");
        PrintArray(array);
    }

    static void BubbleSortArray(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                }
            }
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
