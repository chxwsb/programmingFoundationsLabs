using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe, ktora ma byc podstawa potegi:");
        int podstawaPotegi = inputValue();
        Console.WriteLine("Podaj liczbe, ktora ma byc wykladnikiem potegi:");
        int wykladnikPotegi = inputValue();
        double wynikPotegowania = 1;
        
        if (wykladnikPotegi > 0 )
        {
            for (int i = 0; i < wykladnikPotegi; i++)
            {
                wynikPotegowania = wynikPotegowania * podstawaPotegi;
            }
        } 

        Console.WriteLine("{0}^{1}={2}", podstawaPotegi, wykladnikPotegi, wynikPotegowania);
        Console.ReadLine();
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
