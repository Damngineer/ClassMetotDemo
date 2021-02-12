using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void ekle(Musteri m1)
        {
            Console.WriteLine(m1.ad + m1.soyad + " kisisi eklendi");
        }

        public void sil(Musteri m1)
        {
            Console.WriteLine(m1.ad + m1.soyad + " kisisi silindi");
        }




    }
}
