using System.IO;

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

        public void WriteInFile(string str)
        {
            _StreamWriter.WriteLine(str);
            _StreamWriter.Flush();           
        }


        public void WriteInFileClose()
        {
            _StreamWriter.Close();
        }
    }
}
