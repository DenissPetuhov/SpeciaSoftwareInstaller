using DataBaseSQLInstaller.VIewModel.Responses;
using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using DomainInstaller.SQLinterface;
using DomainInstaller.SQLinterface.DataInterface;
using System.Diagnostics;
using СommonService;
using СommonService.ProcessController;

namespace DataBaseSQLInstaller.Abstract
{
    internal abstract class AbstractDataBaseCreator : IDataBaseCreator
    {
        private ISQLRequester requester;
        public ISQLRequester Requester { get => requester; set { requester = value; } }
        public AbstractDataBaseCreator(ISQLRequester requester)
        {
            this.requester = requester;
        }
        public ISQLFuncResponseState DataBaseCreate(ISQLDataBase dataBase)
        {
            ISQLFuncResponseState Funcresponse = new SQLFuncResponseState() { FuncName = "CreateDateBase" };
            try
            {
                string comand = $"CREATE DATABASE \"{dataBase.DBName}\"";
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
        public ISQLFuncResponseState DataBaseDelete(ISQLDataBase dataBase)
        {
            ISQLFuncResponseState Funcresponse = new SQLFuncResponseState() { FuncName = "DeleteDateBase" };
            try
            {
                string comand = $"DROP DATABASE \"{dataBase.DBName}\"";
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
        public IProcessResponseState DataBaseRestore(ISQLDataBase dataBase)
        {
            IProcessResponseState reposnse;
            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.FileName = "cmd";
                processStartInfo.Arguments 
                    = $"/c set PGPASSWORD={requester.User.Password}&& " +
                    $"\"C:\\Program Files (x86)\\PostgreSQL\\8.4\\bin\\pg_restore.exe\" " +
                    $"--host {requester.HostConnection} " +
                    $"--port {requester.PortConnection} " +
                    $"--username {requester.User.UserName} " +
                    $"--dbname \"{dataBase.DBName}\"" +
                    $" --verbose \"{dataBase.BackupPath}\"";
                reposnse = ProcessStarter.StartSingleProcess(processStartInfo);
                return reposnse;
            }
            catch (Exception ex)
            {
                reposnse = new ProcessResponseState();
                reposnse.StringReposne = ex.Message;
                reposnse.ResponseCode = StateResponseCode.ERROR;
                return reposnse;

            }
        }
    }
}
