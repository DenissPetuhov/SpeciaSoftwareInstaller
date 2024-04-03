using DomainInstaller.ResponseObserverInteface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainInstaller.ResponseObserverInteface.LoggingInterface
{
    public interface ILoggFile
    {
        /// <summary>
        /// Дата создания лог-файла
        /// </summary>
        DateTime DateTime { get; set; } 
        /// <summary>
        /// Инофрмация состояния процесса 
        /// </summary>
        IResponseState ResponseState { get; set; }
        
    }
}
