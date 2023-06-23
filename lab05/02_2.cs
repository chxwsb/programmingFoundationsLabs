using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int n = 10;
        int i = 0;

        Random random = new Random();
        Console.Write("Wylosowane liczby parzyste: \n");

        while (n > 0)
        {
            int liczba = random.Next(-4, 5) * 2;

            if (liczba % 2 == 0)
            {
                Console.Write(liczba);

                if (n > 1)
                {
                    Console.Write(", ");
                }

                n--;
            }

            i++;
        }

        Console.WriteLine("\nIlosc losowan: " + i);
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
