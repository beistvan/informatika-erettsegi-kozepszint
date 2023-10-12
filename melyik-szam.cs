using System;

namespace Melyikszam;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Egy számot kell kitalálnod 1 és az általad megadott felső határéték\r\nközött.");
        Console.Write("Add meg a határértéket! ");
        int hatarertek = Convert.ToInt32(Console.ReadLine());
        int probalkozasokSzama = 0;
        int tipp = 0;
        Random rnd = new Random();
        int randomSzam = rnd.Next(1, hatarertek + 1);
        Console.Write(randomSzam);
        do
        {
            probalkozasokSzama++;
            Console.WriteLine("\nMelyik számra gondoltam? {0}", probalkozasokSzama > 1 ? "(kilépés: -1)" : "");
            tipp = Convert.ToInt32(Console.ReadLine());
            if (tipp == -1)
            {
                break;
            }
            if (tipp < randomSzam)
            {
                Console.WriteLine("Sajnos nem talált!");
                Console.WriteLine("Nagyobb számra gondoltam!");
            }
            else if (tipp > randomSzam)
            {
                Console.WriteLine("Sajnos nem talált!");
                Console.WriteLine("Kisebb számra gondoltam!");
            }
        }
        while (tipp != randomSzam);

        if (tipp == -1)
        {
            Console.WriteLine("Sajnálom! A kitalálandó szám a(z) {0} volt.", randomSzam);
        }
        else if (tipp == randomSzam)
        {
            Console.WriteLine("Eltaláltad {0} próbálkozásból!", probalkozasokSzama);
        }
    }
}
