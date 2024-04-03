using DomainInstaller.ResponseObserverInteface;
using System.Diagnostics;
using СommonService;

namespace DataBaseSQLInstaller.VIewModel.Responses
{
    public class ProcessResponseState : IProcessResponseState
    {
        private StateResponseCode responseCode;
        private string stringReposne = "";
        private ProcessStartInfo processStartInfo = new ProcessStartInfo();
        public StateResponseCode ResponseCode { get => responseCode; set { responseCode = value; } }
        public string StringReposne { get => stringReposne; set { stringReposne = value; } }
        public ProcessStartInfo ProcessStartInfo { get => processStartInfo; set { processStartInfo = value; } }

        public string NameResponseProcess { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
