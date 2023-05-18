using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace consolehesapM
{
    class islemler
    {
        public int toplama( List<int>  sayilar)
        {
            int toplam = 0;
            foreach(int sayi in sayilar )
            {
                toplam += sayi;
            }
            return toplam;
        }
        public int cıkarma(List<int> sayilar)
        {
            int kalan = (sayilar[0])*2;
            foreach(int sayi in sayilar)
            {
                kalan-=sayi;
            }
            return kalan;
        }
        public int carpma(List<int> sayilar)
        {
            int carpım = 1;
            foreach(int sayi in sayilar)
            {
                carpım *= sayi;
            }
            return carpım;
        }
        public int bolme(List<int> sayilar )
        {
            int max = sayilar[0];
            int s = 0;
            foreach(int sayi1 in sayilar)
            {
                if (max < sayi1) { max = sayi1; }
            }
            foreach(int sayi2 in sayilar)
            {
                if (max == sayi2 && s == 0) { s++; }
                else { max /= sayi2; }
            }
            return max;
            /*if(x>y) { return x/y; }
            else {  return y/x; }*/
        }
        public int UsAlma(int x,int y)
        {
            //int s = 1;
            //for (int i = 0; i < y; i++) { s = s * x; }
            //return x;
            int sonuc = x;
            int s = 0;
            while (s < y-1)
            {
                sonuc = sonuc * x;
                s++;
            }
            return sonuc;
        }
        public void carpanAyirma(int x)
        {
            for (int i = 1; i < x; i++)
            {
                if(x%i == 0) { Console.Write(" * " + i + " * "); }
            }
        }
        public int faktoriyel(int x)
        {
            int sonuc = 1;
            for (int i = x; i > 0; i--) { sonuc *= i; }
            return sonuc;
        }
        public int MutlakD(int x)
        {
            int y = x *(-2);
            if (x < 0) { return x + (y); }
            else { return x; }            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            islemler islemler = new islemler();
            Console.WriteLine("-+ HANGİ İŞLEMİ YAPMAK İSTERSİNİZ +-");
            Console.WriteLine(" Toplama = toplama " +
                "\n Cıkarma = cıkarma" +
                "\n Çarpma = carpma" +
                "\n Bölme = bolme" +
                "\n Üs alma = üsalma" +
                "\n Çarpanlarına ayırmak = carpanayirma" +
                "\n Faktoriyelini almak = faktoriyel" +
                "\n Mutlak değerini almak = mutlakdeger");
            string secilenİ=Console.ReadLine();
            if (secilenİ == "toplama")
            {
                List<int> toplam = new List<int>{};
                Console.WriteLine(" Toplamak istediğiniz sayıları giriniz (girdiğiniz sayılar bittiğinde '//' girişini yapınız)");
                while (true)
                {
                    string x = Console.ReadLine();                
                    if(x == "//")
                        break;
                    else
                    {
                        int y = Convert.ToInt32(x);
                        toplam.Add(y);
                    }
                }
                Console.WriteLine(" sonuç : "+islemler.toplama(toplam));
            } 
            if (secilenİ == "cıkarma")
            {
                List<int> cıkarma = new List<int>();
                Console.WriteLine(" Eksilen sayıyı giriniz");
                cıkarma.Add(Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine(" Cıkan sayıları giriniz (girdiğiniz sayılar bittiğinde '//' girişini yapınız)");
                while (true)
                {
                    string x = Console.ReadLine();
                    if (x == "//")
                        break;
                    else
                    {
                        int y = Convert.ToInt32(x);
                        cıkarma.Add(y);
                    }
                }
                Console.WriteLine(" sonuç : " + islemler.cıkarma(cıkarma));
            }
            if (secilenİ == "carpma")
            {
                List<int> carpım =new List<int>();
                Console.WriteLine(" Çarpmak istediğiniz sayıları giriniz (girdiğiniz sayılar bittiğinde '//' girişini yapınız)");
                while (true)
                {
                    string x=Console.ReadLine();
                    if ( x == "//")
                        break;
                    else
                    {
                        int y=Convert.ToInt32(x);
                        carpım.Add(y);
                    }
                }
                Console.WriteLine(" sonuç : " + islemler.carpma(carpım));
            }
            if (secilenİ == "bolme")
            {
                List<int> bolum =new List<int>();
                Console.WriteLine(" Bölmek istediğiniz sayıları giriniz (girdiğiniz sayılar bittiğinde '//' girişini yapınız)");
                while (true)
                {
                    string x = Console.ReadLine();
                    if (x == "//")
                        break;
                    else
                    {
                        int y = Convert.ToInt32(x);
                        bolum.Add(y);
                    }
                }
                Console.WriteLine(" sonuç : "+islemler.bolme(bolum));
            }
            if (secilenİ== "üsalma")
            {
                Console.WriteLine(" Tabanı giriniz ");
                string taban = Console.ReadLine();
                Console.WriteLine(" Üssünü giriniz");
                string us = Console.ReadLine();
                int Taban =Convert.ToInt32(taban);
                int Us =Convert.ToInt32(us);
                Console.WriteLine(" sonuç : "+islemler.UsAlma(Taban, Us));
            }
            if (secilenİ== "carpanayirma")
            {
                Console.WriteLine(" Çarpanlarını almak istediğiniz sayıyı girin ");
                string sayi = Console.ReadLine();
                int Sayi =Convert.ToInt32(sayi);
                islemler.carpanAyirma(Sayi);
            }
            if (secilenİ == "faktoriyel")
            {
                Console.WriteLine("Faktoriyelini almak istediğiniz sayıyı giriniz");
                string sayi = Console.ReadLine();
                int Sayi=Convert.ToInt32(sayi);
                Console.WriteLine(" sonuç : " + islemler.faktoriyel(Sayi));
            }
            if (secilenİ == "mutlakdeger")
            {
                Console.WriteLine("Mutlak değerini almak istediğiniz sayıyı giriniz");
                string sayi = Console.ReadLine();
                int Sayi = Convert.ToInt32(sayi);
                Console.WriteLine(" sonuç : " + islemler.MutlakD(Sayi));

            }
            /*
            Console.WriteLine(islemler.bolme(10, 2));
            Console.WriteLine(islemler.carpma(1, 2, 3, 4));
            Console.WriteLine(islemler.toplama(1, 2, 3,4));
            Console.WriteLine(islemler.cıkarma(10,5,-10));
            Console.WriteLine(islemler.UsAlma(2,2));
            Console.WriteLine(islemler.faktoriyel(5));
            Console.WriteLine(islemler.MutlakD(islemler.faktoriyel(-5)));
            islemler.carpanAyirma(100);*/
            Console.ReadLine();
        }
    }
}
