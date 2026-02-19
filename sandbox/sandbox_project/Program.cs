using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        Console.WriteLine(Sumar(1)); // 1
        Console.WriteLine(Sumar(2)); // 3
        Console.WriteLine(Sumar(10)); // 55
        Console.WriteLine(Sumar(25)); // 325

    }

    static int Sumar(int n)
    {
        if (n <= 1)
        {
            return 1;
        }
        else
        {
            return n + Sumar(n-1);
        }
    }


}

