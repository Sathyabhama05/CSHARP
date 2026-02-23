using System;

namespace HelloWorld
{
    public class Program1
    {
        // This method handles the logic based on your format
        public double Calculate(double a, double b, char op)
        {
            double result = 0;

            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b != 0) result = a / b;
                    else Console.WriteLine("Cannot divide by zero.");
                    break;
                default:
                    Console.WriteLine("Unknown operator.");
                    return 0;
            }
            return result;
        }
    }
}