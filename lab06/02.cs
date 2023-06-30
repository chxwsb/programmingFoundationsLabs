using System;
using System.Reflection.Metadata;
using System.Text;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int rozmiarTablicy = 10;
        int[,] tabula = new int[rozmiarTablicy, rozmiarTablicy];

        wypelnijTabliceSlimakowo(tabula, rozmiarTablicy);
        Console.WriteLine("Tablica wypelniona slimakowo:");
        wypiszTablice(tabula, rozmiarTablicy);
    }

    public static void wypelnijTabliceSlimakowo(int[,] tabula, int rozmiarTablicy)
    {
        int gora = 0;
        int prawo = rozmiarTablicy;
        int dol = rozmiarTablicy;
        int lewo = 0;

        int kierunek = 1;
        int wypelnienie = 1;

        bool czyWypelniac = true;

        while (czyWypelniac)
        {
            switch (kierunek)
            {
                case 1:
                    //od lewej do prawej idziemy zawsze gora, wiec
                    odLewejDoPrawej(kierunek, tabula, gora, prawo, lewo, ref wypelnienie);
                    //po przejsciu trzeba zwiekszyc o jeden gora, zeby kolejnym razem przejsc po nizszym rzedzie
                    gora++;
                    kierunek = 2;
                    break;
                case 2:
                    odGoryDoDolu(kierunek, tabula, gora, prawo, dol, ref wypelnienie);
                    prawo--;
                    kierunek = 3;
                    break;
                case 3:
                    odPrawejDolewej(kierunek, tabula, gora, prawo, dol, lewo, ref wypelnienie);
                    dol--;
                    if (rozmiarTablicy - 1 == gora)
                    {
                        czyWypelniac = false;
                    }
                    kierunek = 4;
                    break;
                case 4:
                    odDoluDoGory(kierunek, tabula, gora, prawo, dol, lewo, ref wypelnienie);
                    lewo++;
                    kierunek = 1;
                    break;
            }
        }
    }

    public static void wypiszTablice(int[,] tabula, int rozmiarTablicy)
    {
        for (int x = 0; x < rozmiarTablicy; x++)
        {
            for (int y = 0; y < rozmiarTablicy; y++)
            {
                Console.Write(" {0} ", tabula[x, y]);
            }
            Console.WriteLine();
        }
    }

    public static void odLewejDoPrawej(int kierunek, int[,] tabula, int gora, int prawo, int lewo, ref int wypelnienie)
    {
        int x = gora;
        for (int y = lewo; y < prawo; y++)
        {
            tabula[x, y] = wypelnienie;
            wypelnienie++;
        }
        
    }

    public static void odGoryDoDolu(int kierunek, int[,] tabula, int gora, int prawo, int dol, ref int wypelnienie)
    {
        int y = prawo - 1; //'prawo-1' bo prawo to liczba elementow w tablicy, ale pozycja elementu jest -1 wzgledem liczby calkowitej, bo numeracja zaczyna sie od 0
        for (int x = gora; x < dol; x++)
        {
            tabula[x, y] = wypelnienie;
            wypelnienie++;
        }
    }

    public static void odPrawejDolewej(int kierunek, int[,] tabula, int gora, int prawo, int dol, int lewo, ref int wypelnienie)
    {
        int x = dol - 1;
        for (int y = prawo - 1; y >= lewo; y--)
        {
            tabula[x, y] = wypelnienie;
            wypelnienie++;
        }
    }

    public static void odDoluDoGory(int kierunek, int[,] tabula, int gora, int prawo, int dol, int lewo, ref int wypelnienie)
    {
        int y = lewo;
        for (int x = dol-1; x >= gora; x--)
        {
            tabula[x, y] = wypelnienie;
            wypelnienie++;
        }
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