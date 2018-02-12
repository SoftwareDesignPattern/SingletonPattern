using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class WriteApplicationLogs
    {
        private static StreamWriter _StreamWriter;
        private static readonly WriteApplicationLogs instance = new WriteApplicationLogs();
        public WriteApplicationLogs()
        {
            _StreamWriter = new StreamWriter(GlobalVariables.strFilesLocsWithFilesName, true);
        }


        public static WriteApplicationLogs GetInstance()
        {
            return instance;
        }

        public void Write(string str)
        {
            _StreamWriter.WriteLine(str);
            _StreamWriter.Flush();           
        }


        public void WriteClose()
        {
            _StreamWriter.Close();
        }
    }
}
