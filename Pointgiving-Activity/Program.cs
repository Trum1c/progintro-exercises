//i have understand the "Largest negative value", as the closest value to 0. In this case it's: -1
int[] numbers = [-1, 5, -8, 2, -7, 4, -56, -90];
int max = numbers[0];

foreach (int number in numbers)
{
//Only including negative value with the expression <0, and then finding the largest
// negative value with the help of our max varible. If the current number is larger than
// max, then the program sets the value of max equals to the value of number.
    if (number <0 && max<number)
    {
        max = number;
    }
}

Console.WriteLine(max);


