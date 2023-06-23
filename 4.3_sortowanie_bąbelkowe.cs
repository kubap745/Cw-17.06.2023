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
        Console.WriteLine("Tablica przed sortowaniem bąbelkowym wyglądała następująco: ");
        for (int i = 0; i < aov; i++)
        {
            Console.WriteLine($"{tablica[i]}");
        }
        int[] sorted = BubbleSort(tablica);
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
    private static int[] BubbleSort(int[] tablica)
    {
        int a,b;
        for (int i = 1; i < tablica.Length; i++)
        {
            a= tablica[i-1];
            b= tablica[i];
            if (a > b)
            {
                tablica[i - 1] = b;
                tablica[i] = a;
            }
        }
        return tablica;
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}