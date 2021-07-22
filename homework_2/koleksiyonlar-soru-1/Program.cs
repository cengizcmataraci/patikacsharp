using System;
using System.Collections;

namespace koleksiyonlar_soru_1
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayList prime = new ArrayList();
      ArrayList notPrime = new ArrayList();

      Console.WriteLine("Lütfen 20 adet sayı giriniz: ");
      for (int i = 1; i < 21; i++)
      {
        int sayi = int.Parse(Console.ReadLine());
        if (sayi > 0)
        {
          if (IsPrime(sayi))
          {
            prime.Add(sayi);
          }
          else
          {
            notPrime.Add(sayi);
          }
        }
        else
        {
          Console.WriteLine("İstenilen şekilde giriş yapmadınız!");
          break;
        }
      }

      prime.Sort();
      notPrime.Sort();

      Console.WriteLine("Asal sayılar:");
      foreach (var item in prime)
        Console.WriteLine(item);

      Console.WriteLine("Asal olmayan sayılar:");
      foreach (var item in notPrime)
        Console.WriteLine(item);

      Console.WriteLine("Asal sayı adeti: " + prime.Count);
      Console.WriteLine("Asal olmayan sayı adeti: " + notPrime.Count);

      int primeSum = 0, notPrimeSum = 0;
      double primeAverage = 0, notPrimeAverage = 0;
      
      foreach (var item in prime)
      {
        primeSum = primeSum + (int)item;
        primeAverage = primeSum / prime.Count;
      }
      foreach (var item in notPrime)
      {
        notPrimeSum = notPrimeSum + (int)item;
        notPrimeAverage = notPrimeSum / prime.Count;
      }

      Console.WriteLine("Asal sayıların ortalaması: " + primeAverage);
      Console.WriteLine("Asal olmayan sayıların ortalaması: " + notPrimeAverage);
    }
    static bool IsPrime(int sayi)
    {
      for (int i = 2; i <= sayi / 2; i++)
        if (sayi % i == 0)
          return false;

      return true;
    }
  }
}
