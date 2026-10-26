using System.Diagnostics;
// 14.1: Kittens
/*
class Kitten{
    public static int count = 0;
    public double cuteness; 

    public Kitten(double cuteness)
    {
        this.cuteness = cuteness;
        count++;
    }
}
class Program
{
    static void Main()
    {
        for (int i=0 ; i<10 ; i++)
        {
            Kitten kitten = new Kitten(2.0*i);
            Console.WriteLine("Kitten #" + i + "has the cuteness: " + kitten.cuteness);
        }
        Console.WriteLine(Kitten.count);
    }
}

// Exercise 22.1: Timing
class Timing
{
    static double Fun(double x, double y)
    {
        if (y<=1)
        {
            return x;
        }
        else
        {
            return Fun(x,y-1) * Fun(x,y-1);
        }
    }

    static void Main()
    {
        double x = 1.0000001;
        for (int y = 1 ; y<=32 ; y++)
        {
            long start = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            double resultat = Fun(x, y);                             
            long slut = DateTimeOffset.Now.ToUnixTimeMilliseconds();    
            
            Console.WriteLine("y = " + y + ": " + resultat + " (" + (slut - start) + " ms)");
        }
    }
}

//Section 14.5 : Encapsulation                Ved jeg sku ikkke
class Circle 
    {
    public double x, y;
    public double r;
    public double d = r*2;
public Circle (double x, double y, double d) 
    {
    this.x = x;
    this.y = y;
    this.d = d;
    }
}
class TestCircle {
    static void Main (string[] args) 
    {
        Circle c = new Circle(1.24, 2.83, 12.7);
        Console.WriteLine("x=" + c.x + " y=" + c.y + " d=" + c.d);
        c.d *= 1.37;
        c.x += 0.65;
        Console.WriteLine("x=" + c.x + " y=" + c.y + " d=" + c.d);
    }
}


// Exercise 22.2: Date
// 14.3: Dates
class Program
{
    static void Main()
    {
        DateTime d1 = DateTimeOffset.FromUnixTimeMilliseconds(1000).DateTime;
        DateTime d2 = DateTimeOffset.FromUnixTimeMilliseconds(10000).DateTime;
        DateTime d3 = DateTimeOffset.FromUnixTimeMilliseconds(100000).DateTime;
        DateTime d4 = DateTimeOffset.FromUnixTimeMilliseconds(1000000).DateTime;

        Console.WriteLine(d1.ToString());
        Console.WriteLine(d2.ToString());
        Console.WriteLine(d3.ToString());
        Console.WriteLine(d4.ToString());
    }
}
*/
