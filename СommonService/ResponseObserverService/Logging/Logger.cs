using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;

namespace СommonService.ResponseObserverService.Logging
{
    public static class Logger
    {
        /// <summary>
        /// Создает файл лога, сохроняет и вывожит в консоль информцию по процессу 
        /// </summary>
        /// <param name="responseState"></param>
        public static void Log(IResponseState responseState)
        {
            LoggFile loggFile = new LoggFile();
            loggFile.ResponseState = responseState;
            loggFile.DateTime = DateTime.Now;
            SaveLog(loggFile);
            ViewLog(loggFile);

        }
        public static void Log(IMassResponseState responseStatets)
        {

        }
        private static void SaveLog(LoggFile loggFile)
        {
            //Создать сохранение логга
        }
        private static void ViewLog(LoggFile loggFile)
        {
            Console.WriteLine(loggFile.ResponseState.NameResponseProcess + " " + loggFile.DateTime);
            Console.WriteLine(loggFile.ResponseState.ResponseCode);
            Console.WriteLine(loggFile.ResponseState.StringReposne);
        }

    }
}
