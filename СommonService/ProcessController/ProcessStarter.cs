using DomainInstaller.ResponseObserverInteface;
using OtherSoftwareInstaller.SoftwareIstaller.LoggResponse;
using System.Diagnostics;

namespace СommonService.ProcessController
{
    public class ProcessStarter
    {
        /// <summary>
        /// Запускает процесс.
        /// </summary>
        /// <param name="processInfo">Параметры запускаемого процесса</param>
        /// <returns></returns>
        public static IProcessResponseState StartSingleProcess(ProcessStartInfo processInfo)
        {
            var response = new InstallResponseState();
            Process process = new Process();
            process.StartInfo = processInfo;
            process.Start();
            process.WaitForExit();
            response.ProcessStartInfo = processInfo;
            return response;
        }


    }
}
