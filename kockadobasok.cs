/* Kockadobások */
using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("1. feladat");
        Console.Write("Add meg a dobások számát! ");
        int dobasokSzama = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\n2. feladat");
        Random rnd = new Random();
        int[] veletlenSzamok = new int[dobasokSzama];
        double dobasokAtlaga = 0.0;
        double dobasokOszege = 0;
        int hatosokSzama = 0;
        int parosokSzama = 0;
        int elozoKorbenTobbetDobottakSzama = 0;
        
        Console.Write("A dobások: [");
        for (int index = 0; index < dobasokSzama; index++) {
            int veletlenSzam  = rnd.Next(1, 7);
            veletlenSzamok[index] = veletlenSzam;
            Console.Write("{0}{1}", veletlenSzamok[index], index < dobasokSzama - 1 ? ", " : "]\n");
            dobasokOszege += veletlenSzam;
            if (veletlenSzam == 6) {
                hatosokSzama++;
            }
            if (veletlenSzam % 2 == 0) {
                parosokSzama++;
            }
            if (index > 0 && veletlenSzamok[index] < veletlenSzamok[index - 1]) {
                elozoKorbenTobbetDobottakSzama++;
            }
        }

        Console.WriteLine("\n3. feladat");
        dobasokAtlaga = dobasokOszege / dobasokSzama;
        Console.WriteLine("A játékos átlagosan {0:0.00} mezőt, összesen {1} mezőt haladt előre.", dobasokAtlaga, dobasokOszege);

        Console.WriteLine("\n4. feladat");
        if (hatosokSzama > 0) {
            Console.WriteLine("A játékos {0} alkalommal dobott hatost.", hatosokSzama);
        } else {
            Console.WriteLine("A játékos sajnos egy alkalommal sem dobott hatost.");
        }

        Console.WriteLine("\n5. feladat");
        Console.WriteLine("A játékos {0} dobott páros számot.",
                          parosokSzama > 0 ? parosokSzama + " alkalommal"
                                           : "sajnos egy alkalommal sem");

        Console.WriteLine("\n6. feladat");
        Console.WriteLine("A játékos {0} dobott kevesebbet, mint előző körben.",
                          elozoKorbenTobbetDobottakSzama > 0 
                          ? elozoKorbenTobbetDobottakSzama + " alkalommal"
                          : "sajnos egy alkalommal sem");
    }
}
