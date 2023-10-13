using System;
using System.Reflection;
using System.Text.RegularExpressions;

class Solution
{
    static string betuVagySzam(string adatok, string tipus)
    {
        var betuszam = new Regex("(?<betu>^N?F)(?<szam>(\\d)+.?(\\d)*)");
        var egyezes = betuszam.Match(adatok);
        return egyezes.Groups[tipus].Value;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("1. feladat");
        string[] futasiAdatok = { "F5.3", "NF1", "F3.2", "NF0.6", "NF0", "F2.1", "NF2" };
        double versenytav = 0.0;
        int megallasokSzama = 0;
        int megszakitasokSzama = 0;
        bool gyaloglasUtanMegallt = false;

        for (int index = 0; index  < futasiAdatok.Length; index++)
        {
            string aktualisFutas = futasiAdatok[index];
            string elozoFutas = futasiAdatok[index - 1];
            string betu = betuVagySzam(aktualisFutas, "betu");
            string szam = betuVagySzam(aktualisFutas, "szam");
            versenytav += Convert.ToDouble(szam.Replace('.', ','));
            if (aktualisFutas == "NF0")
            {
                megallasokSzama++;
            }
            if (index > 0 && betuVagySzam(elozoFutas, "betu") == "F" && betu == "NF")
            {
                megszakitasokSzama++;
            }
            if (index > 0 && betuVagySzam(elozoFutas, "betu") != "F" && elozoFutas != "NF0" && aktualisFutas == "NF0")
            {
                gyaloglasUtanMegallt = true;
            }
            //Console.WriteLine("{0} --- {1}", betu, szam);
        }

        Console.WriteLine("\n2. feladat");
        Console.WriteLine("A verseny távja {0} km volt.", versenytav);

        Console.WriteLine("\n3. feladat");
        string utolsoElottiFutas = futasiAdatok[futasiAdatok.Length - 1];
        if (betuVagySzam(utolsoElottiFutas, "betu") == "NF")
        {
            Console.WriteLine("Gyalogolva ért célba.");
        }
        if (betuVagySzam(utolsoElottiFutas, "betu") == "F")
        {
            Console.WriteLine("Futva ért célba.");
        }
        //Console.WriteLine("{0} ért célba.", futasiAdatok[futasiAdatok.Length - 1][0] == 'F' ? "Futva" : "Gyalogolva");
        Console.WriteLine("\n4. feladat");
        Console.WriteLine("A verseny során {0} alkalommal állt meg.", megallasokSzama);

        Console.WriteLine("\n5. feladat");
        Console.WriteLine("A futását {0} alkalommal szakította meg.", megszakitasokSzama);

        Console.WriteLine("\n6. feladat");
        Console.WriteLine("{0}olt olyan alkalom, hogy gyaloglás után közvetlenül megállt.", gyaloglasUtanMegallt ? "V" : "Nem v");
    }
}
