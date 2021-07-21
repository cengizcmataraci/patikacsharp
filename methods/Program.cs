using System;

namespace methods
{
  class Program
  {
    static void Main(string[] args)
    {
      //erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
      //{
      //komutlar;
      //return;
      //}

      int a = 2;
      int b = 3;

      Console.WriteLine(Topla(a, b));

      int sonuc = Topla(a, b);

      Metotlar ornek = new Metotlar();
      ornek.EkranaYazdir(Convert.ToString(sonuc));
      Console.WriteLine("*************");

      int sonuc2 = ornek.ArttirVeTopla(ref a, ref b);
      ornek.EkranaYazdir(Convert.ToString(sonuc2));
      ornek.EkranaYazdir(Convert.ToString(a+b));
    }

    static int Topla(int deger1, int deger2)
    {
      return (deger1 + deger2);
    }
  }

  class Metotlar
  {
    public void EkranaYazdir(string veri)
    {
      Console.WriteLine(veri);
    }

    public int ArttirVeTopla(ref int deger1, ref int deger2)
    //bellekteki karşılıkları veriliyor, işaret ediliyor. kopyalar üzerinde çalışmak yerine orijinal değişkeneler üzerinde değişiklik yapılıyor.
    {
      deger1 += 1;
      deger2 += 1;
      return deger1 + deger2;
    }
  }
}
