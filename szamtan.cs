/* Számtan */
using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. feladat");
        int szam = 0;
        do {
            Console.Write("Adj meg egy a [-100000;100000] tartományba eső egész számot! ");
            szam = Convert.ToInt32(Console.ReadLine());
        } while (szam < -100000 || szam > 100000);

        Console.WriteLine("\n2. feladat");
        Console.WriteLine("A szám {0} és hárommal {1}osztható.",
                          szam % 2 == 0 ? "páros" : "páratlan",
                          szam % 3 != 0 ? "nem " : "");

        Console.WriteLine("\n3. feladat");
        Console.WriteLine("A szám abszolút értéke: {0}", Math.Abs(szam));

        Console.WriteLine("\n4. feladat");
        if (szam % 5 == 0) {
            Console.WriteLine("A szám osztható öttel.");
        } else {
            Console.WriteLine("A szám abszolút értékéhez legközelebb eső, nála nagyobb öttel osztható szám a(z) {0}.",  szam + ((1 + Math.Sign(szam)) / 2) * 5 - szam % 5);
        }

        Console.WriteLine("\n5. feladat");
        string szovegesSzam = Math.Abs(szam).ToString();
        Console.WriteLine("A középső számjegy(ek): {0}",
                          szovegesSzam == "100000" ? "00"
                          : (szovegesSzam.Length == 3 || szovegesSzam.Length == 5 ?
                             szovegesSzam[(szovegesSzam.Length - 1) / 2] + ""
                             : (szovegesSzam.Length == 4 ? szovegesSzam.Substring(1, 2)
                                : "nincsenek")));
    }
}
