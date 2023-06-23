using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe wierszy: ");
        
        int liczbaWierszy = inputValue();

        int szerokosc = 2 * liczbaWierszy - 1;
        int srodek = szerokosc / 2;

        for (int i = 0; i < liczbaWierszy; i++)
        {
            int ilePlusow = 2 * i + 1;
            int ileSpacji = srodek - i;

            
            for (int j = 0; j < iloscSpacji; j++)
            {
                Console.Write("   ");
            }

            
            for (int j = 0; j < iloscPlusow; j++)
            {
                Console.Write(" + ");
            }

            Console.WriteLine(); 
        }
    }

    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}
