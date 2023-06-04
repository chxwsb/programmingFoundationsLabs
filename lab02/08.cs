using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Podaj dwie dowolne liczby");
        double a, b, wynik;
        int typDzialania;
        
        a = inputValue();
        b = inputValue();
        Console.WriteLine("Podaj jakie chcesz wykonac dzialanie:\\n1 - dodawanie,\\n2 - odejmowanie,\\n3 - mnozenie,\\n4 - dzielenie");
        typDzialania = (int) inputValue();
        if (typDzialania == 1)
        {
            wynik = a + b;
            Console.WriteLine(wynik);
        }
        else
        {
            if (typDzialania == 2)
            {
                wynik = a - b;
                Console.WriteLine(wynik);
            }
            else
            {
                if (typDzialania == 3)
                {
                    wynik = a * b;
                    Console.WriteLine(wynik);
                }
                else
                {
                    if (typDzialania == 4)
                    {
                        if (b != 0)
                        {
                            wynik = a / b;
                            Console.WriteLine(wynik);
                        }
                        else
                        {
                            wynik = b / a;
                            Console.WriteLine(wynik);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Czy na pewno poprawnie wybrales typ dzialania?");
                    }
                }
            }
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
