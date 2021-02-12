using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Musteri musteri1 = new Musteri();

            musteri1.tc = 5;
            musteri1.ad = "berk";
            musteri1.soyad = "saglicak";

            MusteriManager mm = new MusteriManager();

            mm.ekle(musteri1);
            mm.sil(musteri1);
        }
    }
}
