using System;

class Falabuak
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. feladat");
        Console.Write("Fordulók száma: ");
        int forduloszam = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n2. feladat");
        int[] golkulonbsegek = new int[forduloszam];
        int gyozelem = 0;
        int dontetlen = 0;
        int vereseg = 0;
        int osszpontszam = 0;
        int celmennyiseg = 0;
        for (int i = 1; i <= forduloszam; i++)
        {
            Console.Write("{0}. fordulóban a gólkülönbség: ", i);
            golkulonbsegek[i - 1] = Convert.ToInt32(Console.ReadLine());
            if (golkulonbsegek[i - 1] > 0)
            {
                gyozelem++;
                osszpontszam += 3;
            }
            else if (golkulonbsegek[i - 1] < 0)
            {
                vereseg++;
            }
            else
            {
                dontetlen++;
                osszpontszam += 1;
            }

            if (i > 1 && golkulonbsegek[i - 2] > 0 && golkulonbsegek[i - 1] > golkulonbsegek[i - 2])
            {
                celmennyiseg++;
            }
        }
        Console.WriteLine("\n3. feladat");
        Console.WriteLine("A szezonban a csapatnak {0} győzelme, {1} veresége, {2} döntetlene volt.", gyozelem, vereseg, dontetlen);
        
        Console.WriteLine("\n4. feladat");
        Console.WriteLine("A csapatnak a szezonban összesen {0} pontja lett.", osszpontszam);

        Console.WriteLine("\n5. feladat");
        string volt_e = "";
        if (!(gyozelem > dontetlen + vereseg))
        {
            volt_e = "nem volt ";
        }
        Console.WriteLine("A csapatnak {0}több győztes mérkőzése volt, mint veresége és döntelene együttvéve.", volt_e);
        
        Console.WriteLine("\n6. feladat");
        Console.WriteLine("A kitűzött célt {0} sikerült elérnie a csapatnak.", 
            celmennyiseg > 0 ? celmennyiseg.ToString() + " alkalommal": "nem");
    }
}
