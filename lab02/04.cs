using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b, c, d;
        double wynikDodawania;
        Console.WriteLine("Podaj cztery liczby a, b, c, d do wykonania dzialania a/b + c/d.");
        a = (int)inputValue();
        b = (int)inputValue();
        c = (int)inputValue();
        d = (int)inputValue();
        if (b == 0 || d == 0)
        {
            Console.WriteLine("Nie dzielimy przez 0.");
            Console.ReadLine();
        }
        else
        {
            if ((double)b / d == 1)
            {
                wynikDodawania = (double)a / b + (double)c / d;
                Console.WriteLine(wynikDodawania);
                Console.ReadLine();
            }
            else
            {
                a = a * d;
                c = b * c;
                b = b * d;
                d = b;
                wynikDodawania = (double)a / b + (double)c / d;
                Console.WriteLine(wynikDodawania);
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
