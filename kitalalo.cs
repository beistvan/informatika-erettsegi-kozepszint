using System;
using System.IO;
using System.Linq.Expressions;
using System.Text;

class Program 
{ 
    static void Main(string[] args) 
    {
        FileStream fsr = new FileStream("szavak.txt", FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fsr);
        string beolvasottSzoveg = sr.ReadToEnd();
        //Console.WriteLine(beolvasottSzoveg);
        beolvasottSzoveg = beolvasottSzoveg.Replace("\"", "").Replace(",", "");
        //Console.WriteLine(beolvasottSzoveg);
        string[] tomb = beolvasottSzoveg.Split();
        //Console.WriteLine(String.Join("; ", tomb));
        //foreach (string elem in tomb)
        //{
            //Console.WriteLine(elem);
        //}
        Random rand = new Random();
        int veletlenSzam = rand.Next(tomb.Length);
        //Console.WriteLine(veletlenSzam);
        string valasz;
        string talalatSzo = "";
        int szamlalo = 0;
        do
        {
            //Console.WriteLine(tomb[veletlenSzam]);
            string veletlenSzo = tomb[veletlenSzam];
            Console.Write("Tippelt szó: ");
            valasz = Console.ReadLine();
            talalatSzo = "";
            for (int i = 0; i < 6; i++)
            {
                if (veletlenSzo[i] == valasz[i])
                {
                    talalatSzo += veletlenSzo[i];
                }
                else
                {
                    talalatSzo += ".";
                }
            }
            Console.WriteLine(talalatSzo);
            szamlalo++;
        } 
        while (valasz != "stop" && valasz != talalatSzo);
        if (valasz != "stop")
        {
            Console.Write("Próbálkozások száma: {0}", szamlalo);
        }
        sr.Close();
        fsr.Close();
    }
}
