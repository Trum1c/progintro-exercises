// Opgave 1 Which types are suitable for representing a temperature?

float temp = 33.2f;

Console.WriteLine(temp);

///opgave 2 Which types are suitable for representing a month?

byte month = 9;

Console.WriteLine(month);

// opgave 3 i am choosing sbyte. And the interval is -128<127. If the interval is overflowed.
// then it restarts. For exampel if we + 1 in 127, then the output is -128.
sbyte output = 127;

output ++;
Console.WriteLine(output);


// opgave 5.15 
int ada_lovelace = 36; // https://en.wikipedia.org/wiki/Ada_Lovelace
int dennis_ritchie = 70; // https://en.wikipedia.org/wiki/Dennis_Ritchie
int grace_hopper = 85; // https://en.wikipedia.org/wiki/Grace_Hopper
int hedy_lamarr = 85; // https://en.wikipedia.org/wiki/Hedy_Lamarr
int edsger_dijkstra = 72; // https://en.wikipedia.org/wiki/Edsger_W._Dijkstra
int douglas_engelbart = 88; // https://en.wikipedia.org/wiki/Douglas_Engelbart
float male_avg = (float)(dennis_ritchie + edsger_dijkstra + douglas_engelbart) / 3;
float female_avg = (float)(ada_lovelace + grace_hopper + hedy_lamarr) / 3;
float avg = (male_avg + female_avg) / 2;
float diff = male_avg - female_avg;
Console.Write("Average lifespan of a male computer scientist: ");
Console.WriteLine(male_avg);
Console.Write("Average lifespan of a female computer scientist: ");
Console.WriteLine(female_avg);
Console.Write("Average lifespan of a computer scientist: ");
Console.WriteLine(avg);
Console.Write("Males live this much longer than females: ");
Console.WriteLine(diff);


// opgave 5.8 Write a program that calculates and prints out the area 
// (π · r2) of three circles with radiuses of 1, 3 and 5.

const float pie = 3.14f;
byte r1 = 1;
byte r2 = 3;
byte r3 = 5;

float area1 = (float) pie * (r1*r1);
float area2 = (float) pie * (r2*r2);
float area3 = (float) pie * (r3*r3);


Console.WriteLine("areal 1:" + area1 + " Areal 2: "+area2 + " Areal 3: " + area3);


// 5.10 Celcius to Fahrenheit

float temperatur = 30.1f;

float farenheit = 32 + 9/5*temperatur;

Console.WriteLine("Temperaturen: " + temperatur +"C "+"Bliver til: " + farenheit + "F");

// 5.14 Daily Differences
float Monday = 21.5f;
float Tuesday = 23.7f;
float Wednesday = 19.6f;
float Thursday = 22.5f;
float Friday = 25.3f;
float Saturday = 21.7f;
float Sunday = 18.9f;

float tm = Tuesday - Monday;
float wm = Wednesday - Tuesday;
float ss = Sunday - Saturday;

Console.WriteLine(tm);
Console.WriteLine(wm);
Console.WriteLine(ss)