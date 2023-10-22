/* Madár */
using System.IO;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. feladat");
        Console.Write("Adj meg egy 5 és 10 közé eső számot! ");
        int atrepulesekSzama = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n2. feladat");
        Random rnd = new Random();
        int[] atrepulesek = new int[atrepulesekSzama];
        for (int index = 0; index < atrepulesekSzama; index++) {
            atrepulesek[index] = rnd.Next(1, 31);
        }
        Console.WriteLine("A tömb elkészült.");

        Console.WriteLine("\n3. feladat");
        Console.WriteLine("A mérés kezdetét (0. percet) követően mikor (hányadik percben) repült");
        Console.WriteLine("át a madár az ablakon:");

        Array.Sort(atrepulesek);
        Console.WriteLine("[" + string.Join(", ", atrepulesek) + "]");

        Console.WriteLine("\n4. feladat");
        Console.WriteLine("A madár az utolsó átrepüléskor {0}repült a szobáb{1}.",
                          atrepulesekSzama % 2 == 1 ? "be" : "ki",
                          atrepulesek.Length % 2 == 1 ? "a" : "ól");

        Console.WriteLine("\n5. feladat");
        Console.WriteLine("A madár által a szobában töltött időszakok hossza:");
        int szamlalo = 1;
        int legtobbIdo = 0;
        for (int index = 1; index < atrepulesekSzama - atrepulesekSzama % 2; index += 2) {
            int idokulonbseg = atrepulesek[index] - atrepulesek[index - 1];
            Console.WriteLine("{0}. alkalommal: {1} percet töltött bent a madár.",
                              szamlalo++, idokulonbseg);
            if (idokulonbseg > legtobbIdo) {
                legtobbIdo = idokulonbseg;
            }
        }
        Console.WriteLine("\nA legtöbb bent töltött idő: {0} perc volt.", legtobbIdo);
    }
}
