using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int i = 10;
        int[] tabulaRasa = new int[i];
        
        for (int j = 0; j < i; j++)
        {
            int losowaLiczba = new Random().Next(1, 100 + 1);
            tabulaRasa[j] = losowaLiczba;
            Console.WriteLine("Pod indeksem {0} dodano liczbe {1}", j, losowaLiczba);
        }

        Console.WriteLine("Ta sama tablica, ale od tylu:");
        for (int j = i-1; j >= 0; j--)
        {
            Console.WriteLine("Pod indeksem {0} jest liczba {1}", j, tabulaRasa[j]);
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
