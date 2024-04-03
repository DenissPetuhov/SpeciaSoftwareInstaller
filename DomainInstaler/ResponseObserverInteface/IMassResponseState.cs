using DomainInstaller.ResponseObserverInteface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using СommonService;

namespace DomainInstaller.ResponseObserverInteface
{
    public interface IMassResponseState : IResponseState
    {
        List<IResponseState> ResponseStates { get; set; }
    
    }
}
