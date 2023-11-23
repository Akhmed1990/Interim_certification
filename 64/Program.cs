using System;

class Program
{
    static void Main()
    {
        int N = 5;
        PrintNumbers(N);
    }

    static void PrintNumbers(int n)
    {
        if (n >= 1)
        {
            Console.Write(n);

            if (n > 1)
            {
                Console.Write(", ");
            }

            PrintNumbers(n - 1);
        }
    }
}