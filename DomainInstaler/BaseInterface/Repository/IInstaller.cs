using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainInstaller.BaseInterface.Repository
{

    /// <summary>
    /// Базовый интерфейс установщика
    /// </summary>
    /// <typeparam name="T">Параметр отвечающий за тип установщика </typeparam>
    public interface IInstaller<IInstallerSetting>
    {
        IInstallerSetting InstallerSetting { get; set; }
        /// <summary>
        /// Запускает установку. Для запуска установки определите путь к файлу установщика свойством - PathToInstaller
        /// </summary>
        IResponseState StartInstall();
        /// <summary>
        /// Запускает Удалене. Для запуска удаления поределите путь к деинсталятора свойством - PathToUnInstaller
        /// </summary>
        IResponseState StartUnInstall();
        /// <summary>
        /// Проверяет установку. 
        /// </summary>
        /// <returns></returns>
        bool CheckInstallation();
        /// <summary>
        /// Устанвливает настройки инсталятора из объекта реализующего интерфейс настроек инсталлера
        /// </summary>
        /// <param name="setting"></param>
        void SetInstallerSetting(IInstallerSetting setting);

    }
}
