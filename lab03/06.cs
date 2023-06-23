using System;
using System.Linq.Expressions;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe n, a sprawdze czy ta liczba ma odpowiadajace jej silnie.");
        double n = inputValue();
        double silnia = 1;
        double i = 1;
        
        

        while (true)
        {
            if (n == silnia)
            {
                Console.Write("Liczba {0} to {1}!", n, i);
                break;
            }
            if (silnia > n)
            {
                Console.Write("Liczba {0} nie ma odpowiadającej jej silni", n);
                break;
            }
            silnia = silnia * i;
            i++;
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
