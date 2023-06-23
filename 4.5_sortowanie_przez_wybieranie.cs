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
        Console.WriteLine("Tablica przed sortowaniem przez wybieranie wyglądała nastepujaco: ");
        for (int i = 0; i < aov; i++)
        {
            Console.WriteLine($"{tablica[i]}");
        }
        int[] sorted = SelectSorto(tablica);
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
    private static int[] SelectSorto(int[] tablica)
    {
        for (int i = 0; i < tablica.Length - 1; i++)
        {
            int min = i;

            for (int j = i + 1; j < tablica.Length; j++)
            {
                if (tablica[j] < tablica[min])
                {
                    min = j;
                }
            }
            int tym = tablica[min];
            tablica[min] = tablica[i];
            tablica[i] = tym;
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