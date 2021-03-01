using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        int MusteriSayisi = 0;
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi.ToUpper() + " " + musteri.Soyadi.ToUpper() + " Başarıyla eklendi.\n");

        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Id.ToString() + " Id Numaralı " + musteri.Adi.ToUpper() +" "+ musteri.Soyadi.ToUpper() + " başarıyla silindi.\n");
        }

        public void MusteriListele(params Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.TcNo);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Il);
                Console.Write("\n");
                MusteriSayisi++;
            }
            Console.WriteLine("Güncel Müşteri Sayısı : " + MusteriSayisi.ToString()+"\n");
        }

    }
}
