
Dávid Snicer
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. feladat");
        Console.Write("Add meg a mondatot! ");
        string mondat = Console.ReadLine();

        Console.WriteLine("\n2. feladat");
        Console.WriteLine("A mondatban előforduló betűk száma: {0}", mondat.Length);

        Console.WriteLine("\n3. feladat");
        Console.WriteLine("A szavak száma: {0}", mondat.Split().Length);

        Console.WriteLine("\n4. feladat");
        int szamlalo = 0;
        foreach (char betu in mondat)
        {
            char kisbetu = Char.ToLower(betu);
            if (kisbetu == 'a' || kisbetu == 'e' || kisbetu == 'i' || kisbetu == 'o' || kisbetu == 'u')
            {
                szamlalo++;
            }
        }
        Console.WriteLine("A mondatban előforduló magánhangzók száma: {0}", szamlalo);

        Console.WriteLine("\n5. feladat");
        string[] szavak = mondat.Split();
        string leghosszabbSzo = szavak[0];
        foreach (string aktualisSzo in szavak)
        {
            if (aktualisSzo.Length > leghosszabbSzo.Length)
            {
                leghosszabbSzo = aktualisSzo;
            }
        }
        Console.WriteLine("A leghosszabb szó a(z) leghosszabb {0} betűből áll.", leghosszabbSzo.Length);

        Console.WriteLine("\n6. feladat");
        Console.Write("Add meg a keresett szót! ");
        string beolvasottSzo = Console.ReadLine();
        bool megtalaltam = false;
        foreach (string egySzo in szavak)
        {
            if (egySzo == beolvasottSzo)
            {
                megtalaltam = true;
                break;
            }
        }
        if (megtalaltam)
        {
            Console.WriteLine("A keresett szó megtalálható a mondatban.");
        }
        else
        {
            Console.WriteLine("A keresett szó nem fordul elő a mondatban.");
        }
    }
}
