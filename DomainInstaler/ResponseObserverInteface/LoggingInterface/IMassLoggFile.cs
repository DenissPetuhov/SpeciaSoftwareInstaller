using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainInstaller.ResponseObserverInteface.LoggingInterface
{
    public interface IMassLoggFile : ILoggFile
    {
        /// <summary>
        /// Подробный список логов
        /// </summary>
        IMassResponseState MassResponseState { get; set; }
    }
}
