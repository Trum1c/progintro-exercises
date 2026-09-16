// 7.4: Largest in Array
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


//7.12: Calendar
int[] months = [31,28,31,30,31,30,31,31,30,31,30,31];
int[] monthsLeap = [31,29,31,30,31,30,31,31,30,31,30,31];
int[] pointer;
for (int year = 2000 ; year<=2020 ; year++){
    if (year % 4 == 0)
    {
        pointer = monthsLeap;
    }
    pointer = months;
    Console.WriteLine("Days in the months of " + year + ": ");
    foreach (int num in pointer){
        Console.WriteLine(num + " ");
    }
}

//7.15 person
// ** class person{
//    public int = 18;
//    public string = "Anton";
//    bool alive = true;
//} ** 

//7.16 Direction
//Console.WriteLine(direction.south);

//enum direction{
 //   north,
 //   south,
  //  east,
   // west,
//}

// 7.14: Sūdoku Checker

// 7.8 Areas of Circles
int[] radius = [1,3,5];
for (int x=0 ; x<radius.Length ; x++){
    Console.WriteLine("The area of radius: " + radius[x] + " is: " + 3.14f * radius[x]*radius[x]);
}