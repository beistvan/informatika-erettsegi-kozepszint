using System;
using System.Linq;

namespace Erettsegi;

class Hello
{
    static void Main(string[] args)
    {
        StreamReader sr = new StreamReader("testsuly.txt");
        double kivantTesttomeg = Convert.ToDouble(sr.ReadLine());
        Console.WriteLine("Elérni kívánt testtömeg (kg) = {0}", kivantTesttomeg);
        int hetekSzama = 0;
        int sorszam = 0;
        bool celtElerte = false;
        int celsorszam = 0;
        double[] testtomeg = new double[10];
        while (!sr.EndOfStream)
        {
            double suly = Convert.ToDouble(sr.ReadLine());
            testtomeg[sorszam] = suly;
            Console.WriteLine("{0}. héten = {1}", sorszam + 1, suly);
            if (suly <= kivantTesttomeg)
            {
                celtElerte = true;
                celsorszam = sorszam + 1;
            }
            sorszam++;
        }
        hetekSzama = sorszam;
        Console.WriteLine("Hetek száma = {0}", hetekSzama);
        if (celtElerte)
        {
            Console.WriteLine("Mari néni a(z) {0}. héten érte el a célt.", celsorszam);
        }
        else
        {
            Console.WriteLine("Sajnos Mari néni nem érte el a célját.");
        }
        int novekmenyekSzama = 0;
        for (int i = 1; i < testtomeg.Length; i++)
        {
            if (testtomeg[i - 1] < testtomeg[i])
            {
                novekmenyekSzama++;
            }
        }
        Console.WriteLine("A tömege {0} esetben nőtt egyik hétről a másikra.", novekmenyekSzama);
        /*string beolvasottSzoveg = sr.ReadToEnd();
        double[] tomb = beolvasottSzoveg.Split('\n').Select(x => double.Parse(x)).ToArray();
        for (int i = 0; i < tomb.Length; i++)
          {
            Console.WriteLine(tomb[i]);
          }
        Console.WriteLine(beolvasottSzoveg);*/
        sr.Close();
    }
}
