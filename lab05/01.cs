using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int k = 2;
        int l = 0;
        int modulo = 0;
        Console.WriteLine("Ile liczb pierwszych chcesz wypisaæ?");
        double ileLiczb = inputValue();
        for (int i = 1; ; i++)
        {
            for (int j = 1; j <= k; j++)
            {
                //Console.WriteLine("{0}, {1}, {2}", j, k, k%j);
                if (k % j == 0)
                    modulo++;
            }
            if (modulo == 2)
            {
                Console.WriteLine(k);
                l++;
                if (l == ileLiczb)
                    break;
            }
            modulo = 0;
            k++;
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