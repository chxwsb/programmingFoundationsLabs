using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        //wspolrzedne punktu P
        int x1 = -2;
        int y1 = -2;

        //wspolrzedne punktu Q
        int x2 = 3;
        int y2 = 3;

        double dlugosc;

        dlugosc = obliczDlugosc(x1, x2, y1, y2);
        Console.WriteLine(dlugosc);

    }

    private static double obliczDlugosc(int x1, int x2, int y1, int y2)
    {
        double pierwszyPierwiastek = Math.Pow(x1 - x2, 2);
        double drugiPierwiastek = Math.Pow(y1 - y2, 2);
        double wynik = Math.Sqrt(pierwszyPierwiastek + drugiPierwiastek);

        return wynik;
    }
    // .NET może odczytywać tylko pojedyncze znaki lub całe linie z konsoli.
    // Poniższa funkcja bezpiecznie odczytuje wartość int.
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}