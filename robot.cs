using System;

namespace Erettsegi;

class Hello
{
    static void Main(string[] args)
    {
        Console.Write("Kérem a robot parancsait: ");
        string parancsok = Console.ReadLine();

        Dictionary<char, int> parancsszam = new Dictionary<char, int>()
        {
            { 'E', 0 },
            { 'D', 0 },
            { 'K', 0 },
            { 'N', 0 },
        };

        foreach (char parancs in parancsok)
        {
            parancsszam[parancs]++;
        }

        foreach (var parancs in parancsszam)
        {
            Console.WriteLine("{0} betűk száma: {1}", parancs.Key, parancs.Value);
        }

        string rovidebbUtvonal = "";
        int fuggolegesTavolsag = parancsszam['E'] - parancsszam['D'];
        int vizszintesTavolsag = parancsszam['K'] - parancsszam['N'];
        char fuggolegesIrany, vizszintesIrany;

        if (fuggolegesTavolsag > 0)
        {
            fuggolegesIrany = 'E';
        }
        else
        {
            fuggolegesIrany = 'D';
        }

        if (vizszintesTavolsag > 0)
        {
            vizszintesIrany = 'K';
        }
        else
        {
            vizszintesIrany = 'N';
        }

        for (int i = 0; i < Math.Abs(vizszintesTavolsag); i++)
        {
            rovidebbUtvonal += vizszintesIrany;
        }

        for (int i = 0; i < Math.Abs(fuggolegesTavolsag); i++)
        {
            rovidebbUtvonal += fuggolegesIrany;
        }

        Console.WriteLine("Egy legrövidebb útvonal: {0}", rovidebbUtvonal);
    }
}
