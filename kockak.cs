using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hány alkalommal legyen feldobás? ");
        int N = Convert.ToInt32(Console.ReadLine());
        int osszeg = 0;
        int nyertAnni = 0;
        for (int i  = 0; i < N; i++)
        {
            Random rnd = new Random();
            int a, b, c;
            a = rnd.Next(1, 7);
            b = rnd.Next(1, 7);
            c = rnd.Next(1, 7);
            osszeg = a + b + c;
            Console.Write("Dobás: {0} + {1} + {2} = {3,-6} ", a, b, c, osszeg);
            if (osszeg < 10)
            {
                Console.WriteLine("Nyert: Anni");
                nyertAnni++;
            }
            else
            {
                Console.WriteLine("Nyert: Panni");
            }
        }
        Console.WriteLine("A játék során {0} alkalommal Anni, {1} alkalommal Panni nyert.", nyertAnni, N - nyertAnni);
    }
}
