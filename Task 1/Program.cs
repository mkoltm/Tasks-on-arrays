using System;

class ArrayAverageCalculator
{
    public double CalculateAverage(int[] array)
    {
        if (array.Length == 0)
        {
            return 0.0; // Повертаємо 0, якщо масив порожній, щоб уникнути ділення на 0
        }

        int sum = 0;

        foreach (int num in array)
        {
            sum += num;
        }

        return (double)sum / array.Length;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        ArrayAverageCalculator averageCalculator = new ArrayAverageCalculator();
        double average = averageCalculator.CalculateAverage(numbers);
        Console.WriteLine("Average: {0}", average);
    }
}