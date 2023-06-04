using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        double x, y;

        x = -2; y = -1;
        Console.WriteLine("x = {0}, y = {1}", x, y);
        if (x == -2 && y == -1) {
            x = -1; y = 0;
            Console.WriteLine("x = {0}, y = {1}", x, y);
            if (x == -1 && y == 0)
            {
                x = 1; y = 0;
                Console.WriteLine("x = {0}, y = {1}", x, y);
                if (x == 1 && y == 0)
                {
                    x = 2; y = 1;
                    Console.WriteLine("x = {0}, y = {1}", x, y);
                }
            } 
        }

        Console.ReadLine();
    }

}
