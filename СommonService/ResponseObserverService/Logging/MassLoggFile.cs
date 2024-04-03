using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.LoggingInterface;
using DomainInstaller.ResponseObserverInteface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СommonService.ResponseObserverService.Logging
{
    public class MassLoggFile : IMassLoggFile
    {
        private IMassResponseState massResponseState;
        private DateTime dateTime;
        private IResponseState responseState;
        public IMassResponseState MassResponseState { get => massResponseState; set { massResponseState = value; } }
        public DateTime DateTime { get => dateTime; set { dateTime = value; } }
        public IResponseState ResponseState { get => responseState; set { responseState = value; } }
    }
}
