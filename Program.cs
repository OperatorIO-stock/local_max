namespace local_max;

class Program
{
    static void Main(string[] args)
    {
        int rangeNumberMax = 101;
        int rangeNumberMin = 1;

        int[] numbers = new int [13];
        Random random = new Random();

        int lastIndex = numbers.Length - 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(rangeNumberMin, rangeNumberMax);
            Console.Write($"{numbers[i]} ");
        }

        Console.WriteLine("\n");

        if (numbers[0] > numbers[1])
            Console.WriteLine($"The local max: {numbers[0]}");

        for (int i = 1; i < lastIndex - 1; i++)
        {
            if (numbers[i] > numbers[i - 1])
            {
                if (numbers[i] > numbers[i + 1])
                    Console.WriteLine($"The local max: {numbers[i]}");
            }
        }

        if (numbers.Length > 1)
        {
            if (numbers[lastIndex] > numbers[lastIndex - 1])
                Console.WriteLine($"The local max: {numbers[lastIndex]}");
        }
    }
}
