using System;
using System.Linq.Expressions;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Do jakiej potegi chcesz podniesc liczb e?");
        double wykladnikX = inputValue();
        Console.WriteLine("Ile wyrazow chcesz zsumowac w ciagu Taylora?");
        double nWyrazow = inputValue();
        

        double wyraz = 1;
        double potega = 1;
        double silnia = 1;

        for (double i = 1; i <= nWyrazow; i++)
        {
            
            potega *= wykladnikX;
            silnia *= i;
            wyraz += potega / silnia;
        }
        Console.WriteLine("{0}", wyraz);
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
