using System;
using System.Linq.Expressions;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Ile wyrazow ciagu fibonacciego chcesz wypisac?");
        int liczbaIteracji = inputValue();
        double x = 0;
        double y = 1;
        double z = 1;
        double suma = 1;

        switch (liczbaIteracji)
        {
            case 0:
                Console.WriteLine("0");
                break;
            case 1:
                Console.WriteLine("0");
                Console.WriteLine("1");
                break;
            case 2:
                Console.WriteLine("0");
                Console.WriteLine("1");
                break;
            default:
                Console.WriteLine("0");
                Console.WriteLine("1");
                Console.WriteLine("1");
                for (int i = 2; i < liczbaIteracji; i++)
                {
                    x = y + z;
                    z = y;
                    y = x;
                    suma += x;
                    Console.WriteLine("{0}", x);
                }
                break;

        }

        Console.ReadLine();
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
