using System;

namespace while_loop
{
  class Program
  {
    static void Main(string[] args)
    {
        // While
        // 1'den başlayarak girilen sayıya kadar ortalama hesaplamak
        Console.WriteLine("Sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine());
        int sayac = 1;
        int toplam = 0;
        while (sayac <= sayi)
        {
            toplam += sayac;
            sayac++;
        }
        Console.WriteLine(toplam / sayi);

        // a'dan z'ye kadar tüm harfleri yazdır
        char character = 'a';
        while (character <= 'z')
        {
            Console.WriteLine(character);
            character++;
        }

        // Foreach
        string[] arabalar = {"Clio", "Hyundai", "Ferrari", "Mustang", "BMW"};

        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
  }
}
