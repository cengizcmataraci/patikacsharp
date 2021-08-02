using System;

namespace arayuzler
{
  class Program
  {
    static void Main(string[] args)
    {
      FileLogger fileLooger = new FileLogger();
      fileLooger.WriteLog();

      DatabaseLogger databaseLogger = new DatabaseLogger();
      databaseLogger.WriteLog();

      SmsLogger smsLogger = new();
      smsLogger.WriteLog();

      LogManager logManager = new LogManager(new FileLogger());logManager.WriteLog();
    }
  }
}
