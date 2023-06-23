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

        for (int j = 0; j < i - 1; j++)
        {
            int minIndex = j;
            for (int k = j + 1; k < i; k++)
            {
                if (tabulaRasa[k] < tabulaRasa[minIndex])
                {
                    minIndex = k;
                }
            }
            int temp = tabulaRasa[j];
            tabulaRasa[j] = tabulaRasa[minIndex];
            tabulaRasa[minIndex] = temp;
        }

        Console.WriteLine("Posortowana tablica:");
        for (int j = 0; j < i; j++)
        {
            Console.WriteLine(tabulaRasa[j]);
        }
    }
}
