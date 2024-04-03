using DataBaseSQLInstaller.Abstract;
using DomainInstaller.SQLinterface.DataInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSQLInstaller.VIewModel
{
    public class SQLRequester : AbstarctSQLRequester
    {
        public SQLRequester(ISQLUser user, string hostConnection, string portConnection) : base(user, hostConnection, portConnection)
        {
        }

    }
}
