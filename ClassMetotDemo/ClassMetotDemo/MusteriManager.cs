using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void Add(Musteri musteri )
        {
            Console.WriteLine(musteri.MusteriAd + " "+ "Kişisi Sisteme Eklenmiştir");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAd + " " + "Kişisi Sistemden Silinmiştir");

        }

        public void Update(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriTcNo + " "+ "Tc No Güncellenmiştir");
        }
    }
}
