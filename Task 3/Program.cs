using System;

class EvenNumbersFinder
{
    public void PrintEvenNumbers(int[] array)
    {
        Console.WriteLine("Even numbers in the array:");

        foreach (int num in array)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        EvenNumbersFinder evenNumbersFinder = new EvenNumbersFinder();
        evenNumbersFinder.PrintEvenNumbers(numbers);
    }
}
