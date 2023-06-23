using System;
using System.Linq.Expressions;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n;
        int k;

        do
        { 
            n = inputValue();
            k = inputValue();
        } while (n < 5 || k < 5);
         
        int nSilnia = 1;
        int kSilnia = 1;
        
        for (int i = 1; i <= n; i++)
        {
            nSilnia *= i;
        }

        for (int i = 1; i <= k; i++)
        {
            kSilnia *= i;
        }
        Console.WriteLine("{0}, {1}", nSilnia, kSilnia);
        double m = (nSilnia - kSilnia) / kSilnia;
        Console.WriteLine("Wynik m = (n!-k!)/k! = ({0} - {1})/{1} = {2}", nSilnia, kSilnia, m);
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
