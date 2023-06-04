using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int a, b;
        a = inputValue();
        b = a % 10;
        
        Console.WriteLine(b);

        Console.ReadLine();
    }
    
    // .NET can only read single characters or entire lines from the
    // console. The following function safely reads a double value.
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }
}
