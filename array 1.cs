using System;

class Program
{
    public static void Main(string[] args)
    {
        // 'numbers' array that stores integers
        int[] numbers = { 3, 14, 59, 67, 1, 5 };
        int sum = 0;
        // 2 is the index of value 59
        for (int i = 0; i < 6; i++)
        {
            sum = sum + numbers[i];
        }

        Console.WriteLine("The sum of these numbers: {0}", sum);

    }
}
