using System;


public class MyProgram
{
    public static void Main(string[] args)
    {
        int i = 10;
        int[] tabulaRasa = new int[i];
        
        for (int j = 0; j < i; j++)
        {
            int losowaLiczba = new Random().Next(1, 100 + 1);
            tabulaRasa[j] = losowaLiczba;
            Console.WriteLine("Pod indeksem {0} dodano liczbe {1}", j, losowaLiczba);
        }

        
        for (int j = 0; j < i; j++)
        {
            for (int k = j; k < i; k++)
            {
                if (tabulaRasa[k] > tabulaRasa[j])
                    (tabulaRasa[k], tabulaRasa[j]) = (tabulaRasa[j], tabulaRasa[k]);
            }
        }

        for (int j = 0; j < i; j++)
        {
            Console.WriteLine(tabulaRasa[j]);
        }

    }
}