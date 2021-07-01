using System;

namespace exception_handling
{
  class Program
  {
    static void Main(string[] args)
    {
      // try // Hataya neden olabilecek kısım
      // {
      //   Console.WriteLine("Bir Sayı Giriniz: ");
      //   int sayi = Convert.ToInt32(Console.ReadLine());
      //   Console.WriteLine("Sayı: " + sayi);
      // }
      // catch (Exception ex)
      // {
      //   Console.WriteLine("Hata: " + ex.Message.ToString()); // Ex objesindeki hata mesajı
      // }
      // finally // Hata alsın almasın gösterilir.
      // {
      //   Console.WriteLine("İşlem tamamlandı!");
      // }

      try
      {
        // int a = int.Parse(null);
        // int a = int.Parse("test");
        int a = int.Parse("-22222222222");
      }
      catch (ArgumentNullException ex)
      {
        Console.WriteLine("Boş değer girdiniz.");
        Console.WriteLine(ex);
      }
      catch (FormatException ex)
      {
        Console.WriteLine("Veri Tipi Uygun Değil");
        Console.WriteLine(ex);
      }
      catch (OverflowException ex)
      {
        Console.WriteLine("Kapsam Dışı");
        Console.WriteLine(ex);
      }
      finally
      {
        Console.WriteLine("İşlem başarıyla tamamlandı!");
      }

    }
  }
}
