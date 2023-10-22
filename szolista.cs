/* Szólista */
using System.IO;
using System;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. feladat");
        Console.WriteLine("Adj meg legalább 4 betűs szavakat vesszővel és szóközzel elválasztva!");
        string szavakFelsorolva = Console.ReadLine();
        //Console.WriteLine("alma, lapát, hűtőszekrény, alma, tető");
        //string szavakFelsorolva = "alma, lapát, hűtőszekrény, alma, tető";
        //alma, zsiraf, kendo, sas, pap, gep, alma
        //Console.WriteLine(szavakFelsorolva);
        string[] szavak = System.Text.RegularExpressions.Regex.Split(szavakFelsorolva, ", ");
        //Console.WriteLine(string.Join("--", szavak));

        Console.WriteLine("\n2. feladat");
        Console.WriteLine("A szavak listájában {0} ismétlődés.",
                          szavak.GroupBy(x => x).Any(g => g.Count() > 1) ? "van" : "nincs");

        Console.WriteLine("\n3. feladat");
        int minSzoHossz = szavak.Min(szo => szo.Length);
        string[] legrovidebbSzavak = szavak.Where(szo => szo.Length == minSzoHossz).ToArray();
        Console.WriteLine("A legrövidebb szó / szavak: " + string.Join(", ", legrovidebbSzavak));

        Console.WriteLine("\n4. feladat");
        int maxSzoHossz = szavak.Max(szo => szo.Length);
        string leghosszabbSzo = szavak.FirstOrDefault(szo => szo.Length == maxSzoHossz);
        //Console.WriteLine(leghosszabbSzo);
        char[] karakerTomb = leghosszabbSzo.Substring(1, leghosszabbSzo.Length - 2).ToCharArray();
        Array.Reverse(karakerTomb);
        string forditottBelsoSzo = new string(karakerTomb);

        Console.WriteLine("A szó belsejében lévő betűk visszafelé olvasva:");
        Console.WriteLine(leghosszabbSzo[0]
                          + forditottBelsoSzo
                          + leghosszabbSzo[leghosszabbSzo.Length - 1]);

        Console.WriteLine("\n5. feladat");
        Random rnd = new Random();
        string veletlenSzo = szavak[rnd.Next(szavak.Length)];

        char[] egyKarakterTomb = veletlenSzo.ToCharArray();
        int tombHossz = egyKarakterTomb.Length;
        while (tombHossz > 1) {
            int csereIndex = rnd.Next(tombHossz--);
            var ideiglenesKarakter = egyKarakterTomb[csereIndex];
            egyKarakterTomb[csereIndex] = egyKarakterTomb[tombHossz];
            egyKarakterTomb[tombHossz] = ideiglenesKarakter;
        }
        string osszekevertVeletlenSzo = new string(egyKarakterTomb);

        Console.WriteLine("A szó betűi véletlenszerű sorrendben:");
        Console.WriteLine(osszekevertVeletlenSzo);
    }
}
