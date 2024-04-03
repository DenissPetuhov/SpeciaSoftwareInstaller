using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainInstaller.SQLinterface.DataInterface
{
    public interface ISQLDataBase
    {
        string DBName { get; set; }
        string BackupPath { get; set; }
    }
}
