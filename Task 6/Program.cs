using System;

class NegativeProductCalculator
{
    public int CalculateNegativeProduct(int[] array)
    {
        int product = 1;

        foreach (int num in array)
        {
            if (num < 0)
            {
                product *= num;
            }
        }

        return product;
    }
}

class Program
{
    static void Main()
    {
        int[] numbers = { -2, 3, -4, 5, -6 };
        NegativeProductCalculator negativeProductCalculator = new NegativeProductCalculator();
        int negativeProduct = negativeProductCalculator.CalculateNegativeProduct(numbers);
        Console.WriteLine("Product of negative numbers: {0}", negativeProduct);
    }
}