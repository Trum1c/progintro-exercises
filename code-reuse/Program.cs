// 8.4: Sum Topic
int sum (int a, int b) {
    return a+b;
}
Console.WriteLine(sum(3,5));

//8.3Sūdoku Prettyprinter
void prettyPrintArray (int[][] array)
{
    for (int x=0 ; x<array.Length ; x++)
    {
        Console.Write("[");
        for (int i=0 ; i<array[x].Length ; i++)
    {
        Console.Write((i==0 ? "" : ",")+array[x][i]);
    }
     Console.WriteLine("]");
    }
}
int[][] puzzle = {
new int[] {7, 3, 6, 4, 5, 2, 9, 8, 1},
new int[] {1, 9, 8, 6, 3, 7, 4, 5, 2},
new int[] {4, 2, 5, 9, 8, 1, 3, 7, 6},
new int[] {3, 6, 4, 5, 2, 8, 1, 9, 7},
new int[] {9, 5, 2, 7, 1, 4, 6, 3, 8},
new int[] {8, 1, 7, 3, 9, 6, 2, 4, 5},
new int[] {2, 8, 9, 1, 7, 3, 5, 6, 4},
new int[] {6, 7, 3, 2, 4, 5, 8, 1, 9},
new int[] {5, 4, 1, 8, 6, 9, 7, 2, 3},
};
prettyPrintArray(puzzle);

// 8.8: Factorial function
int fac (int n)
{
    if (n == 0)
    {
    return 1;
    }
    else {
       return n*fac(n-1);
    }
}
Console.WriteLine(fac(4));

//8.9: Properties of Circles
void area (int r)
{
    double area = (Math.PI*(r*r));
    Console.WriteLine("The area is : " + area);
    double cirum = (2*Math.PI*r);
    Console.WriteLine("The circumference is: " + cirum);

}
area(1);
area(3);
area(5);

//9.1: Indexing
int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};
// increment
for (int i=0 ; i<iterationer ; i++) 
{
    try
    {
        array[i]++;
    }
    catch(IndexOutOfRangeException)
    {
        //Ignoere fejlen
    }
}
// print
for (int i=0 ; i<array.Length ; i++) {
Console.WriteLine(array[i]);
}

// 9.2 accounts:
int[] accounts = {903, 716, 67};
int GetAccountNumber ()
{
Console.WriteLine("Enter an account number: ");
return Convert.ToInt32(Console.ReadLine());
}
void PrintAccountState (int accountId)
{
    Console.WriteLine("Account " + accountId + " contains " + accounts[accountId]);
}
while (false) {
    try{
        int accountId = GetAccountNumber();
        PrintAccountState(accountId);
    }
    catch(IndexOutOfRangeException)
    {
        Console.WriteLine("Input is out of range");
    }
    catch(FormatException)
    {
      Console.WriteLine("Use int");  
    }
}

//9.3 Average Grade
int[] grades = [4, 7, 02, 00, 10, 4, 12];
int sums = 0;
float count = 0f;
int get_grade(int course_id){
    int grade = grades[course_id];
    if (grade<2){
        throw new Exception("You have failed");
    }
    return grade;
}
    for (int x = 0 ; x<grades.Length ; x++)
    {
        try{
            sums += get_grade(x);
            count++;
        }
        catch(Exception){
        }
    }
Console.WriteLine(sums/count);