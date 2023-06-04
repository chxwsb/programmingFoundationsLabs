using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b;

        a = inputValue();
        b = inputValue();
        bool aCzyWieksza;

        aCzyWieksza = a > b;
        if (aCzyWieksza)
        {
            Console.WriteLine(a);
            Console.ReadLine();
        }
        else
        {
            if (a == b)
            {
                Console.WriteLine("Obie liczby sa rowne");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(b);
                Console.ReadLine();
            }
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
