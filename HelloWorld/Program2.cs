namespace HelloWorld
{
    public class Program2
    {
        // 1. Even or Odd
        public string CheckEvenOdd(int n)
        {
            return (n % 2 == 0) ? "Even" : "Odd";
        }

        // 2. Factorial
        public long GetFactorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++) fact *= i;
            return fact;
        }

        // 3. Prime Number Check
        public bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}