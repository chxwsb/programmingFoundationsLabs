using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double P = inputValue();
        double r = Math.Sqrt(P/Math.PI);
        double O = 2 * Math.PI * r;    
        
        Console.WriteLine("\nDla podanego pola kola {0}\njego promien wynosi: {1},\njego obwod wynosi: {2}", P, r, O);
        Console.ReadLine();
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
