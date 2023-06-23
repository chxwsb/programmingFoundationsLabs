using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int i = 10;
        int[] tabulaRasa = new int[i];
        Random random = new Random();

        for (int j = 0; j < i; j++)
        {
            int losowaLiczba = random.Next(1, 100 + 1);
            tabulaRasa[j] = losowaLiczba;
            Console.WriteLine("Pod indeksem {0} dodano liczbe {1}", j, losowaLiczba);
        }

        for (int j = 1; j < i; j++)
        {
            int element = tabulaRasa[j];
            int k = j - 1;
            while (k >= 0 && tabulaRasa[k] > element)
            {
                tabulaRasa[k + 1] = tabulaRasa[k];
                k--;
            }
            tabulaRasa[k + 1] = element;
        }

        Console.WriteLine("Posortowana tablica:");
        for (int j = 0; j < i; j++)
        {
            Console.WriteLine(tabulaRasa[j]);
        }
    }
}
