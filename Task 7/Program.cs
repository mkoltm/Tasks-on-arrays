using System;

class MainDiagonalSumCalculator
{
    public int CalculateMainDiagonalSum(int[,] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }
}

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        MainDiagonalSumCalculator diagonalSumCalculator = new MainDiagonalSumCalculator();
        int diagonalSum = diagonalSumCalculator.CalculateMainDiagonalSum(matrix);
        Console.WriteLine("Sum of elements along the main diagonal: {0}", diagonalSum);
    }
}
