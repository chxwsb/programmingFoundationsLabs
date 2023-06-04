using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, c;
        a = 10;
        b = 20;
        c = 30;
        (b, c, a) = (a, b, c);
        Console.WriteLine("{0}, {1}, {2}", b, c, a);
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
