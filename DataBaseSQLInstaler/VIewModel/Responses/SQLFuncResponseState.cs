using DomainInstaller.ResponseObserverInteface;
using СommonService;

namespace DataBaseSQLInstaller.VIewModel.Responses
{
    public class SQLFuncResponseState : ISQLFuncResponseState
    {
        private string funcName = "";
        private StateResponseCode responseCode;
        private string stringReposne = "";
        public StateResponseCode ResponseCode { get => responseCode; set { responseCode = value; } }
        public string StringReposne { get => stringReposne; set { stringReposne = value; } }
        public string FuncName { get => funcName; set { funcName = value; } }

        public string NameResponseProcess { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
