using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;
        
        a = inputValue();
        b = inputValue();
        c = inputValue();
        bool czyRowne;
        
        czyRowne = a == b && b == c;
        if (czyRowne)
        {
            Console.WriteLine("Podane wartosci umozliwiaja utworzenie trojkata rownobocznego");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Z podanych wartosci nie mozna utworzyc trojkata rownobocznego");
            Console.ReadLine();
        }
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static double inputValue()
    {
        double result;
        while (!double.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
