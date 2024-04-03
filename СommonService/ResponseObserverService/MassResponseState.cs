using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СommonService.ResponseObserverService
{
    internal class MassResponseState : IMassResponseState
    {
        private List<IResponseState> responseStates = new List<IResponseState>();
        private StateResponseCode responseCode;
        private string stringReposne = "";
        private string nameResponseProcess = "";
        public List<IResponseState> ResponseStates { get => responseStates; set { responseStates = value; } }
        public StateResponseCode ResponseCode { get => responseCode; set { responseCode = value; } }
        public string StringReposne { get => stringReposne; set { stringReposne = value; } }
        public string NameResponseProcess { get => nameResponseProcess; set { nameResponseProcess = value; } }
    }
}
