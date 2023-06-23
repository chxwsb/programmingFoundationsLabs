using System;
using System.ComponentModel;
using System.Linq.Expressions;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double odpowiedz = 1;
        double liczba = 10;
        double roznicaUjemna = 9;
        double roznicaDodatnia = 10;

        while (odpowiedz != 0)
        {
            Console.WriteLine("Czy masz na mysli liczbe {0}?", liczba);
            odpowiedz = inputValue();
            if (odpowiedz < 0 ) {
                liczba -= roznicaUjemna;
                roznicaUjemna = Math.Ceiling(roznicaUjemna /= 2);
            } else if (odpowiedz > 0) {
                liczba += roznicaDodatnia;
                roznicaDodatnia = Math.Ceiling(roznicaDodatnia /= 2);
            } else if ( liczba == 0) {
                Console.WriteLine("Szukana liczba to {0}", odpowiedz);
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
