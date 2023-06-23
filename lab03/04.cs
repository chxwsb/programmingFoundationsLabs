using System;
using System.Linq.Expressions;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Kwota poczatkowa:");
        double kwotaPoczatkowa = inputValue();
        Console.WriteLine("Ile procent:");
        double oprocentowanieRoczne = inputValue();
        Console.WriteLine("Ile miesiecy:");
        double miesiaceOszczedzania = inputValue();

        double oszczedzonaKwota = kwotaPoczatkowa;
        Console.WriteLine(kwotaPoczatkowa);
        for (int i = 0; i < miesiaceOszczedzania; i++)
        {
            oszczedzonaKwota += (oszczedzonaKwota * (oprocentowanieRoczne / 100 / 12)) * 0.81;
        }

        Console.WriteLine("Po okresie {0} miesiecy, przy oprocentowaniu {1} w skali roku z miesieczna kapitalizacja odsetek i po odliczeniu 19% podatku Belki, na koniec okresu lokaty bedziesz posiadal srodki w wysokosci okolo: {2}", miesiaceOszczedzania, oprocentowanieRoczne, oszczedzonaKwota)
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
