using System;

namespace operators
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("*** Atama ve İşlemli Atama Operatörleri ***");
      // Atama ve İşlemli Atama
      int x = 5;
      int y = 3;
      y = y + 2;
      Console.WriteLine(y);
      y += 2; // İşlemli atama
      Console.WriteLine(y);
      y /= 1;
      Console.WriteLine(y);
      x *= 2;
      Console.WriteLine(x);

      Console.WriteLine("*** Mantıksal Operatörler ***");
      // Mantıksal Operatörler
      // ||, &&, !
      bool isSuccess = true;
      bool isCompleted = false;

      if (isSuccess && isCompleted)
        Console.WriteLine("Perfect!");

      if (isSuccess || isCompleted)
        Console.WriteLine("Great!");

      if (isSuccess && !isCompleted)
        Console.WriteLine("Fine!");

      Console.WriteLine("*** İlişkisel Operatörler ***");
      // İlişkisel Operatörler
      // <, >, <=, >=, ==, !=

      int a = 3;
      int b = 4;
      bool sonuc = a < b;
      Console.WriteLine(sonuc);
      sonuc = a > b;
      Console.WriteLine(sonuc);
      sonuc = a == b;
      Console.WriteLine(sonuc);
      sonuc = a <= b;
      Console.WriteLine(sonuc);
      sonuc = a >= b;
      Console.WriteLine(sonuc);
      sonuc = a != b;
      Console.WriteLine(sonuc);

      Console.WriteLine("*** Aritmetik Operatörler ***");
      // Aritmetik Operatörler
      // /, *, +, -, %

      int sayi1 = 10;
      int sayi2 = 5;
      int sonuc1 = sayi1 / sayi2;
      Console.WriteLine(sonuc1);
      sonuc1 = sayi1 * sayi2;
      Console.WriteLine(sonuc1);
      sonuc1 = sayi1 + sayi2;
      sonuc1 = sayi1++; // Buradan sonra sayi1 bir artıyor.
      Console.WriteLine(sonuc1);
      sonuc1 = sayi1 - sayi2;
      Console.WriteLine(sonuc1);
      sonuc1 = sayi1 % sayi2;
      Console.WriteLine(sonuc1);
    }
  }
}
