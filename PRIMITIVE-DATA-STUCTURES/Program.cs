int[] numbers = [1, 8, 7, 56, 90];
int max = numbers[0];

foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}

Console.WriteLine(max);