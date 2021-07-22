using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
  class Program
  {
    static void Main(string[] args)
    {
      //System.Collections namespace

      ArrayList liste = new ArrayList();
      // liste.Add("Ayşe");
      // liste.Add(2);
      // liste.Add(true);
      // liste.Add('A');

      //İçerisindeki verilere erişme
      // Console.WriteLine(liste[1]);
      // foreach (var list in liste)
      //   Console.WriteLine(list);

      //AddRange
      Console.WriteLine("*** AddRange ***");
      // string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
      List<int> sayilar = new List<int>() { 2, 3, 5, 6, 7, 1 };
      // liste.AddRange(renkler);
      liste.AddRange(sayilar);

      foreach (var newlist in liste)
        Console.WriteLine(newlist);

      //Sort
      Console.WriteLine("*** Sort ***");
      liste.Sort();
      foreach (var newlist in liste)
        Console.WriteLine(newlist);

      //BinarySearch
      Console.WriteLine("*** BinarySearch ***");
      Console.WriteLine(liste.BinarySearch(6));

      //Reverse
      Console.WriteLine("*** Reverse ***");
      liste.Reverse();
      foreach (var item in liste)
        Console.WriteLine(item);

      //Clear
      Console.WriteLine("*** Clear ***");
      liste.Clear();

      foreach (var item in liste)
        Console.WriteLine(item);
    }
  }
}
