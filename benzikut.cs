/* Benzinkút */
using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Uzemanyag
    {
        public char Tipus { get; set; }
        public int Mennyiseg { get; set; }

        public Uzemanyag(string uzemanyag)
        {
            Tipus = uzemanyag[0];
            Mennyiseg = Convert.ToInt32(uzemanyag.Substring(1));
        }

        public override string ToString()
        {
            return Tipus + Mennyiseg.ToString();
        }
    }

    static void Main()
    {
        Console.WriteLine("1. feladat");
        var uzemanyagTankolasok = new List<Uzemanyag>();

        /*
        uzemanyagTankolasok.Add(new Uzemanyag("B10"));
        uzemanyagTankolasok.Add(new Uzemanyag("B7"));
        uzemanyagTankolasok.Add(new Uzemanyag("D45"));
        uzemanyagTankolasok.Add(new Uzemanyag("B0"));
        uzemanyagTankolasok.Add(new Uzemanyag("D23"));
        uzemanyagTankolasok.ForEach(u => Console.WriteLine("Adja meg az üzemanyag típusát és mennyiségét! (pl. B4 vagy D23) " + u));
        // B10, B7, D45, B0, D23
        Console.WriteLine(String.Join(", ", uzemanyagTankolasok));
        */

        do {
            Console.Write("Adja meg az üzemanyag típusát és mennyiségét! (pl. B4 vagy D23) ");
            string uzemanyag = Console.ReadLine();
            if (uzemanyag == "") {
                break;
            }
            uzemanyagTankolasok.Add(new Uzemanyag(uzemanyag));
        } while (true);

        Console.WriteLine("\n2. feladat");
        Console.WriteLine("A benzinkúton {0} alkalommal vásároltak.",
                          uzemanyagTankolasok.Count(u => u.Mennyiseg != 0));

        Console.WriteLine("\n3. feladat");
        Console.WriteLine("{0}l benzint adtak el összesen.",
                          uzemanyagTankolasok.Where(u => u.Tipus == 'B').Sum(u => u.Mennyiseg));

        Console.WriteLine("\n4. feladat");
        Console.WriteLine("Egy alkalommal átlagosan {0:0.00}l üzemanyagot vásároltak.",
                          uzemanyagTankolasok.Where(u => u.Mennyiseg != 0).Select(u => u.Mennyiseg).Average());

        Console.WriteLine("\n5. feladat");
        Console.WriteLine("Az egy alkalommal eladott legnagyobb diesel mennyiség {0}l volt.",
                          uzemanyagTankolasok.Where(u => u.Tipus == 'D').Max(u => u.Mennyiseg));
    }
}
