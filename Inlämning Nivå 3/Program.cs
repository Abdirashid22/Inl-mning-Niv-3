using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Skriv in 5 heltal:");
        int summa= int.Parse(Console.ReadLine());
        
        for (int i = 1; i <= 5; i++)
        {
            Console.Write("Ange heltal " + i + ": ");
            int tal = int.Parse(Console.ReadLine());
            summa += tal; 
        }

        
        Console.WriteLine("Summan av de inmatade talen är: " + summa);
    }
}

