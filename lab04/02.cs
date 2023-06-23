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

        int max = tabulaRasa[5];
        int min = tabulaRasa[5];
        for (int j = i-1; j >= 0; j--)
        {
            if (max < tabulaRasa[j])
                max = tabulaRasa[j];
            if (min > tabulaRasa[j])
                min = tabulaRasa[j];
        }
        Console.WriteLine("Min: {0}, max: {1}", min, max);
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
