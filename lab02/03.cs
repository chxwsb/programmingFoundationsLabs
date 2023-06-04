using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoj wzrost (w m):");
        double wzrost = inputValue();
        Console.WriteLine("Podaj swoja wage (w kg):");
        double waga = inputValue();

        double BMI = waga / Math.Pow(wzrost, 2);

        Console.WriteLine("\nTwoje BMI wynosi: {0}", Math.Round(BMI, 2)); //Returns 3.4
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
