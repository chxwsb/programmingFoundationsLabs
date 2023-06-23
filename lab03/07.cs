using System;
using System.Linq.Expressions;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double n = inputValue();
        double l = n;
        for (int i = 0; i <= n; i++)
        {
            Console.WriteLine("{0} {1}", l-n, n);
            n -= 1;
            
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
