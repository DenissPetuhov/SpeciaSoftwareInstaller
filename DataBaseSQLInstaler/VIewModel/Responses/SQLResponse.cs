using DomainInstaller.ResponseObserverInteface.Repository;
using СommonService;

namespace DataBaseSQLInstaller.VIewModel.Responses
{
    internal class SQLResponse : IResponseState
    {
        private string nameResponseProcess = "";
        private StateResponseCode responseCode;
        private string stringReposne = "";
        public StateResponseCode ResponseCode { get => responseCode; set { responseCode = value; } }
        public string StringReposne { get => stringReposne; set { stringReposne = value; } }

        public string NameResponseProcess { get => nameResponseProcess; set => nameResponseProcess = value; }
    }
}
