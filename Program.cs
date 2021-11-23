using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collection.Generic
            //T -> object türündendir.

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            System.Console.WriteLine(sayiListesi.Count);
            System.Console.WriteLine(renkListesi.Count);

            //Foreach ve List.Foreach ile elemanlara erişim
            foreach (var sayi in sayiListesi )
                System.Console.WriteLine(sayi);            
            foreach (var renk in renkListesi )
                System.Console.WriteLine(renk);

            sayiListesi.ForEach(sayi=> System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>System.Console.WriteLine(renk));

            //Listeden eleman çıkarma
            sayiListesi.Remove(4); //direkt eleman olarak silme
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0); //Indexten silme
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=> System.Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>System.Console.WriteLine(renk));

            //Liste içerisinde arama

            if(sayiListesi.Contains(10))
                System.Console.WriteLine("10 Liste içerisinde bulundu!");

            //Eleman ile indexe erişme
            System.Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi listeye çevirme
            string[] hayvanlar = {"Kedi", "Köpek", "Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?
            hayvanListesi.Clear();

            //List içerisinde nesne tutmak

            List<Kullanicilar> kullanicilarListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayşe";
            kullanici1.SoyIsim = "Yılmaz";
            kullanici1.Yas = 26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Özcan";
            kullanici2.SoyIsim = "Çalışkan";
            kullanici2.Yas = 27;

            kullanicilarListesi.Add(kullanici1);
            kullanicilarListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){
                Isim = "Deniz",
                SoyIsim = "Arda",
                Yas = 24
            });

            foreach (var kullanici in kullanicilarListesi)
            {
                System.Console.WriteLine("Kullanıcı adı: " + kullanici.Isim);
                System.Console.WriteLine("Kullanıcı soyadı: " + kullanici.SoyIsim);
                System.Console.WriteLine("Kullanıcı yaşı: " + kullanici.Yas);
            }

            yeniListe.Clear();
            
        }

    }

    public class Kullanicilar{
        string isim;
        string soyIsim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
