using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_4_1204036
{
    class Program
    {
        static void Main(string[] args)
        {
            float leb_pers, Panjang, Lebar;
            int PILIH;
            float rumus_pd, a, b;
            double pd;

            //Menu
            Console.WriteLine("MENU PERSEGI PANJANG");
            Console.WriteLine("1. Hitung Luas");
            Console.WriteLine("2. Hitung Keliling");
            Console.WriteLine("3. Hitung Panjang Diagonal");
            Console.Write("Menu Pilihan : ");
            PILIH = Convert.ToInt16(Console.ReadLine());

            switch(PILIH)
            {
                    //Rumus Hitung Luas
                case 1:
                    Console.Write("Masukan Panjang :");
                    Panjang = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Masukan Lebar : ");
                    Lebar = Convert.ToSingle(Console.ReadLine());
                    leb_pers = Panjang * Lebar;
                    Console.WriteLine("Luas Persegi Panjang adalah  = " + leb_pers);
                    Console.ReadKey();
                    break;

                    // Rumus Hitung Keliling
                case 2:
                    Console.Write("Masukan Panjang :");
                    Panjang = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Masukan Lebar : ");
                    Lebar = Convert.ToSingle(Console.ReadLine());
                    leb_pers = 2 * (Panjang + Lebar);
                    Console.WriteLine("Hasil dari Keliling Persegi Panjang adalah = " +leb_pers);
                    Console.ReadKey();
                    break;

                    //Rumus Panjang Diagonal
                case 3:
                    Console.Write("Masukan Panjang :");
                    Panjang = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Masukan Lebar :");
                    Lebar = Convert.ToSingle(Console.ReadLine());
                    rumus_pd = (Panjang * Panjang) + (Lebar * Lebar);
                    pd = Math.Sqrt(rumus_pd);
                    Console.WriteLine("Panjang Diagonal Persegi Panjang adalah : " + pd);
                    Console.ReadKey();
                    break;

            }
        }
    }
}
