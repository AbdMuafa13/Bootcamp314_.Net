using System;

namespace Logic02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------Menu--------");
            Console.WriteLine("| 1. Bangun Datar   |");
            Console.WriteLine("| 2. If Statement   |");
            Console.WriteLine("| 3. Else Statement |");
            Console.WriteLine("| 4. If Nested      |");
            Console.WriteLine("---------------------");

            Console.Write("Masukkan Pilihan Menu 1 - 4 : ");
            int menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    latihan();
                    break;
                case 2:
                    IfStatement();
                    break;
                case 3:
                    elseStatement();
                    break;
                default:
                    ifNested();
                    break;
            }

            //IfStatement();
            //elseStatement();
            //ifNested();
            //ternary();
            //switchCase();
            //latihan();

            Console.ReadLine();
        }

        static void modulus()
        {
            int angka, pembagi, hasil;
            Console.WriteLine("--Modulus test--");
            Console.Write("Masukkan angka : ");
            angka = int.Parse(Console.ReadLine());
            Console.Write("Masukkan pembagi : ");
            pembagi = int.Parse(Console.ReadLine());

            hasil = angka % pembagi;
            if(hasil == 0)
            {
                Console.Write("Angka {0} % {1} adalah 0", angka, pembagi);
            }
            else
            {
                Console.Write($"Angka {angka} % {pembagi} bukan 0 melainkan hasil mod {hasil}");
            }
        }

        static void latihan()
        {
            Console.WriteLine("\n--Latihan Test--");
            Console.WriteLine("Soal 1");
            const double phi = 3.14;
            double keliling, luas;
            int r;
            Console.Write("Masukkan Jari-Jari : ");
            r = Convert.ToInt32(Console.ReadLine());

            keliling = 2 * phi * r;
            luas = phi * r * r;

            Console.WriteLine("Hasil Keliling Lingkaran " + keliling);
            Console.WriteLine("Hasil Luas Lingkaran " + luas);

            Console.WriteLine("\nSoal 2");
            
            int kelilingpersegi, luaspersegi, s;
            Console.Write("Masukkan Sisi Persegi: ");
            s = int.Parse(Console.ReadLine());

            kelilingpersegi = 4 * s;
            luaspersegi = s * s;

            Console.WriteLine("Hasil Keliling Persegi " + kelilingpersegi);
            Console.WriteLine("Hasil Luas Persegi " + luaspersegi);

        }

        static void switchCase()
        {
            Console.WriteLine("--Switch Case--");
            Console.Write("Pilih buah kesukaan Anda (apel / jeruk / pisang) : ");
            string pilihan = Console.ReadLine().ToLower();
            switch (pilihan)
            {
                case "apel":
                    Console.WriteLine("Anda memilih apel");
                    break;
                case "jeruk":
                    Console.WriteLine("Anda memilih jeruk");
                    break ;
                case "pisang":
                    Console.WriteLine("Anda memilih pisang");
                    break;
                    default: Console.WriteLine("Tidak ada dalam pilihan!");
                    break;
            }
        }

        static void ternary()
        {
            Console.WriteLine("--Ternary--");
            int x, y;
            Console.Write("Masukkan Nilai X : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai Y : ");
            y = int.Parse(Console.ReadLine());

            string z = (y > x) ? "Y lebih Besar dari X" : (x > y) ? "X lebih besar dari Y" : "Nilai X sama dengan Nilai Y";
            Console.WriteLine(z);
        }

        static void ifNested()
        {
            int nilai, hasil;
            Console.WriteLine("--If Nested--");
            Console.Write("Masukkan Nilai : ");
            nilai = int.Parse(Console.ReadLine());
            int nilaiMax = 100;
            if (nilai >= 70 && nilai <= nilaiMax)
            {
                
                if(nilai == 100)
                {
                    Console.WriteLine("Kamu keren!!");
                }
                else
                {
                    Console.WriteLine("Kamu Berhasil !");   
                }
            } 
            else if(nilai >= 0 && nilai <= 69)
            {
                Console.WriteLine("Kamu Belum Berhasil");
            }
            else
            {
                Console.WriteLine("Nilai Hanya Sampai 100!");
            }
        }

        static void elseStatement()
        {
            Console.WriteLine("--If Else Statement--");
            Console.Write("Masukkan Nilai X : ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai Y : ");
            int y = int.Parse(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine( "Nilai x > y "+ (x > y));
            } 
            else if (y > x)
            {
                Console.WriteLine("Nilai y > x " + (y > x));
            }
            else
            {
                Console.WriteLine("Nilai x == y " + (x == y));
            }

        }
        static void IfStatement()
        {
            Console.WriteLine("--If Statement--");
            int x, y;
            Console.Write("Masukkan Nilai X : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai Y : ");
            y = int.Parse(Console.ReadLine());

            if(x > y)
            {
                Console.WriteLine("Nilai X > Y" + (x > y));
            }
            if( y > x)
            {
                Console.WriteLine("Nilai Y > X " + (y > x));
            }
            if (x == y)
            {
                Console.WriteLine("Nilai X == Y " + (x == y));
            }
        }
    }
}
