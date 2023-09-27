using System;

namespace Erettsegi;

class Hello
{
    static void Main(string[] args)
    {
        FileStream fsr = new FileStream("tajszam.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fsr);
        string beolvasottSzoveg = sr.ReadLine();
        sr.Close();
        fsr.Close();
        Console.WriteLine(beolvasottSzoveg);
        int ellenorzoSzam = beolvasottSzoveg[8] - '0'; //Convert.ToInt32(beolvasottSzoveg[8]) - 48;
        Console.WriteLine(ellenorzoSzam);
        int szamjegyekOsszege = 0;
        for (int index = 0; index < beolvasottSzoveg.Length - 1; index++)
        {
            szamjegyekOsszege += (beolvasottSzoveg[index] - '0') * (index % 2 != 0 ? 7 : 3);
        }
        Console.WriteLine(szamjegyekOsszege);
        Console.WriteLine(szamjegyekOsszege % 10 == ellenorzoSzam ? "Helyes a szám!" : "Hibás a szám!");
    }
}
