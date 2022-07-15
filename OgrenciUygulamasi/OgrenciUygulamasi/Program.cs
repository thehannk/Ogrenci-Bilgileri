using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciUygulamasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool kontrol = true;
            Ogrenci ogrenci1 = new Ogrenci(1, "Hakan", "Ulusöver", 50, 40, 73, "Hacettepe");
            Console.WriteLine("Uygulamamıza Hoşgeldiniz...Yapmak istediğiniz işlemi seçiniz.");
            

            while (kontrol)
            {
                islemleriGoster();
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        ogrenci1.ogrenciBilgileriGoster();
                        break;
                    case "2":
                        double ogrenciOrtalama = ogrenci1.ogrenciNotuBul();
                        Console.WriteLine("Öğrencinin ortalaması :" + ogrenciOrtalama);
                        break;
                    case "3":
                        ogrenci1.okulGetir();
                        break;
                    case "4":
                        kontrol = false;
                        break;

                }
            }
        }

        static void islemleriGoster()
        {
            Console.WriteLine("1-Öğrenci Bilgileri Göster");
            Console.WriteLine("2-Öğrenci Ortalamasını Göster");
            Console.WriteLine("3-Öğrenci Okulunu Göster");
            Console.WriteLine("4-Çıkış Yap");
        }

    }
}