using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteApplicationLogs logInstance01 = WriteApplicationLogs.GetInstance();
            WriteApplicationLogs logInstance02 = WriteApplicationLogs.GetInstance();
            WriteApplicationLogs logInstance03 = WriteApplicationLogs.GetInstance();


            logInstance01.WriteInFile("A critical error written at " + DateTime.Now.ToString());
            logInstance02.WriteInFile("A critical error written at " + DateTime.Now.ToString());
            logInstance03.WriteInFile("A critical error written at " + DateTime.Now.ToString());


            logInstance03.WriteInFileClose();
        }
    }
}
