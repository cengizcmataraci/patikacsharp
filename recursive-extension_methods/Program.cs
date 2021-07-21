using System;

namespace recursive_extension_methods
{
  class Program
  {
    static void Main(string[] args)
    {
      //Rekürsif - Öz yinelemeli
      //3^4

      int result = 1;
      for (int i = 1; i < 5; i++)
        result *= 3;
      Console.WriteLine(result);

      Islemler islem = new Islemler();
      Console.WriteLine(islem.Expo(3, 4));

      //Extension Metotlar
      string ifade = "Cengiz C. Mataracı";
      bool sonuc = ifade.CheckSpaces();
      Console.WriteLine(sonuc);

      if (sonuc)
        Console.WriteLine(ifade.RemoveWhitespaces());

      Console.WriteLine(ifade.MakeUppercase());
      Console.WriteLine(ifade.MakeLowercase());

      int[] dizi = { 9, 3, 6, 2, 1, 5, 0, 5 };
      dizi.SortArray();
      dizi.EkranaYazdir();

      int sayi = 5;
      Console.WriteLine(sayi.IsEvenNumber());

      Console.WriteLine(ifade.GetFirstCharacter());
    }
  }
  public class Islemler
  {
    public int Expo(int sayi, int us)
    {
      if (us < 2)
        return sayi;
      return Expo(sayi, us - 1) * sayi;
    }
    //Expo(3,4)
    //Expo(3,3) * 3;
    //Expo(3,2) * 3 * 3;
    //Expo(3,1) * 3 * 3 * 3;
    //3 * 3 * 3 * 3 = 3^4;
  }

  public static class Extension
  { //static olmalı
    public static bool CheckSpaces(this string param)
    {
      return param.Contains(" ");
    }
    public static string RemoveWhitespaces(this string param)
    {
      string[] dizi = param.Split();
      return string.Join("", dizi);
    }
    public static string MakeUppercase(this string param)
    {
      return param.ToUpper();
    }
    public static string MakeLowercase(this string param)
    {
      return param.ToLower();
    }

    public static int[] SortArray(this int[] param)
    {
      Array.Sort(param);
      return param;
    }
    public static void EkranaYazdir(this int[] param)
    {
      foreach (int item in param)
      {
        Console.WriteLine(item);
      }
    }
    public static bool IsEvenNumber(this int param)
    {
      return param % 2 == 0;
    }
    public static string GetFirstCharacter(this string param)
    {
      return param.Substring(0, 1);
    }
  }
}
