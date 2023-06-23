using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int row_am,plus_am=0,tab_am=0;
        Console.WriteLine("Podaj liczbę wierszy trójkąta (Większą od 1): ");
        row_am = inputValue();
        while(row_am <= 1)
        {
            Console.WriteLine("Podaj liczbę losowanych cyfr (większą od 1): ");
            row_am = inputValue();
        }
        int temp = 0;
        for (int indeks= 1;  indeks <= row_am; indeks++)
        {
            if (indeks == 1)
            {
                plus_am = 1;
                temp = plus_am;
            }
            else
            {
                plus_am = temp + 2;
                temp = plus_am;
            }
            tab_am = row_am - indeks;
            Console.WriteLine();
            while(tab_am!=0)
            {
                Console.Write("     ");
                tab_am--;
            }
            while (plus_am != 0)
            {
                Console.Write("+    ");
                plus_am--;
            }
        }
    }

    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}