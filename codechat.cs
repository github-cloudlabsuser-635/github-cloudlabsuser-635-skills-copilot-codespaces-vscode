using System;
using System.Linq;

class Program
{
    const int MAX_ELEMENTS = 100;

    static int CalculateSum(int[] numbers)
    {
        return numbers.Sum();
    }

    static int[] ReadNumbers(int count)
    {
        int[] numbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"Enter integer #{i + 1}:");
            while (!int.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        return numbers;
    }

    static void Main()
    {
        Console.Write($"Enter the number of elements (1-{MAX_ELEMENTS}): ");
        if (!int.TryParse(Console.ReadLine(), out int numberOfElements) || numberOfElements < 1 || numberOfElements > MAX_ELEMENTS)
        {
            Console.WriteLine($"Invalid input. Please provide a number between 1 and {MAX_ELEMENTS}.");
            return;
        }

        int[] numbers = ReadNumbers(numberOfElements);
        int sum = CalculateSum(numbers);

        Console.WriteLine($"Sum of the numbers: {sum}");
    }
}