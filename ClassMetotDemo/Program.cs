using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri {Id=1,Ad="Yiğit",Soyad="Arıtürk",TcNo="1477852693256",DogumTarihi="21.06.1999" };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("1-Ekle");
            Console.WriteLine( "2-Sil");
            Console.WriteLine("3Listele");

            int x = int.Parse(Console.ReadLine());



            switch (x)
            {
                case 1:

                    musteriManager.Ekle(musteri1);
                    break;
                case 2:
                    musteriManager.Sil(musteri1);
                    break;
                case 3:
                    musteriManager.Listele(musteri1);
                    break;
                default:
                    Console.WriteLine("hatalı seçim");
                    break;
            }
        }
    }
}
