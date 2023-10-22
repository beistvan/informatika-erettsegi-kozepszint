/* Kosárlabda */
using System.IO;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("1.feladat");
        Console.WriteLine("Adja meg a kosárlabdacsapat eredményét!");
        Console.WriteLine("győzelem: 1, vereség: 2, döntetlen: x");
        Console.WriteLine("A heti fordulók eredményeit egy karaktersorozat formájában adja meg!");
        Console.Write("(pl: 11x21xx221) ");
        string eredmenyek = Console.ReadLine();
        //string eredmenyek = "1111x2x1xxxxx"; // 2x122111111x21 // "xxx112x1xx111" // "1111x2x1" 

        Console.WriteLine("\n2.feladat");
        Console.WriteLine("A fordulók száma " + eredmenyek.Length);
        Console.WriteLine("A vereségek száma: " + eredmenyek.Count(elem => elem == '2'));

        Console.WriteLine("\n3.feladat");
        var pontozas = new Dictionary<char, int> {
            {'1', 3},
            {'2', 0},
            {'x', 1}
        };
        Console.WriteLine("A fordulók során szerzett összpontszám: "
                          + eredmenyek.Sum(elem => pontozas[elem]));

        Console.WriteLine("\n4.feladat");
        //Regex reg = new Regex(@"(\w)\1+");
        /*
        MatchCollection szeriak = reg.Matches(eredmenyek);
        int maxhossz = 0;
        foreach (var szeria in szeriak) {
            //Console.WriteLine(szeria);
            if (szeria.ToString().Length > maxhossz) maxhossz = szeria.ToString().Length;
        }
        Console.WriteLine("A leghosszabb győzelmi széria {0} fordulón át tartott.", maxhossz);
        */
        Console.WriteLine("A leghosszabb győzelmi széria {0} fordulón át tartott.",
                          new Regex(@"(1)\1+").Matches(eredmenyek).Max(elem => elem.Length));

        Console.WriteLine("\n5.feladat");
        if (eredmenyek.Contains("2x1")) {
            Console.WriteLine("Volt vereség-döntetlen-győzelem hármas a szezonban.");
            if (eredmenyek.IndexOf("2x1") + 3 < eredmenyek.Length) {
                var merkozesEredmeny = new Dictionary<char, string> {
                    {'1', "győzelem"},
                    {'2', "vereség"},
                    {'x', "döntetlen"}
                };
                Console.WriteLine("Ezután {0} következett.",
                                  merkozesEredmeny[
                                      char.Parse(
                                          eredmenyek.Substring(eredmenyek.IndexOf("2x1") + 3, 1)
                                      )
                                  ]);
            } else {
                Console.WriteLine("Ezután nem volt több mérkőzés.");
            }
        } else {
            Console.WriteLine("Nem volt vereség-döntetlen-győzelem hármas a szezonban.");
        }
    }
}
