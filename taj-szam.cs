using System;

namespace Erettsegi;

class Hello
{
    static void Main(string[] args)
    {
        Console.WriteLine("Kérem a TAJ-számot: ");
        string tajszam = Console.ReadLine();
        int ellenorzoSzam = tajszam[8] - '0';
        Console.WriteLine("Az ellenőrzőszámjegy: {0}", ellenorzoSzam);
        int szamjegyekOsszege = 0;
        for (int index = 0; index < tajszam.Length - 1; index++)
        {
            int szamjegy = tajszam[index] - '0';
            if (index % 2 != 0)
            {
                szamjegyekOsszege += szamjegy * 7;
            }
            else
            {
                szamjegyekOsszege += szamjegy * 3;
            }
        }
        Console.WriteLine("A szorzatok összege: {0}", szamjegyekOsszege);
        if (szamjegyekOsszege % 10 == ellenorzoSzam)
        {
            Console.WriteLine("Helyes a szám!");
        }
        else
        {
            Console.WriteLine("Hibás a szám!");
        }
    }
}
