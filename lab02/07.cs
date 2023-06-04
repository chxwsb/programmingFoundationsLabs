using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double a, b, r, x, y;
        
        a = inputValue();
        b = inputValue();
        r = inputValue();
        x = 0;
        y = 0;
        if (a * a + b * b <= r * r)
        {
            Console.WriteLine("Punkt lezy w okregu");
        }
        else
        {
            Console.WriteLine("Punkt nie lezy w okregu");
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
