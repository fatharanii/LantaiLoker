using System;

public class LantaiLoker
{
    public static void Main(string[] args)
    {
        double no_loker, lantai, kelipatan;
        lantai = 0;
        Console.Write("Masukan Nomor Loker:");
        no_loker = int.Parse(Console.ReadLine());
        kelipatan = Math.Floor(no_loker/18);
        if (no_loker%18 <= 5 && no_loker%18 != 0){
            lantai = 1;
        }
        else if (no_loker%18 <= 11 && no_loker%18 > 5){
            lantai = 2;
        }
        else if (no_loker%18 <= 18 && no_loker%18 > 11){
            lantai = 3;
        }
        lantai = (kelipatan * 3) + lantai;
        Console.WriteLine($"Loker Berada di Lantai: {lantai}");
    }
}