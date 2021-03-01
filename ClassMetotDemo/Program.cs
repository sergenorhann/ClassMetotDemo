using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriManager musteriManager = new MusteriManager();

            Musteri musteri1 = new Musteri();

            musteri1.Id = 0;
            musteri1.TcNo = 12345678901;
            musteri1.Adi = "ali";
            musteri1.Soyadi = "yılmaz";
            musteri1.Il = "Adana";
            musteriManager.MusteriEkle(musteri1);

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1;
            musteri2.TcNo = 1234567892;
            musteri2.Adi = "veli";
            musteri2.Soyadi = "yılmaz";
            musteri2.Il = "Mersin";
            musteriManager.MusteriEkle(musteri2);

            musteriManager.MusteriListele(musteri1,musteri2);

            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
        }
    }
}
