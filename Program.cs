using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_2_1214064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu Persegi Panjang, silahkan pilih...");
            Console.WriteLine("1. Hitung Luas");
            Console.WriteLine("2. Hitung Keliling");
            Console.Write("Menu Pilihan: ");
            int choose = int.Parse(Console.ReadLine());

            switch (choose) 
            {
                case 1 : Console.WriteLine("Kamu memilih Hitung Luas.");
                    Console.WriteLine("Masukkan Panjang Persegi: ")
                    int panjang;
                    panjang = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan lebar Persegi: ");
                    int Tinggi;
                    Tinggi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Berikut ini adalah hasil dari perhitungannya: ");
                    int luas = panjang * Tinggi;
                    Console.WriteLine($"{panjang} x {Tinggi} = {luas}"); continue;
                    Console.WriteLine("Ingin mengulang Kembali? (Y/T)");
                    var nextchap;
                    switch (nextchap)
                    {
                        case "Y" : continue;
                        case "T" : break;
                        default : Console.WriteLine("Ingin mengulang Kembali? (Y/T)"); break;
                    }
                case 2 : Console.WriteLine("Kamu memilih Hitung Keliling."); 
                    Console.WriteLine("Masukkan Panjang Persegi: ");
                    Console.Read()
                    int panjang2;
                    panjang2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Masukkan Lebar Persegi: ");
                    int lebar;
                    lebar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Berikut ini adalah hasil dari perhitungannya: ");
                    int luas2 = panjang2 + lebar;
                    int keliling = 2 * luas2;
                    Console.WriteLine($"2 x ( {panjang2} x {lebar} ) = {keliling}"); break;
                default: Console.WriteLine("Menu Tidak Tersedia"); break;
            }
            Console.Read();
        }
    }
}
