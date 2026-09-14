// 5.20 dice
byte dice = 2;
bool dice_tjek = (dice>=3);
Console.WriteLine(dice_tjek);

// 6.3 Christmas sale
int sec = 31104000;
int month = sec / 60 / 60 / 24 / 30;
float price = 599.95f;
if (month == 12) {
    price = 0.7f * price;
    Console.WriteLine("Din pris bliver " + price+"kr");
}
else {
    Console.WriteLine("Din pris bliver " + price +"kr");
}

// 6.5 holidays
int month2 = 8;

switch(month2) {
    case 10:
        Console.WriteLine("Autumn Holiday");
        break;
    case 12:
        Console.WriteLine("Christmas Holiday");
        break;
    case 4:
        Console.WriteLine("Spring Holiday");
        break;
    case 7 or 8:
        Console.WriteLine("Summer Holiday");
        break;
    default:
        Console.WriteLine("Hard work");
        break;
}

// 6.6 Celcius to Fahrenheit
for (float temp2 =-5 ; temp2 <= 40 ; temp2+=0.5) {
    float ft = 32 + (9f/5f*temp2);
    Console.WriteLine("Temp: " + temp2 + " Farhenheit: " + ft);
}
