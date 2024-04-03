using DataBaseSQLInstaller.VIewModel;
using DataBaseSQLInstaller.VIewModel.Responses;
using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.SQLinterface;
using DomainInstaller.SQLinterface.DataInterface;
using СommonService;

namespace DataBaseSQLInstaller
{
    public class DataBaseSQLController
    {
        private ISQLRequester requester;
        private DataBaseCreator dataBaseCreator;
        private UserCreator userCreator;
        public DataBaseSQLController(ISQLRequester sqlrequester)
        {
            requester = sqlrequester;
            userCreator = new UserCreator(requester);
            dataBaseCreator = new DataBaseCreator(requester);
        }
        public ISQLFuncResponseState CreateDataBase(ISQLDataBase dataBase)
        {
            ISQLFuncResponseState responseState = new SQLFuncResponseState() { FuncName = $"Создние базы данных-{dataBase}" };
            try
            {
                responseState = dataBaseCreator.DataBaseCreate(dataBase);
                //механизм записи лога
                return responseState;
            }
            catch (Exception ex)
            {
                responseState.ResponseCode = StateResponseCode.ERROR;
                responseState.StringReposne = ex.Message;
                return responseState;
            }
        }
        public ISQLFuncResponseState DeleteDataBase(ISQLDataBase dataBase)
        {
            ISQLFuncResponseState responseState = new SQLFuncResponseState() { FuncName = $"Удаление базы данных-{dataBase}" };
            try
            {
                responseState = dataBaseCreator.DataBaseDelete(dataBase);
                //механизм записи лога
                return responseState;
            }
            catch (Exception ex)
            {
                responseState.ResponseCode = StateResponseCode.ERROR;
                responseState.StringReposne = ex.Message;
                return responseState;
            }
        }
        public ISQLFuncResponseState CreateUser(ISQLUser user, bool superUser)
        {
            ISQLFuncResponseState responseState = new SQLFuncResponseState() { FuncName = $"Создание пользователя User-{user}" };
            try
            {
                responseState = userCreator.CreateUser(user, superUser);
                //механизм записи лога
                return responseState;
            }
            catch (Exception ex)
            {
                responseState.ResponseCode = StateResponseCode.ERROR;
                responseState.StringReposne = ex.Message;
                return responseState;
            }
        }
        public ISQLFuncResponseState DeleteUser(ISQLUser user)
        {
            ISQLFuncResponseState responseState = new SQLFuncResponseState() { FuncName = $"Удаление пользователя User-{user}" };
            try
            {
                responseState = userCreator.DeleteUser(user);
                //механизм записи лога
                return responseState;
            }
            catch (Exception ex)
            {
                responseState.ResponseCode = StateResponseCode.ERROR;
                responseState.StringReposne = ex.Message;
                return responseState;
            }
        }
        public IProcessResponseState RestoreDataBase(ISQLDataBase dataBase)
        {
            IProcessResponseState responseState = new ProcessResponseState();
            try
            {
                responseState = dataBaseCreator.DataBaseRestore(dataBase);
                //механизм записи лога
                return responseState;
            }
            catch (Exception ex)
            {
                responseState.ResponseCode = StateResponseCode.ERROR;
                responseState.StringReposne = ex.Message;
                return responseState;
            }
        }
       
    }
}
