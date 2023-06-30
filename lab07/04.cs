using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization.Formatters;

public class MyProgram
{
    public static void Main(string[] args)
    {
        const int wymiarY = 5;
        const int wymiarX = 4;
        int[,] tablica = new int[wymiarY, wymiarX]
        {
            { 1, 2, 3, 4 },
            { 4, 2, 3, 1 },
            { 1, 2, 3, 999 },
            { 1, 2, 3, 4 },
            { 4, 2, 3, -100 },
        };
        
        wybierzWiersze(tablica, wymiarY, wymiarX);

    }

    private static void wybierzWiersze(int[,] tablica, int wymiarY, int wymiarX)
    {
        int aktualnaRoznica = int.MaxValue;
        int zwroconaRoznica = 0;
        int wierszWyzszy = 0;
        int wierszNizszy = 0;

        for (int i = 0; i < wymiarY - 1; i++)
        {
            for (int iPlusJeden = i + 1; iPlusJeden < wymiarY; iPlusJeden++)
            {
                zwroconaRoznica = przeliczWiersze(i, iPlusJeden, wymiarX, tablica);
                if (zwroconaRoznica < aktualnaRoznica)
                {
                    aktualnaRoznica = zwroconaRoznica;
                    wierszWyzszy = i;
                    wierszNizszy = iPlusJeden;
                }
            }
        }
        Console.WriteLine("Najmniejsza roznia wynosi {0} pomiedzy wierszami numer {1} oraz {2}.", aktualnaRoznica, wierszWyzszy, wierszNizszy);
    }

    private static int przeliczWiersze(int i, int iPlusJeden, int wymiarX, int[,] tablica)
    {
        int poziomZroznicowania = 0;

        for (int k = 0; k < wymiarX; k++)
        {
            poziomZroznicowania += (int)Math.Pow((tablica[iPlusJeden, k] - tablica[i, k]), 2);
        }

        return poziomZroznicowania;
    }
}