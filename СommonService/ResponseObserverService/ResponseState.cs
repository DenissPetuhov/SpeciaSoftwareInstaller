using DomainInstaller.ResponseObserverInteface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СommonService.ResponseObserverService
{
    internal class ResponseState : IResponseState
    {
        private string nameResponseProcess = "";
        private StateResponseCode responseCode;
        private string stringReposne = "";
        public StateResponseCode ResponseCode { get => responseCode; set { responseCode = value; } }
        public string StringReposne { get => stringReposne; set { stringReposne = value; } }
        public string NameResponseProcess { get => nameResponseProcess; set => nameResponseProcess = value; }
    }
}
