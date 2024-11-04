using System;

class IndexFinder
{
    public int FindIndex(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }

        return -1; // Якщо елемент не знайдено
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 3, 5, 7, 9 };
        int target = 5;
        IndexFinder indexFinder = new IndexFinder();
        int index = indexFinder.FindIndex(numbers, target);
        Console.WriteLine("Index of {0}: {1}", target, index);
    }
}