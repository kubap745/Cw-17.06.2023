using System;

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
        Console.WriteLine("Wylosowane liczby to:");
        for (int i = 0; i < aov; i++)
        {
            Console.WriteLine($"{i + 1}.{tablica[i]}");
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
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}using System;

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
        Console.WriteLine("Wylosowane liczby to:");
        for (int i = 0; i < aov; i++)
        {
            Console.WriteLine($"{i + 1}.{tablica[i]}");
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
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}