using System;

namespace koleksiyonlar_soru_2
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] numberList = new int[20];
      Console.WriteLine("Lütfen 20 sayı giriniz: ");

      for (int i = 0; i < 20; i++)
      {
        Console.Write($"{i + 1}. sayı: ");
        numberList[i] = int.Parse(Console.ReadLine());
      }

      Array.Sort(numberList);

      int averageMin = (numberList[0] + numberList[1] + numberList[2]) / 3;
      int averageMax = (numberList[17] + numberList[18] + numberList[19]) / 3;
      int averageSum = averageMax + averageMin;

      Console.WriteLine("En küçük üç sayının ortalaması: " + averageMin);
      Console.WriteLine("En büyük üç sayının ortalaması: " + averageMax);
      Console.WriteLine("Ortalamalar toplamı: " + averageSum);
    }
  }
}
