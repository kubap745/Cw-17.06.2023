using System;
using System.Reflection.Emit;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int aov;
        Console.WriteLine("Podaj ilość losowanych liczb");
        aov = inputValue();
        while (aov < 0)
        {
            Console.WriteLine("Podaj ilość losowanych liczb (większą od zera)");
            aov = inputValue();
        }
        int[] tablica = InsertValue(aov);
        Console.WriteLine("Tablica przed sortowaniem przez wstawianie wyglądała nastepujaco: ");
        for (int i = 0; i < aov; i++)
        {
            Console.WriteLine($"{tablica[i]}");
        }
        int[] sorted = SetSort(tablica, aov);
        Console.WriteLine("Po sortowaniu wygląda tak:");
        for (int i = 0; i < aov; i++)
        {
            Console.WriteLine($"{sorted[i]}");
        }
    }
    private static int[] InsertValue(int aov)
    {
        int a, b;
        int[] tablica = new int[aov];
        Random generator = new Random();
        Console.WriteLine("Podaj początek przedziału");
        a = inputValue();
        Console.WriteLine("Podaj koniec przedziału");
        b = inputValue();
        for (int i = 0; i < aov; i++)
        {
            tablica[i] = generator.Next(a, b);
        }
        return tablica;
    }
    private static int[] SetSort(int[] tablica, int aov)
    {
        int[] tablica_2 = new int[aov];
        for (int i = 0; i < tablica.Length; i++)                                      
        {
            if (i == 0)
            {
                tablica_2[i] = tablica[i];
            }
            else
            {
                for (int y = i; y > 0; y--)
                {
                    if (tablica_2[y - 1] > tablica[i])
                    {
                        tablica_2[y] = tablica_2[y - 1];
                        tablica_2[y - 1] = tablica[i];
                    }
                    else
                    {
                        tablica_2[y] = tablica[i];
                        break;
                    }
                }
            }
        }
        return tablica_2;
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}