using System;

namespace arayuzler
{
  public class DatabaseLogger : ILogger
  {
    public void WriteLog()
    {
      // throw new NotImplementedException();
      Console.WriteLine("Database'e log yazar!");
    }
  }
}