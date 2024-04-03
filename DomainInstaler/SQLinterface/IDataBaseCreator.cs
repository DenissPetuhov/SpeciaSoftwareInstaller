using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using DomainInstaller.SQLinterface.DataInterface;

namespace DomainInstaller.SQLinterface
{
    public interface IDataBaseCreator
    {
        /// <summary>
        /// Опрашиватель.
        /// </summary>
        ISQLRequester Requester { get; set; }
        /// <summary>
        /// Создать базу данных 
        /// </summary>
        /// <param name="dataBase"></param>
        ISQLFuncResponseState DataBaseCreate(ISQLDataBase dataBase);
        /// <summary>
        /// Востановить Базу данных
        /// </summary>
        IProcessResponseState DataBaseRestore(ISQLDataBase dataBase);
        /// <summary>
        /// Удалить базу данных
        /// </summary>
        ISQLFuncResponseState DataBaseDelete(ISQLDataBase dataBase);

    }
}
