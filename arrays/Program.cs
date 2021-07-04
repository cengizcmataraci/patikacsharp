using System;

namespace arrays
{
  class Program
  {
    static void Main(string[] args)
    {
        // Dizi Tanımlama
        string[] renkler = new string[5];

        string[] hayvanlar = {"Kedi", "Köpek", "At", "Kuş", "İnek"};

        int[] dizi;
        dizi = new int[5];

        // Dizilere Değer Atama ve Erişim
        renkler[0] = "Mavi";
        dizi[3] = 10;

        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

        // Döngülerle dizi kullanımı
        // Klavyeden girilen n tane sayının ortalamasını alan program

        Console.WriteLine("Dizinin boyutunu giriniz: ");
        int diziUzunlugu = Convert.ToInt32(Console.ReadLine());
        int[] dizi1 = new int[diziUzunlugu];

        for (int i = 0; i < diziUzunlugu; i++)
        {
            Console.Write($"Lütfen {i+1}. sayıyı giriniz: ");
            dizi1[i] = int.Parse(Console.ReadLine());
        }

        int toplam = 0;
        foreach (var sayi in dizi1)
            toplam += sayi;

        Console.WriteLine("Ortalama: " + toplam/diziUzunlugu);

    }
  }
}
