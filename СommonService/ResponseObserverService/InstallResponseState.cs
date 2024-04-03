using DomainInstaller.ResponseObserverInteface;
using System.Diagnostics;
using СommonService;

namespace OtherSoftwareInstaller.SoftwareIstaller.LoggResponse
{
    public class InstallResponseState : IProcessResponseState
    {
        private string nameResponseProcess = "";
        public StateResponseCode ResponseCode { get; set; }
        public string StringReposne { get; set; } = "";
        public ProcessStartInfo ProcessStartInfo { get; set; } =  new ProcessStartInfo();
        public string NameResponseProcess { get => nameResponseProcess; set => nameResponseProcess = value; }
    }
}
