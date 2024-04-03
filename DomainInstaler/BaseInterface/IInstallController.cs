using DomainInstaller.BaseInterface.IInsallersSettings;
using DomainInstaller.BaseInterface.Repository;
using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;

namespace DomainInstaller.BaseInterface
{
    /// <summary>
    /// Базовый Интерфейс поведения котроллера
    /// </summary>
    public interface IInstallController<T> 
    {
        private IInstaller<T> Installer { get { return Installer; } set { Installer = value; } }
        /// <summary>
        /// Принимает подходящие настройки, и запускает инсталяцию.
        /// </summary>
        /// <param name="installSetting">Соответствующие инталлятору настройки.</param>
        public IResponseState StartInstall(T installSetting);
        /// <summary>
        /// Последовательно запускает список процессов.
        /// </summary>
        /// <param name="IsntallersStack">Список соответсвующих интсалатору настроек</param>
        /// <returns></returns>
        public IStackInstallResponseState StartStackInstall(List<T> IsntallersStack);
        
    }
}
