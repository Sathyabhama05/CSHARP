using System;
using HelloWorld;

/*public class Program
{
    public static void Main()
    {
        // Create an instance of your Calculator class
        Program1 calc = new Program1();

        Console.WriteLine("C# Console Calculator");
        
        Console.Write("Num 1: ");
        double a = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Operator (+, -, *, /): ");
        char op = (Console.ReadLine() ?? "+")[0];

        
        Console.Write("Num 2: ");
        double b = Convert.ToDouble(Console.ReadLine());

        // Call the Calculate method from the other file
        double finalResult = calc.Calculate(a, b, op);

        Console.WriteLine("Output: " + finalResult);
    }
}*/

Program2 ex = new Program2();

Console.Write("Enter a number to analyze: ");
int num = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Even/Odd: " + ex.CheckEvenOdd(num));
Console.WriteLine("Factorial: " + ex.GetFactorial(num));
Console.WriteLine("Is Prime: " + ex.IsPrime(num));