using System;
using System.Reflection.Emit;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int aov,najw,najm;
        Console.WriteLine("Podaj ilość losowanych liczb");
        aov = inputValue();
        while (aov < 0)
        {
            Console.WriteLine("Podaj ilość losowanych liczb (większą od zera)");
            aov = inputValue();
        }
        int[] tablica = InsertValue(aov);
        Console.WriteLine("Wylosowane liczby to:");
        for (int i = 0; i < aov; i++)
        {
            Console.WriteLine($"{i + 1}.{tablica[i]}");
        }
        najw=BiggestValue(tablica);
        najm = SmallestValue(tablica);
        Console.WriteLine($"Najmniejsza wartość w tablicy to : {najm}\nA największa wartość to : {najw}");

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
    private static int BiggestValue(int[] tablica)
    {
        int Biggest=0;
        for (int i = 0; i < tablica.Length; i++)
        {
            if(i==0)
            {
                Biggest = tablica[i];
            }
            else
            {
                if (Biggest < tablica[i])
                {
                    Biggest = tablica[i];
                }
            }
        }
        return Biggest;
    }
    private static int SmallestValue(int[] tablica)
    {
        int Smallest = 0;
        for (int i = 0; i < tablica.Length; i++)
        {
            if (i == 0)
            {
                Smallest = tablica[i];
            }
            else
            {
                if (Smallest > tablica[i])
                {
                    Smallest = tablica[i];
                }
            }
        }
        return Smallest;
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}