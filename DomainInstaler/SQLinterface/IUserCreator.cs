using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.SQLinterface.DataInterface;

namespace DomainInstaller.SQLinterface
{
    public interface IUserCreator
    {
        ISQLRequester Requester { get; set; }
        /// <summary>
        /// Создать пользователя.
        /// </summary>
        /// <param name="sqluser"></param>
        ISQLFuncResponseState CreateUser(ISQLUser sqluser, bool superUser);
        /// <summary>
        /// Удилить пользователя.
        /// </summary>
        /// <param name="sqluser"></param>
        ISQLFuncResponseState DeleteUser(ISQLUser sqluser);
    }
}
