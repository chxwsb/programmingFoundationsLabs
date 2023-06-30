using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        string godzinaPoKonwersji;
        string minutaPoKonwersji;
        string sekundaPoKonwerji;

        int wprowadzoneSekundy = 12365487;


        godzinaPoKonwersji = konwertujNaGodzine(wprowadzoneSekundy);
        minutaPoKonwersji = konwertujNaMinute(wprowadzoneSekundy);
        sekundaPoKonwerji = konwertujNaSekunde(wprowadzoneSekundy);

        Console.WriteLine("{0} sekund to inaczej {1}:{2}:{3}(HH:MM:SS)", wprowadzoneSekundy, godzinaPoKonwersji, minutaPoKonwersji, sekundaPoKonwerji);

    }

    private static string konwertujNaGodzine(int wprowadzoneSekundy)
    {

            string sformatowanaGodzina = (wprowadzoneSekundy / 3600).ToString("D2");
            return sformatowanaGodzina;
    }

    private static string konwertujNaMinute(int wprowadzoneSekundy)
    {
        int pozostaleSekundy = wprowadzoneSekundy % 3600;
        string sformatowanaMinuta = (pozostaleSekundy / 60).ToString("D2");
        return sformatowanaMinuta;

    }

    private static string konwertujNaSekunde(int wprowadzoneSekundy)
    {
        int pozostaleSekundy = wprowadzoneSekundy % 3600;
        string sformatowanaSekunda = (pozostaleSekundy % 60).ToString("D2");
        return sformatowanaSekunda;
    }

    // .NET może odczytywać tylko pojedyncze znaki lub całe linie z konsoli.
    // Poniższa funkcja bezpiecznie odczytuje wartość int.
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }
}