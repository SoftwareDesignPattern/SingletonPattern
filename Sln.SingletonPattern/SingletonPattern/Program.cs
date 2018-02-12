using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteApplicationLogs logInstance01 = WriteApplicationLogs.GetInstance();
            WriteApplicationLogs logInstance02 = WriteApplicationLogs.GetInstance();
            WriteApplicationLogs logInstance03 = WriteApplicationLogs.GetInstance();


            logInstance01.Write("A critical error written at " + DateTime.Now.ToString());
            logInstance02.Write("A critical error written at " + DateTime.Now.ToString());
            logInstance03.Write("A critical error written at " + DateTime.Now.ToString());


            logInstance03.WriteClose();
        }
    }
}
