using System;

namespace homework_1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("*** 1 ***");
      Console.WriteLine("Lütfen pozitif bir sayı giriniz: ");
      int sayi = int.Parse(Console.ReadLine());
      if (sayi > 0)
      {
        int[] sayiDizisi = new int[sayi];
        Console.WriteLine($"Lütfen {sayi} tane sayı giriniz: ");
        for (int i = 0; i < sayiDizisi.Length; i++)
        {
          Console.Write($"{i + 1}. sayı: ");
          sayiDizisi[i] = int.Parse(Console.ReadLine());
        }
        foreach (var sayi1 in sayiDizisi)
        {
          if (sayi1 % 2 == 0)
          {
            Console.WriteLine(sayi1);
          }
        }
      }
      else
      {
        Console.WriteLine("İstenilen şekilde sayı girmediniz!");
      }
    }
  }
}
