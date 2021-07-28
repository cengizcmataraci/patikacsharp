using System;

namespace inheritance
{
  public class Bitkiler : Canlılar
  {
    protected void Fotosentez()
    {
      Console.WriteLine("Bitkiler fotosentez yaparlar!");
    }
  }

  public class TohumluBitkiler : Bitkiler
  {
    public TohumluBitkiler()
    {
      base.Fotosentez();
      base.Beslenme();
      base.Boşaltım();
      base.Solunum();
    }
    public void TohumlaCogalma()
    {
      Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
    }
  }

  public class TohumsuzBitkiler : Bitkiler
  {
    public TohumsuzBitkiler()
    {
      base.Fotosentez();
      base.Beslenme();
      base.Boşaltım();
      base.Solunum();
    }
    public void SporlaCogalma()
    {
      Console.WriteLine("Tohumsuz bitkiler sporla çoğalır.");
    }
  }
}