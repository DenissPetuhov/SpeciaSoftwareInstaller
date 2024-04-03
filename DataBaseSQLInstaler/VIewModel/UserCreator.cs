using DataBaseSQLInstaller.Abstract;
using DomainInstaller.SQLinterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseSQLInstaller.VIewModel
{
    internal class UserCreator : AbstractUserCreator
    {
        public UserCreator(ISQLRequester requester) : base(requester)
        {
        }
    }
}
