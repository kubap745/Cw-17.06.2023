using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int number_am,dividend,dividend_am;
        Console.WriteLine("Podaj ilość liczb pierwszych do wyświetlenia: ");
        number_am = inputValue();
        While(number_am <= 0)
        {
            Console.WriteLine("Podaj ilość liczb pierwszych do wyświetlenia (większą od zera): ");
        }
        int number = 2, indeks=1;
        Console.WriteLine("Liczby pierwsze to:");
        while(indeks <=number_am)
        {
       		dividend = 0;
                dividend_am = 0;
                while(dividend_am < 2)
                {
                    dividend++;
                    if(number%dividend==0)
                    {
                        dividend_am++;
                    }
        	}
        	if(number == dividend)
        	{
        		Console.WriteLine(dividend);
        	        indeks++;
        	}
        	number++;
        }
    }
    private static int inputValue()
    {
        int result;
        while (!int.TryParse(Console.ReadLine(), out result)) ;
        return result;
    }

}