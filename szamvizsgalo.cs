using System;

class Hello
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. feladat");
        int szam;
        do
        {
            Console.WriteLine("Adj meg egy legalább 5 számjegyből álló számot!");
            szam = Convert.ToInt32(Console.ReadLine());
        }
        while (szam < 10000);

        Console.WriteLine("\n2. feladat");
        if (szam % 5 == 0 && szam % 10 == 0)
        {
            Console.WriteLine("A szám osztható öttel és tízzel is.");
        }
        else
        {
            Console.WriteLine("A szám nem osztható öttel és tízzel is.");
        }

        Console.WriteLine("\n3. feladat");
        int teljesSzam = szam;
        while (teljesSzam > 0)
        {
            Console.Write(teljesSzam % 10);
            teljesSzam /= 10;
        }

        Console.WriteLine("\n\n4. feladat");
        int[] tomb = new int[10] {0,0,0,0,0,0,0,0,0,0};
        int szamlalo = 0;
        teljesSzam = szam;
        while (teljesSzam > 0)
        {
            if (teljesSzam % 2 == 0)
            {
                tomb[szamlalo++] = teljesSzam % 10;
            }
            teljesSzam /= 10;
        }
        //Rendezés beszúrással
        for (int i = 0; i < szamlalo - 1; i++)
        {
            for (int j = i + 1; j < szamlalo; j++)
            {
                if (tomb[i] > tomb[j])
                {
                    int ideiglenes = tomb[i];
                    tomb[i] = tomb[j];
                    tomb[j] = ideiglenes;
                }
            }
        }
        //Tömb kiiratása
        Console.Write("[");
        for (int i = 0; i < szamlalo - 1; i++)
        {
            Console.Write("{0}, ", tomb[i]);
        }
        Console.WriteLine("{0}]", tomb[szamlalo - 1]);

        Console.WriteLine("\n5. feladat");
        int[] szamjegyek = new int[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        teljesSzam = szam;
        while (teljesSzam > 0)
        {
            szamjegyek[teljesSzam % 10]++;
            teljesSzam /= 10;
        }
        for (int i = 0; i < 10; i++)
        {
            //Console.WriteLine("{0}-{1}", i, szamjegyek[i]);
            if (szamjegyek[i] > 1)
            {
                Console.Write("{0}, ", i);
            }
        }

        Console.WriteLine("\n\n6. feladat");
        string maszkoltSzam = "";
        teljesSzam = szam;
        szamlalo = 0;
        while (teljesSzam > 0)
        {
            maszkoltSzam = "x" + maszkoltSzam;
            if (teljesSzam / 10 != 0 && (szamlalo + 1) % 3 == 0)
            {
                maszkoltSzam = "." + maszkoltSzam;
            }
            teljesSzam /= 10;
            szamlalo++;
        }
        Console.WriteLine(maszkoltSzam);
    }
}
