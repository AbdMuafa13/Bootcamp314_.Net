using System;

namespace TugasLogic03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu();
            //Console.ReadLine();
        }

        static void menu()
        {
            bool ulangi = true;
            int input;
            while (ulangi)
            {
                Console.Clear();
                Console.WriteLine("\n----Menu tugas Logic 03----");
                Console.WriteLine("|   1. Nilai Mahasiswa     |");
                Console.WriteLine("|   2. Pulsa               |");
                Console.WriteLine("|   3. Grab Food           |");
                Console.WriteLine("|   4. Voucher Sopi        |");
                Console.WriteLine("|   5. Tugas Gen           |");
                Console.WriteLine("|   6. Perhitungan Gaji    |");
                Console.WriteLine("|   7. Berat Badan         |");
                Console.WriteLine("|   8. Nilai Rata-Rata     |");
                Console.WriteLine("|   9. Keluar              |");

                Console.Write("Pilih menu : ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        nilaiMahasiswa();
                        break;
                    case 2:
                        pulsa();
                        break;
                    case 3:
                        grabFood();
                        break;
                    case 4:
                        promoSopi();
                        break;
                    case 5:
                        tugasGen();
                        break;
                    case 6:
                        perhitunganGaji();
                        break;
                    case 7:
                        beratBadan();
                        break;
                    case 8:
                        nilaiRataRata();
                        break;
                    case 9:
                        ulangi = false;
                        Console.WriteLine("Berhasil keluar");
                        break;
                    default:
                        Console.WriteLine("Masukkan angka 1 - 9!");
                        break;
                }
                ulangi = false;
            }
        }
        static void kembali()
        {
            Console.WriteLine("\nApakah ingin kembali ke menu ? (y/n) ");
            string menuInput = Console.ReadLine().ToLower();
            if (menuInput == "y")
            {
                menu();
                Console.Clear();
            }
        }

        static void promoSopi()
        {
            bool ulangi = true;
            Console.WriteLine("\n--Promo Sopi--");
            Console.WriteLine("Voucher Promo Sopi");
            Console.WriteLine("1. Min.Order 30rb free ongkir 5rb dan potongan harga belanja 5rb");
            Console.WriteLine("2. Min.Order 50rb free ongkir 10rb dan potongan harga belanja 10rb");
            Console.WriteLine("3. Min.Order 100rb free ongkir 20rb dan potongan harga belanja 10rb");
            Console.Write("\nMasukkan total belanja : ");
            int belanja = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Ongkos Kirim : ");
            int ongkir = int.Parse(Console.ReadLine());
            Console.Write("Masukkan voucher menu promo sopi : ");
            int kode = int.Parse(Console.ReadLine());

            int diskonOngkir, diskonBelanja, totalBelanja, ongkirDiskon, belanjaDiskon;
            int totalOngkir, ongkosKirim;

            switch (kode)
            {
                case 1:
                    if(belanja >= 30000)
                    {
                        ongkirDiskon = 5000;
                        belanjaDiskon= 5000;
                        //ongkirDiskon = ongkir - ongkirDiskon;
                        //belanjaDiskon = belanja - diskonBelanja;
                        //diskonOngkir = ongkirDiskon >= 5000 ? ongkirDiskon : 0;
                        //diskonBelanja = belanjaDiskon >= 30000 ? belanjaDiskon : 0;
                        //diskonBelanja = belanja - belanjaDiskon; 
                        diskonOngkir = ongkir < ongkirDiskon ? 0 : ongkir - ongkirDiskon; 

                        //if (ongkir >= diskonOngkir)
                        //{
                            totalBelanja = belanja + diskonOngkir - belanjaDiskon;
                            Console.WriteLine($"Belanja : {belanja}");
                            Console.WriteLine($"Ongkos Kirim : {ongkir}");
                            Console.WriteLine($"Diskon Ongkir : {diskonOngkir}");
                            Console.WriteLine($"Diskon Belanja : {belanjaDiskon}");
                            Console.WriteLine($"Total Belanja : {totalBelanja}");
                        //}else if(ongkir < diskonOngkir)
                        //{
                        //    totalBelanja = belanja + ongkir;
                        //    Console.WriteLine($"Belanja : {belanja}");
                        //    Console.WriteLine($"Ongkos Kirim : {ongkir}");
                        //    Console.WriteLine($"Diskon Ongkir : {diskonOngkir}");
                        //    Console.WriteLine($"Diskon Belanja : {belanjaDiskon}");
                        //    Console.WriteLine($"Total Belanja : {totalBelanja}");
                        //}
                    }
                    else if(belanja >= 1000 && belanja < 30000)
                    {
                        totalBelanja = belanja + ongkir;
                        Console.WriteLine($"Belanja : {belanja}");
                        Console.WriteLine($"Ongkos Kirim : {ongkir}");
                        Console.WriteLine($"Diskon Ongkir : 0");
                        Console.WriteLine($"Diskon Belanja : 0");
                        Console.WriteLine($"Total Belanja : {totalBelanja}");
                    }
                    else
                    {
                        Console.WriteLine("Minimum belanja Rp. 30.000, free ongkir dan potongan belanja");
                        Console.WriteLine("\nApakah ingin kembali ke awal menu voucher ? (y/n) ");
                        string menuInput = Console.ReadLine().ToLower();
                        if (menuInput == "y")
                        {
                            promoSopi();
                        }
                    }
                    break;
                case 2:
                    if (belanja >= 50000)
                    {
                        ongkirDiskon = 10000;
                        diskonBelanja = 10000;
                        ongkirDiskon = ongkir - ongkirDiskon;
                        belanjaDiskon = belanja - diskonBelanja;
                        diskonOngkir = ongkirDiskon >= 10000 ? ongkirDiskon : 0;
                        diskonBelanja = belanjaDiskon >= 50000 ? belanjaDiskon : 0;
                        totalBelanja = diskonBelanja + diskonOngkir;
                        Console.WriteLine($"Belanja : {belanja}");
                        Console.WriteLine($"Ongkos Kirim : {ongkir}");
                        Console.WriteLine($"Diskon Ongkir : 10000");
                        Console.WriteLine($"Diskon Belanja : 10000");
                        Console.WriteLine($"Total Belanja : {totalBelanja}");
                    }
                    else
                    {
                        Console.WriteLine("Minimum belanja Rp. 50.000");
                        Console.WriteLine("\nApakah ingin kembali ke awal menu voucher ? (y/n) ");
                        string menuInput = Console.ReadLine().ToLower();
                        if (menuInput == "y")
                        {
                            promoSopi();
                        }
                    }
                    break;
                case 3:
                    if (belanja >= 100000)
                    {
                        diskonOngkir = ongkir - 20000;
                        diskonBelanja = belanja - 20000;
                        totalBelanja = diskonBelanja + diskonOngkir;
                        Console.WriteLine($"Belanja : {belanja}");
                        Console.WriteLine($"Ongkos Kirim : {ongkir}");
                        Console.WriteLine($"Diskon Ongkir : 20000");
                        Console.WriteLine($"Diskon Belanja : 20000");
                        Console.WriteLine($"Total Belanja : {totalBelanja}");
                    }
                    else
                    {
                        Console.WriteLine("Minimum belanja Rp. 100.000");
                    }
                    break;
                default:
                    Console.WriteLine("Masukkan hanya angka!");
                    break;
            }
        }

        static void nilaiMahasiswa()
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
                Console.WriteLine($"Nilai {nilai} mendapatkan grade E");
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

        static void pulsa()
        {
            Console.WriteLine("\n--Membeli Pulsa--");
            Console.WriteLine("Keterangan : \nPulsa 10.000 mendapatkan poin 80 \nPulsa 20.000 mendapatkan poin 80");
            Console.WriteLine("Pulsa 25.000 mendapatkan poin 200 \nPulsa 50.000 mendapatkan poin 400 \nPulsa 100.000 mendapatkan poin 800");
            int pulsa, hasil;
            int poin = 0;
            Console.Write("Masukkan jumlah pulsa : ");
            pulsa = Convert.ToInt32(Console.ReadLine());
            int pembandingPulsa = pulsa >= 0 ? pulsa : 0;

            if (pulsa == 100000)
            {
                poin = 800;
            }
            else if (pulsa >= 50000 && pulsa < 100000)
            {
                poin = 400;
            }
            else if (pulsa >= 25000 && pulsa < 50000)
            {
                Console.WriteLine("Point : 200 ");
            }
            else if (pulsa >= 10000 && pulsa < 25000)
            {
                Console.WriteLine("Point : 80 ");
            }
            else
            {
                Console.WriteLine("Isi Pulsa Yang Benar!");
            }
                Console.WriteLine($"Pulsa Anda : {pembandingPulsa}");
                Console.WriteLine($"Anda mendapatkan {poin} point ");

            kembali();
        }

        static void grabFood()
        {
            Console.WriteLine("\n--GrabFood--");

            int jarak, belanja, diskon, total, ongkir;
            int diskonMax = 30000;
            Console.Write("Belanja : Rp.");
            belanja = int.Parse(Console.ReadLine());
            Console.Write("Jarak (km) : ");
            jarak = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Promo : ");
            string promo = Console.ReadLine().ToUpper();
            bool isPromo = promo == "JKTOVO";

            //total = belanja + diskon + ongkir ;
            ongkir = jarak * 1000;
            //int ongkirTambahan = (jarak - 5) * ongkir ;
            diskon = belanja * 40 / 100;

            if (jarak > 5 && isPromo)
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

        static void beratBadan()
        {
            Console.WriteLine("\n--Menghitung Berat Badan--");
            Console.Write("Masukkan berat badan (kg) : ");
            double berat = double.Parse(Console.ReadLine());
            Console.Write("Masukkan tinggi badan (cm) : ");
            double tinggi = double.Parse(Console.ReadLine());

            double tinggiM = tinggi / 100;

            double nilaiBMI = berat / (tinggiM * tinggiM);

            if (nilaiBMI >= 0 && nilaiBMI <= 18.5)
            {
                Console.WriteLine($"Nilai BMI anda adalah {nilaiBMI}");
                Console.WriteLine($"anda terlalu kurus, makan-makanan yang bergizi");
            }
            else if(nilaiBMI > 18.5 && nilaiBMI < 25)
            {
                Console.WriteLine($"Nilai BMI anda adalah {nilaiBMI}");
                Console.WriteLine($"Anda termasuk berbadan langsing");
            }else if(nilaiBMI > 25)
            {
                Console.WriteLine($"Nilai BMI anda adalah {nilaiBMI}");
                Console.WriteLine($"anda tergolong gemuk");
            }
            else
            {
                Console.WriteLine("Masukkan berat dan tinggi dengan benar!");
            }
            kembali();
        }

        static void nilaiRataRata()
        {
            Console.WriteLine("\n--Nilai Rata-Rata");
            Console.Write("Masukkan Nilai MTK : ");
            int mtk = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai Fisika : ");
            int fisika = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Nilai Kimia : ");
            int kimia = int.Parse(Console.ReadLine());

            int totalNilai;

            totalNilai = (mtk + fisika + kimia) / 3;

            if (totalNilai >= 50 && totalNilai <= 100)
            {
                Console.WriteLine($"Nilai Rata-Rata : {totalNilai}");
                Console.WriteLine("Selamat");
                Console.WriteLine("Kamu Berhasil");
                Console.WriteLine("Kamu Hebat");
            }
            else if(totalNilai >= 0 && totalNilai < 50)
            {
                Console.WriteLine($"Nilai Rata-Rata : {totalNilai}");
                Console.WriteLine("Maaf");
                Console.WriteLine("Kamu Gagal");
            }
            else
            {
                Console.WriteLine("Masukkan angka yang benar!");
            }

            kembali();
        }

        static void perhitunganGaji()
        {
            Console.WriteLine("\n--Perhitungan Gaji--");
            Console.WriteLine("Input : ");
            Console.Write("Nama : ");
            string nama = Console.ReadLine();
            Console.Write("Tunjangan : Rp.");
            int tunjangan = int.Parse(Console.ReadLine());
            Console.Write("Gapok : Rp.");
            int gapok = int.Parse(Console.ReadLine());
            Console.Write("Banyak bulan : ");
            int bulan = int.Parse(Console.ReadLine());

            int pajak, bpjs, gajiPerbulan, gatun;
            Int32 totalGaji;

            gatun = gapok + tunjangan;

            bpjs = (gapok + tunjangan) * 3 / 100;

            if (gatun > 10000000)
            {
                pajak = gatun * 15 / 100;
                gajiPerbulan = gatun - (pajak + bpjs);
                totalGaji = gajiPerbulan * bulan;
                Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut: ");
                Console.WriteLine($"Pajak : Rp. {pajak} ");
                Console.WriteLine($"BPJS : Rp. {bpjs} ");
                Console.WriteLine($"Gaji/bulan : Rp. {gajiPerbulan} ");
                Console.WriteLine($"Total gaji : Rp. {totalGaji} ");
            }
            else if (gatun > 5000000 && gatun <= 10000000)
            {
                pajak = gatun * 10 / 100;
                gajiPerbulan = gatun - (pajak + bpjs);
                totalGaji = gajiPerbulan * bulan;
                Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut: ");
                Console.WriteLine($"Pajak : Rp. {pajak} ");
                Console.WriteLine($"BPJS : Rp. {bpjs} ");
                Console.WriteLine($"Gaji/bulan : Rp. {gajiPerbulan} ");
                Console.WriteLine($"Total gaji : Rp. {totalGaji} ");
            }
            else if (gatun >= 0 && gatun <= 5000000)
            {
                pajak = gatun * 5 / 100;
                gajiPerbulan = gatun - (pajak + bpjs);
                totalGaji = gajiPerbulan * bulan;
                Console.WriteLine($"Karyawan atas nama {nama} slip gaji sebagai berikut: ");
                Console.WriteLine($"Pajak : Rp. {pajak} ");
                Console.WriteLine($"BPJS : Rp. {bpjs} ");
                Console.WriteLine($"Gaji/bulan : Rp. {gajiPerbulan} ");
                Console.WriteLine($"Total gaji : Rp. {totalGaji} ");
            }
            else
            {
                Console.WriteLine("Inputan yang Anda masukkan salah!");
            }
            kembali();
        }

        static void tugasGen()
        {
            Console.WriteLine("--Tugas Gen--");
            Console.Write("Masukkan nama : ");
            string nama = Console.ReadLine();
            Console.Write("Masukkan tahun kelahiran yyyy : ");
            int tahun = int.Parse(Console.ReadLine());

            if(tahun >= 1944 && tahun <= 1964 && tahun > 0)
            {
                Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tahun {tahun} tergolong Generasi Baby Boomer");
            }
            else if(tahun >= 1965 && tahun <= 1979)
            {
                Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tahun {tahun} tergolong Generasi X");

            }else if(tahun >= 1980 && tahun <= 1994)
            {
                Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tahun {tahun} tergolong Generasi Y (Millenials)");
            }else if(tahun >= 1995 && tahun <= 2015)
            {
                Console.WriteLine($"{nama}, berdasarkan tahun lahir anda tahun {tahun} tergolong Generasi Z");
            }
            else
            {
                Console.WriteLine("Harap masukkan inputan nama dan tahun dengan benar!");
            }

            kembali();
        }
    }
}
