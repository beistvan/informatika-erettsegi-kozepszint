using System;
using System.Linq;
using System.Text;

class Hello
{
    static void Main(string[] args)
    {
        string[] fonevek = { "alma", "füzet", "Budapest", "ceruza", "kutya", "Zoltán", "Anna" };
        Random rnd = new Random();
        string veletlenSzo = fonevek[rnd.Next(fonevek.Length)];
        //veletlenSzo = "Anna";
        //Console.WriteLine(String.Join("", veletlenSzo.ToLower().ToCharArray().Reverse()));

        Console.WriteLine("\n2. feladat");

        if (veletlenSzo[0] >= 'a' && veletlenSzo[0] <= 'z')
        {
            Console.Write("A szó köznév");
        }
        if (veletlenSzo[0] >= 'A' && veletlenSzo[0] <= 'Z')
        {
            Console.Write("A szó tulajdonnév");
        }
        Console.WriteLine(" és {0} karakterből áll.", veletlenSzo.Length);

        Console.WriteLine("\n3. feladat");
        string forditottSzo = "";
        for (int i = veletlenSzo.Length - 1; i >= 0; i--)
        {
            forditottSzo += veletlenSzo[i];
        }
        //if (veletlenSzo.ToLower() == String.Join("", veletlenSzo.ToLower().ToCharArray().Reverse()))
        if (veletlenSzo.ToLower() == forditottSzo.ToLower())
        {
            Console.WriteLine("A szó palindrom.");
        }
        else
        {
            Console.WriteLine("A szó nem palindrom.");
        }
        Console.WriteLine("\n4. feladat");
        Console.WriteLine("Találd ki a választott szót!");
        Console.Write("a, Megadhatom a szó maszkját, amelyben a magánhangzók helyén csillag\n" +
            "szerepel, pl: h*z*f*l*d*t\n" +
            "b, Megadhatom a szót alkotó betüket, pl: fldtáiehaza\n" +
            "Milyen formában segítsek? (a/b) ");
        char valasz = char.Parse(Console.ReadLine());
        if (valasz == 'a' || valasz == 'A')
        {
            char[] maganhangzok = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U', 'á', 'Á', 'é', 'É', 'í', 'Í', 'ó', 'Ó', 'ö', 'Ö', 'ő', 'Ő', 'ú', 'Ú', 'ü', 'Ü', 'ű', 'Ű' };
            foreach (char betu in veletlenSzo)
            {
                bool ezMaganhangzo = false;
                foreach (char maganhangzo in maganhangzok)
                {
                    if (betu == maganhangzo)
                    {
                        ezMaganhangzo = true;
                        break;
                    }
                }
                if (ezMaganhangzo)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(betu);
                }
            }
            Console.WriteLine();
        }
        else if (valasz == 'b' || valasz == 'B')
        {
            StringBuilder osszekevertVeletlenSzo = new StringBuilder(veletlenSzo);
            do
            {
                for (int i = 0; i < osszekevertVeletlenSzo.Length; i++)
                {
                    int veletlenSzam = rnd.Next(osszekevertVeletlenSzo.Length);
                    char ideiglenesKarakter = osszekevertVeletlenSzo[i];
                    osszekevertVeletlenSzo[i] = osszekevertVeletlenSzo[veletlenSzam];
                    osszekevertVeletlenSzo[veletlenSzam] = ideiglenesKarakter;
                }
            }
            while (osszekevertVeletlenSzo.Equals(veletlenSzo));
            Console.WriteLine(osszekevertVeletlenSzo);
        }
        Console.Write("Add meg a tipped! ");
        string tipp = Console.ReadLine();
        if (tipp == veletlenSzo)
        {
            Console.WriteLine("Gratulálok, eltaláltad!");
        }
        else
        {
            Console.WriteLine("Sajnos nem talált, a keresett szó a(z) {0} lett volna.", veletlenSzo);
        }
    }
}
