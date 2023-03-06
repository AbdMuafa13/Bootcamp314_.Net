using System;

namespace Logic03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //modulus();
            //tesPuntung();
            //gradeNilai();
            //ganjilGenap();
            //perulanganWhile();
            menu();

            Console.ReadLine();
        }

        static void menu()
        {
            bool ulangi = true;
            int input;
            while (ulangi)
            {
                Console.WriteLine("\n----Menu tugas Logic 03----");
                Console.WriteLine("|   1. tes puntung rokok   |");
                Console.WriteLine("|   2. modulus             |");
                Console.WriteLine("|   3. perulangan while    |");
                Console.WriteLine("|   4. perulangan          |");
                Console.WriteLine("|   5. Tugas 1             |");
                Console.WriteLine("|   6. Tugas 2             |");
                Console.WriteLine("|   7. Tugas 3             |");
                Console.WriteLine("|   8. Bersarang           |");
                Console.WriteLine("|   9. Array For           |");
                Console.WriteLine("|   10. Array 2 Dimensi    |");
                Console.WriteLine("|   11. Array 2 Dimensi For|");

                Console.Write("Pilih menu : ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        tesPuntung();
                        break;
                    case 2:
                        modulus();
                        break;
                    case 3:
                        perulanganWhile();
                        break;
                    case 4:
                        perulangan();
                        break;
                    case 5:
                        tugas1();
                        break;
                    case 6:
                        tugas2();
                        break;
                    case 7:
                        tugas3();
                        break;
                    case 8:
                        bersarang();
                        break;
                    case 9:
                        arrayFor();
                        break;
                    case 10:
                        array2Dimensi();
                        break;
                    case 11:
                        array2DimensiFor();
                        break;
                    case 12:
                        splitJoin();
                        break;
                    case 13:
                        subString();
                        break;
                    case 14:
                        stringToCharArray();
                        break;
                    default:
                        Console.WriteLine("Masukkan hanya 1 - 3 dan angka!");
                        break;
                }
                ulangi = false;
            }
        }

        static void stringToCharArray()
        {
            Console.WriteLine("\n--String To Char Array--");
            Console.Write("Masukkan Kalimat : ");
            string kalimat = Console.ReadLine();
            char[] array = kalimat.ToCharArray();

            foreach(char ch in array)
            {
                Console.WriteLine(ch);
            }
            kembali();
        }

        static void subString()
        {
            Console.WriteLine("--\nSubstring--");
            Console.Write("Masukkan Kalimat : ");
            string kalimat = Console.ReadLine();

            Console.WriteLine("Substring (1,4)" + kalimat.Substring(1, 4));
            Console.WriteLine("Substring (5,2)" + kalimat.Substring(5, 2));
            Console.WriteLine("Substring (7,9)" + kalimat.Substring(7, 9));
            kembali();
        }

        static void splitJoin()
        {
            Console.WriteLine("\n--Split dan Join");
            Console.Write("Masukkan Kalimat : ");
            string kalimat = Console.ReadLine();
            //string kalimat = "Saya adalah anak bootcamp PT XSIS MITRA UTAMA batch 314";
            //string[] strings = kalimat.Split('\u002C');
            string[] kata = kalimat.Split(" ");
            foreach (string s in kata)
            {
                Console.Write(s);
            }

            Console.WriteLine("Apakah ingin kembali ke menu ? (y/n) ");
            string menuInput = Console.ReadLine().ToLower();
            if (menuInput == "y")
            {
                menu();
            }
            kembali();
        }
        
        static void array2DimensiFor()
        {
            int[,] array = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            //cetak
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Apakah ingin kembali ke menu ? (y/n) ");
            string menuInput = Console.ReadLine().ToLower();
            if (menuInput == "y")
            {
                menu();
            }
        }

        static void array2Dimensi()
        {
            int[,] array = new int[,]
            {
                {1,2,3 },
                {4,5,6 },
                {2,4,5 }
            };

            //cetak
            Console.WriteLine(array[0,2]);

            kembali();
        }

        static void arrayFor()
        {
            string[] array = new string[]
            {
                "Muafa",
                "marchel",
                "alwi",
                "alfi"
            };

            //baca array menggunakan for
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine("Apakah ingin kembali ke menu ? (y/n) ");
            string menuInput = Console.ReadLine().ToLower();
            if (menuInput == "y")
            {
                menu();
            }
        }

        static void tugas1()
        {
            Console.WriteLine("\n--Grade Nilai Mahasiswa--");
            int nilai;
            Console.Write("Masukkan Nilai Mahasiswa : ");
            nilai = int.Parse(Console.ReadLine());

            if (nilai >= 90 && nilai <= 100)
            {
                Console.WriteLine("Nilai {0} mendapatkan grade A", nilai);
            }
            else if (nilai >= 70 && nilai < 90)
            {
                Console.WriteLine($"Nilai {nilai} mendapatkan grade B");

            }
            else if (nilai >= 50 && nilai < 70)
            {
                Console.WriteLine($"Nilai {nilai} mendapatkan grade C");

            }
            else if (nilai >= 1 && nilai < 50)
            {
                Console.WriteLine($"Nilai {nilai} mendapatkan grade D");
            }
            else
            {
                Console.WriteLine("Isi nilai dengan benar");
            }
            Console.WriteLine("Apakah ingin kembali ke menu ? (y/n) ");
            string menuInput = Console.ReadLine().ToLower();
            if (menuInput == "y")
            {
                menu();
            }
        }

        static void tugas2()
        {
            Console.WriteLine("\n--Membeli Pulsa--");
            Console.WriteLine("Keterangan : \nPulsa 10.000 mendapatkan poin 80 \nPulsa 20.000 mendapatkan poin 80");
            Console.WriteLine("Pulsa 25.000 mendapatkan poin 200 \nPulsa 50.000 mendapatkan poin 400 \nPulsa 100.000 mendapatkan poin 800");
            int pulsa, poin, hasil;
            Console.Write("Masukkan jumlah pulsa : ");
            pulsa = Convert.ToInt32(Console.ReadLine());

            if(pulsa == 100000)
            {
                Console.WriteLine($"Pulsa : {pulsa}");
                Console.WriteLine("Point : 800 ");
            }else if(pulsa >= 50000 && pulsa < 100000)
            {
                Console.WriteLine($"Pulsa : {pulsa}");
                Console.WriteLine("Point : 400 ");
            }
            else if (pulsa >= 25000 && pulsa < 50000)
            {
                Console.WriteLine($"Pulsa : {pulsa}");
                Console.WriteLine("Point : 200 ");
            }
            else if (pulsa >= 10000 && pulsa < 25000)
            {
                Console.WriteLine($"Pulsa : {pulsa}");
                Console.WriteLine("Point : 80 ");
            }
            else
            {
                Console.WriteLine("Isi Pulsa Yang Benar!");
            }

            kembali();
        }

        static void tugas3()
        {
            Console.WriteLine("\n--GrabFood--");

            int jarak, belanja, diskon, total, ongkir;
            int diskonMax = 30000;
            Console.Write("Belanja : ");
            belanja = int.Parse(Console.ReadLine());
            Console.Write("Jarak : ");
            jarak = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Promo : ");
            string promo = Console.ReadLine().ToUpper();
            bool isPromo = promo == "JKTOVO";

            //total = belanja + diskon + ongkir ;
            ongkir = jarak * 1000;
            //int ongkirTambahan = (jarak - 5) * ongkir ;
            diskon = belanja * 40 / 100;

            if(jarak > 5 && isPromo)
            {
                if (belanja >= 30000)
                {
                        total = belanja + ongkir - diskon;
                        Console.WriteLine($"Belanja       : {belanja}");
                        Console.WriteLine($"Diskon Ongkir : {diskon}");
                        Console.WriteLine($"Ongkos Kirim  : {ongkir}");
                        Console.WriteLine($"Total Belanja : {total}");
               
                }
                else if (isPromo == false && belanja >= 100 && belanja < 30000 && jarak >= 1 && jarak <= 5)
                {
                    diskon = 0;
                    total = belanja + ongkir;
                    Console.WriteLine($"Belanja       : {belanja}");
                    Console.WriteLine($"Diskon Ongkir : {diskon}");
                    Console.WriteLine($"Ongkos Kirim  : {ongkir}");
                    Console.WriteLine($"Total Belanja : {total}");
                }
            }

            else
            {
                Console.WriteLine("Harap Belanja terlebih dahulu!");
            }
            //else
            //{
            //    total = belanja + ongkir;
            //    Console.WriteLine($"Belanja       : {belanja}");
            //    Console.WriteLine($"Diskon Ongkir : {diskon}");
            //    Console.WriteLine($"Ongkos Kirim  : {ongkir}");
            //    Console.WriteLine($"Total Belanja : {total}");
            //}
            kembali();
        }

        static void kembali()
        {
            Console.WriteLine("\nApakah ingin kembali ke menu ? (y/n) ");
            string menuInput = Console.ReadLine().ToLower();
            if (menuInput == "y")
            {
                menu();
            }
        }

        static void bersarang()
        {
            Console.WriteLine("\n--For Bersarang--");
            Console.Write("Masukkan angka : ");
            int angka = int.Parse(Console.ReadLine());
            for(int i = 0; i < angka; i++)
            {
                for(int j = 0; j < angka; j++)
                {
                    Console.Write($"[{i},{j}]");
                }
                Console.WriteLine();
            }

            Console.Write("\nApakah ingin kembali ke menu ? (y/n) ");
            string menuInput = Console.ReadLine().ToLower();
            if (menuInput == "y")
            {
                menu();
            }
        }

        static void perulangan()
        {
            for(int i = 0 ; i < 10 ; i++)
            {
                Console.WriteLine("increment");
                Console.WriteLine( i);
            }
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("decrement");
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if(i == 5)
                {
                    break;
                }
                Console.WriteLine("break");
                Console.WriteLine(i);
            }
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    break;
                }
                Console.WriteLine("continue");
                Console.WriteLine(i);
            }
            Console.WriteLine("Apakah ingin kembali ke menu ? (y/n)");
            string menuInput = Console.ReadLine().ToLower();
                if (menuInput == "y")
                {
                    menu();
                }
        }

        static void perulanganWhile()
        {
            Console.WriteLine("--Perulangan While--");
            bool ulangi = true;
            int nilai = 0;

            while (ulangi)
            {
                Console.WriteLine($"Proses ke : {nilai}");
                nilai++;
                Console.Write("Ulangi proses ? (y/n) ");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    ulangi = true;
                }
                else if (input == "n")
                {
                    ulangi = false;
                }
                else
                {
                    nilai = 1;
                    Console.WriteLine("Hanya inputan y / n");
                    ulangi = true;
                }
            }

            Console.WriteLine("Apakah ingin kembali ke menu ? (y/n)");
            string menuInput = Console.ReadLine().ToLower();
            if (menuInput == "y")
            {
                menu();
            }
            
        }


        static void gradeNilai()
        {
            Console.WriteLine("--Grade Nilai--");
            int nilai;
            Console.Write("Masukkan Nilai : ");
            nilai = int.Parse(Console.ReadLine());

            if(nilai >= 80 && nilai <= 100)
            {
                Console.WriteLine("Nilai {0} lebih dari sama dengan 80 akan mendapat grade A", nilai);
            }else if(nilai >= 60 && nilai < 80)
            {
                Console.WriteLine($"Nilai {nilai} lebih dari sama dengan 60 dan kurang dari 80 akan mendapat grade B");

            }
            else if( nilai >= 1 && nilai < 60)
            {
                Console.WriteLine($"Nilai {nilai} kurang dari 60 akan mendapat grade C");
            }
            else
            {
                Console.WriteLine("Isi nilai dengan benar");
            }

        }

        static void ganjilGenap()
        {
            Console.WriteLine("--Ganjil Genap--");
            Console.Write("Masukkan angka : ");
            int angka = int.Parse(Console.ReadLine());
            if(angka % 2 == 0)
            {
                Console.WriteLine($"angka {angka} adalah genap");
            }
            else
            {
                Console.WriteLine($"Angka {angka} adalah ganjil");
            }
        }

        static void tesPuntung()
        {
            Console.WriteLine("--Tes Soal Puntung Rokok--");

            int puntung, batang, harga, sisa;
            Console.Write("Total puntung rokok : ");
            puntung = int.Parse(Console.ReadLine());
                batang = puntung / 8;
                harga = batang * 500;
                sisa = puntung % 8;
            
            if (puntung % 8 == 0 || puntung > 7)
            {
                int kurang = (puntung % 8) + sisa;
                Console.WriteLine($"8 puntung menjadi 1 batang rokok, hasil {batang} batang x 500 = Rp.{harga}");
                Console.WriteLine($"Sisa {sisa} puntung");
                Console.WriteLine($"Kurang {kurang} puntung");
            }
            else
            {
                Console.WriteLine($"Puntung masih kurang menjadi 1 batang baru ada {puntung} puntung");
            }
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
            if (hasil % 2 == 0)
            {
                Console.Write($"Angka {angka} % {pembagi} hasil mod {hasil}");
            }
            else
            {

            Console.Write($"Angka {angka} % {pembagi} bukan 0 melainkan hasil mod {hasil}");
            }
        }
    }
}
