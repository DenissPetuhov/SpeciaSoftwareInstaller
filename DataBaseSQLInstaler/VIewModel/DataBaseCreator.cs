using DataBaseSQLInstaller.Abstract;
using DomainInstaller.SQLinterface;

namespace DataBaseSQLInstaller.VIewModel
{
    internal class DataBaseCreator : AbstractDataBaseCreator
    {
        public DataBaseCreator(ISQLRequester requester) : base(requester)
        {
        }
    }
}
