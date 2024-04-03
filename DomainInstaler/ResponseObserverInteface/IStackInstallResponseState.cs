using DomainInstaller.ResponseObserverInteface.Repository;
using System.Diagnostics;
using СommonService;

namespace DomainInstaller.ResponseObserverInteface
{
    public interface IStackInstallResponseState : IResponseState
    {
        List<IProcessResponseState> ResponseStates { get; set; }
        
    }
}
