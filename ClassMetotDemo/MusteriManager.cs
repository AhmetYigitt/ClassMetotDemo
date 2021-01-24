using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Eklendi");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " Silindi");

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad);
            Console.WriteLine(musteri.Soyad);
            Console.WriteLine(musteri.TcNo);
            Console.WriteLine(musteri.DogumTarihi);
        }
    }
}
