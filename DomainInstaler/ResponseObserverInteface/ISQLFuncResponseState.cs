using DomainInstaller.ResponseObserverInteface.Repository;

namespace DomainInstaller.ResponseObserverInteface
{
    public interface ISQLFuncResponseState :IResponseState
    {
        string FuncName { get; set; }
    }
}
