using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int ileKolumn = 10;
        int ileWierszy = 10;
        int[,] array = new int[ileKolumn, ileWierszy];

        
        int wartoscTablicy = 1;

        for (int i = 0; i < ileKolumn; i++)
        {
            int j = 0;
            if (i % 2 != 0)
            {
                for (j = ileWierszy-1; 0 < j; j--)
                {
                    array[i, j] = wartoscTablicy;
                    wartoscTablicy++;
                }
                array[i, j] = wartoscTablicy;
                wartoscTablicy++;
            }
            else
            {

                for (j = 0; j < ileWierszy; j++)
                {
                    array[i, j] = wartoscTablicy;
                    wartoscTablicy++;
                }
            }
        }

        for (int i = 0; i < ileKolumn; i++)
        {
            for (int j = 0; j < ileWierszy; j++)
            {
                Console.Write("{0}  ", array[i, j]);
            }
            Console.WriteLine();
        }
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
