using System;

namespace Logic01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Logic 01");
            Console.WriteLine("Convert string\n");
            int umur = 23;
            string strUmur = umur.ToString();
            Console.WriteLine("Umur : " + strUmur);

            //Konversi();

            //Jika ingin membuat method non static harus tambahkan seperti dibawah ini 
            Program program = new Program();
            //program.operatorAritmatika();
            //program.modulus();

            //operatorPenugasan();

            //operatorPerbandingan();

            //operatorLogika();

            penjumlahan();

            Console.ReadLine();
        }

        static void penjumlahan()
        {
            int mangga, apel;
            Console.WriteLine("\n--Method Return Type--");
            Console.Write("Jumlah mangga = ");
            mangga = Convert.ToInt32(Console.ReadLine());
            Console.Write("Jumlah apel = ");
            apel = Convert.ToInt32(Console.ReadLine());

            int hasil = HitungJumlah(mangga, apel);

            Console.WriteLine($"Hasil mangga + apel = {hasil}");
        }

        static int HitungJumlah(int mangga, int apel)
        {
            int hasil=0;
            hasil = mangga + apel;
            return hasil;
        }

        static void operatorLogika()
        {
            Console.WriteLine("Operator Logika \n");
            Console.Write("Enter your age : ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter your Password : ");
            string password = Console.ReadLine();

            bool isAdult = age > 18;
            bool isPasswordValid = password == "admin";

            if (isAdult && isPasswordValid)
            {
                Console.WriteLine("Welcome To the Club");
            }
            else if (isPasswordValid == false || !isPasswordValid)
            {
                Console.WriteLine("Sorry, wrong password try again!");
            }
            else
            {
                Console.WriteLine("Sorry, try again!");
            }
        }

        void modulus()
        {
            Console.WriteLine("\nPenjumlahan Modulus \n");
            Console.Write("Masukkan Angka Pertama : ");
            int Angka1 = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Angka Kedua : ");
            int Angka2 = Convert.ToInt32(Console.ReadLine());

            int hasil = Angka1 % Angka2;

            Console.WriteLine("Hasil Angka1 % Angka2 = " + hasil);

        }

        static void operatorPenugasan()
        {
            int angka1, angka2, hasil = 5, hasilmin = 5, hasilpembagian = 5, hasilkali = 5, hasilmod = 15;
            Console.Write("\nAngka 1 += ");
            angka1 = Convert.ToInt32(Console.ReadLine());
            hasil += angka1;
            hasilmin -= angka1;
            hasilpembagian /= angka1;
            hasilkali *= angka1;
            hasilmod %= angka1;
            Console.WriteLine("\nHasil = 5, angka = {0}, hasil dari hasil += angka : {1}", angka1, hasil);
            Console.WriteLine("\nHasil = 5, angka = {0}, hasil dari hasil -= angka : {1}", angka1, hasilmin);
            Console.WriteLine("\nHasil = 5, angka = {0}, hasil dari hasil /= angka : {1}", angka1, hasilpembagian);
            Console.WriteLine("\nHasil = 5, angka = {0}, hasil dari hasil *= angka : {1}", angka1, hasilkali);
            Console.WriteLine("\nHasil = 5, angka = {0}, hasil dari hasil %= angka : {1}", angka1, hasilmod);
        }

        static void operatorPerbandingan()
        {
            int mangga, apel = 0;
            Console.WriteLine("Opertaor Perbandingan\n");
            Console.Write("Jumlah mangga : ");
            mangga = int.Parse(Console.ReadLine());

            Console.Write("Jumlah apel : ");
            apel = int.Parse(Console.ReadLine());

            Console.WriteLine("Hasil perbandingan : ");
            Console.WriteLine($"mangga > apel {mangga > apel}");
            Console.WriteLine($"mangga < apel {mangga < apel}");
            Console.WriteLine("Mangga >= apel " + (mangga >= apel));
            Console.WriteLine($"mangga <= apel {mangga <= apel}");
            Console.WriteLine("mangga tidak sama dengan apel " + (mangga != apel));
            Console.WriteLine("Jumlah Mangga sama dengan Apel" + (mangga == apel));
            //if (mangga >= apel)
            //{
            //    Console.WriteLine("Mangga >= apel " + (mangga >= apel));
            //    Console.WriteLine($"mangga <= apel {mangga <= apel}");
            //}
            //if (mangga != apel)
            //{
            //    Console.WriteLine("mangga tidak sama dengan apel " + (mangga != apel));
            //}

            //if(mangga == apel)
            //{
            //    Console.WriteLine("Jumlah Mangga sama dengan Apel" + (mangga == apel));
            //}

        }
        static void Konversi()
        {
            
            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;

            string myString = Convert.ToString(myInt);
            double myConvDouble = Convert.ToDouble(myInt);
            int myConvInt = Convert.ToInt32(myDouble);
            string myConvstring = Convert.ToString(myBool);

            Console.WriteLine("Convert int to string : " + myString);
            Console.WriteLine("Convert int to double : " + myConvDouble);
            Console.WriteLine("Convert double to int : " + myConvInt);
            Console.WriteLine("Convert boolean to string : " + myConvstring);

        }

        void operatorAritmatika()
        {
            Console.WriteLine("\nOperator Penjumlahan");
            int mangga, apel, hasil = 0;
            Console.Write("Jumlah Mangga : ");
            //inputan ada dua : 1. Convert.ToInt();, 2. int.Parse(Console.ReadLine);
            mangga = int.Parse(Console.ReadLine());

            Console.Write("Jumlah apel : ");
            apel = Convert.ToInt32(Console.ReadLine());

            hasil = mangga + apel;
            int hasilMod = mangga % apel;

            Console.WriteLine($"Hasil mangga + apel = {hasil}");
            Console.WriteLine($"Hasil mangga % apel = {hasilMod}");

        }
    }
}
