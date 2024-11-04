using System;

class PositiveSumCalculator
{
    public int CalculatePositiveSum(int[] array)
    {
        int sum = 0;

        foreach (int num in array)
        {
            if (num > 0)
            {
                sum += num;
            }
        }

        return sum;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { -1, 2, -3, 4, 5 };
        PositiveSumCalculator positiveSumCalculator = new PositiveSumCalculator();
        int positiveSum = positiveSumCalculator.CalculatePositiveSum(numbers);
        Console.WriteLine("Sum of positive numbers: {0}", positiveSum);
    }
}