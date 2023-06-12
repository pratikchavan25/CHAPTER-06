// See https://aka.ms/new-console-template for more information

// 6. Write a C# program to find maximum between three numbers (using logical operator) 

Console.WriteLine("Enter 1st number");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 2nd number");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter 3rd number");
int c = Convert.ToInt32(Console.ReadLine());

if (a>b && a > c)
{
    Console.WriteLine( "a is max");
}
else if(b>c)
{
    Console.WriteLine( "b is max");
}
else
{
    Console.WriteLine(  "c is max");
}
