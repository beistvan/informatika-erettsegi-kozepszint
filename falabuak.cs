using System;

class Hello
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. feladat");
        Console.Write("Fordulók száma: ");
        int forduloszam = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("2. feladat");
        int[] golkulonbsegek = new int[forduloszam];
        for (int i = 1; i <= forduloszam; i++)
        {
            Console.Write("{0}. fordulóban a gólkülönbség: ", i);
            golkulonbsegek[i - 1] = Convert.ToInt32(Console.ReadLine());
        }
    }
}
