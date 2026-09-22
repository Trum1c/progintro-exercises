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

// 5.4:
long b = 1;
int i = (int)b;

float f = 1f;
double d = f;
Console.WriteLine(f/d);

//Exercise 5.12 Incrementing a Month
int month2 = 2;
float flt = 0.5f;

Console.WriteLine(month2+flt+0.5);

//Exercise 6.1 Decision of Purchase
int sec = 31104000;
int days2 = sec / 60 / 60 / 24;
int month3 = days2 / 30;

int Christmas = 360;

if (Christmas == days2 && Christmas/30 == month3)
{
    Console.WriteLine("ITS CHRISTMAS");
}
else
{
    Console.WriteLine("Its not christmas");
}
// Exercise 7.6 Multiplication Table
int size = 27;
int[] array = new int[size];

for (int n = 0 ; n<size ; n++)
{
    array[n] = 3*n;
    Console.WriteLine(array[n]);
}
    
