using System;
using System.Collections.Generic;

namespace collections
{
  class Program
  {
    static void Main(string[] args)
    {
      //List<T> class
      //System.Collections.Generic
      // T -> Object türündedir, nesne alabilir. Hangi tipteki nesne ekleyeceğiz bunu belirtir.

      List<int> sayiListesi = new List<int>();
      sayiListesi.Add(23);
      sayiListesi.Add(10);
      sayiListesi.Add(4);
      sayiListesi.Add(5);
      sayiListesi.Add(92);
      sayiListesi.Add(34);

      List<string> renkListesi = new List<string>();
      renkListesi.Add("Mavi");
      renkListesi.Add("Kırmızı");
      renkListesi.Add("Yeşil");
      renkListesi.Add("Sarı");
      renkListesi.Add("Turuncu");

      //Count
      Console.WriteLine(renkListesi.Count);
      Console.WriteLine(sayiListesi.Count);

      //foreach ve List.ForEach ile elemanlara erişim
      foreach (var renk in renkListesi)
        Console.WriteLine(renk);
      foreach (var sayi in sayiListesi)
        Console.WriteLine(sayi);

      sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
      renkListesi.ForEach(renk => Console.WriteLine(renk));

      //Listeden eleman çıkarma
      sayiListesi.Remove(4);
      renkListesi.Remove("Turuncu");
      sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
      renkListesi.ForEach(renk => Console.WriteLine(renk));

      sayiListesi.RemoveAt(0);
      renkListesi.RemoveAt(1);
      sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
      renkListesi.ForEach(renk => Console.WriteLine(renk));

      //Liste içerisinde arama
      if (sayiListesi.Contains(10))
        Console.WriteLine("10 liste içerisinde bulundu!");

      //Eleman ile indexe erişme
      Console.WriteLine(renkListesi.BinarySearch("Mavi"));

      //Diziyi listeye çevirme
      string[] hayvanlar = { "At", "Kedi", "Köpek", "İnek" };
      List<string> hayvanListesi = new List<string>(hayvanlar);

      //Listeyi temizleme
      hayvanListesi.Clear();

      //Liste içerisinde nesne tutma
      List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

      Kullanıcılar kullanici1 = new Kullanıcılar();
      kullanici1.Isim = "Cengiz C.";
      kullanici1.Soyisim = "Mataracı";
      kullanici1.Yas = 25;

      Kullanıcılar kullanici2 = new Kullanıcılar();
      kullanici2.Isim = "Elif Mine";
      kullanici2.Soyisim = "Kılıçaslan";
      kullanici2.Yas = 24;

      kullanıcıListesi.Add(kullanici1);
      kullanıcıListesi.Add(kullanici2);

      kullanıcıListesi.ForEach(kullanici => Console.WriteLine(kullanici.Isim));

      List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
      yeniListe.Add(new Kullanıcılar()
      {
        Isim = "Firdevs Nur",
        Soyisim = "Mataracı",
        Yas = 18
      });

      foreach (var kullanıcı in kullanıcıListesi)
      {
        Console.WriteLine("Kullanıcı adı: " + kullanıcı.Isim);
        Console.WriteLine("Kullanıcı soyadı: " + kullanıcı.Soyisim);
        Console.WriteLine("Kullanıcı yaşı: " + kullanıcı.Yas);
      }

      yeniListe.Clear();

    }
  }
  public class Kullanıcılar
  {
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
  }
}
