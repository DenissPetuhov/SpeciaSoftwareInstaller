using DomainInstaller.ResponseObserverInteface.Repository;
using DomainInstaller.SQLinterface.DataInterface;

namespace DomainInstaller.SQLinterface
{
    public interface ISQLRequester
    {
        ISQLUser User { get; set; }
        /// <summary>
        /// Адрес подключения.
        /// </summary>
        string HostConnection { get; set; }
        /// <summary>
        /// Порт подключения.
        /// </summary>
        string PortConnection { get; set; }
        /// <summary>
        /// Выполнить команду.
        /// </summary>
        /// <param name="command">Команда(SQL Запрос)</param>
        /// <param name="User">Пользователь подключения</param>
        /// <returns></returns>
        IResponseState StartRequest(string command);

    }
}
