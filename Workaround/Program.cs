using Business.Concrete;
using Emtities.Concrete;
using System;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args) 
        {
            Vatandas vatandas1 = new Vatandas();
            SelamVer("Melike");
            int sonuc = Topla(3,6);

            //Diziler / Arrays
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";
            for(int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir"};
            string[] sehirler2 = new[] {"Bursa" , "Antalya" , "Diyarbakır"};

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";

            Console.WriteLine(sehirler2[0]);

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdenity = 123;


            Person person2 = new Person();
            person2.FirstName = "Murat";

            Person person3 = new Person();
            person3 = null;
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            sayi1 = 30;
            //sayi2 = 10 olur

            foreach(string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

            List<string> yeniSehirler1 = new List<string>{"Ankara" , "İstanbul" , "İzmir"};
            yeniSehirler1.Add("İzmir");

            foreach(var sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            //Yabancı uyruklu vatandaşlar için (verilmeyecek)
            PttManager pttManager2 = new PttManager(new ForeignerManager());
            pttManager.GiveMask(person2);

            //Null bir değer gönderiyorum.
            PttManager pttManager3 = new PttManager(new PersonManager());
            pttManager.GiveMask(person3);


            Console.ReadLine();
        }

        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1 = 10 , int sayi2 = 5)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Sonuç = " + sonuc);
            return sonuc;
        }

        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Melike";
            string soyad = "Cotak";
            int dogumYili = 2003;
            long tcno = 12345678910;

            Console.WriteLine(mesaj);
            Console.WriteLine(mesaj);

        }

    }

    public class Vatandas
    {
        public string Ad { get; set; }

        public string Soyad {  get; set; }

        public int DogumYili { get; set;}
        
        public long TcNo { get; set; }
    }
}