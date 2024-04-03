using DomainInstaller.ResponseObserverInteface.Repository;
using System.Diagnostics;

namespace DomainInstaller.ResponseObserverInteface
{
    public interface IProcessResponseState : IResponseState
    {
        /// <summary>
        /// Информация о процессе
        /// </summary>
        ProcessStartInfo ProcessStartInfo { get; set; }

    }
}
