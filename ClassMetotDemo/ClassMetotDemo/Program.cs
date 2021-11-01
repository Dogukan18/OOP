using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri { MusteriAd = "Dogukan", MusteriId = 1, MusteriTcNo =64556002089};
            Musteri musteri2 = new Musteri {MusteriAd="Veli",MusteriId=2,MusteriTcNo=56441522389};


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.Add(musteri1);
            musteriManager.Update(musteri1);
            
        }
    }
}
