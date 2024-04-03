using DataBaseSQLInstaller.VIewModel.Responses;
using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using DomainInstaller.SQLinterface;
using DomainInstaller.SQLinterface.DataInterface;
using СommonService;

namespace DataBaseSQLInstaller.Abstract
{
    internal class AbstractUserCreator : IUserCreator
    {
        private ISQLRequester requester;
        public ISQLRequester Requester { get => requester; set { requester = value; } }
        public AbstractUserCreator(ISQLRequester requester)
        {
            this.requester= requester;

        }
        public ISQLFuncResponseState CreateUser(ISQLUser sqluser, bool superUser)
        {
            ISQLFuncResponseState Funcresponse = new SQLFuncResponseState() { FuncName = "CreateUserRole" };
            try
            {
                string comand = $"CREATE ROLE \"{sqluser.UserName}\" LOGIN\r\n PASSWORD '{sqluser.Password}';";
                if (superUser) comand = $"CREATE ROLE \"{sqluser.UserName}\" LOGIN\r\n PASSWORD '{sqluser.Password}'\r\n SUPERUSER INHERIT CREATEDB CREATEROLE;";
                IResponseState commandresponse = requester.StartRequest(comand);
                Funcresponse.ResponseCode = commandresponse.ResponseCode;
                Funcresponse.StringReposne = commandresponse.StringReposne;
                return Funcresponse;
            }
            catch (Exception ex)
            {
                Funcresponse.StringReposne = ex.Message;
                Funcresponse.ResponseCode = StateResponseCode.ERROR;
                return Funcresponse;

            }
        }
        public ISQLFuncResponseState DeleteUser(ISQLUser sqluser)
        {
            ISQLFuncResponseState Funcresponse = new SQLFuncResponseState() { FuncName = "DeleteUserRole" };
            try
            {
                string comand = $"DROP ROLE \"{sqluser.UserName}\";";
                IResponseState commandresponse = requester.StartRequest(comand);
                Funcresponse.ResponseCode = commandresponse.ResponseCode;
                Funcresponse.StringReposne = commandresponse.StringReposne;
                return Funcresponse;
            }
            catch (Exception ex)
            {
                Funcresponse.StringReposne = ex.Message;
                Funcresponse.ResponseCode = StateResponseCode.ERROR;
                return Funcresponse;

            }
        }
    }
}
