using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int draw_am_1 = 0, draw_am_2 = 0, draw, number_am, indeks = 1;
        Random generator = new Random();
        Console.WriteLine("Podaj liczbę losowanych cyfr:");
        number_am = inputValue();
        while(number_am <= 0)
        {
            Console.WriteLine("Podaj liczbę losowanych cyfr (większą od zera): ");
            number_am = inputValue();
        }
        Console.WriteLine("Liczby wylosowane z pierwszej metody to: ");
        while (indeks <= number_am)
        {
        	draw = generator.Next(-8, 8);
            draw_am_1++;
            while (draw % 2 != 0)
            {
                draw = generator.Next(-8, 8);
                draw_am_1++;
            }
            if (indeks == 1)
            {
                Console.Write(draw);
            }
            else
            {
                if (indeks + 1 <= number_am)
                {
                    Console.Write($", {draw}");
                }
                else
                {
                    Console.Write($", {draw}\n");
                }
            }
            indeks++;
        }
        indeks = 1;
        Console.WriteLine("Liczby wylosowane z drugiej metody to: ");
        while (indeks <= number_am)
        {
                draw = generator.Next(-4, 4) * 2;
                draw_am_2++;
                if (indeks == 1)
                {
                    Console.Write(draw);
                }
                else
                {
                    if (indeks + 1 <= number_am)
                    {
                        Console.Write($", {draw}");
                    }
                    else
                    {
                        Console.Write($", {draw}\n");
                    }
                }
                indeks++;
        }
        Console.WriteLine($"Aby wyświetlić {number_am} liczb z przedziału [-8.8] metodą 1 losowaliśmy liczby {draw_am_1} razy, a metodą drugą {draw_am_2} razy.");
    }

    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}