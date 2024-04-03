using DomainInstaller.BaseInterface.IInsallersSettings;
using DomainInstaller.BaseInterface.Repository;
using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using OtherSoftwareInstaller.SoftwareIstaller.LoggResponse;
using OtherSoftwareInstaller.SoftwareIstallers;
using System.Diagnostics;
using СommonService;
using СommonService.ProcessController;

namespace OtherSoftwareInstaler.ComponetnIstlaers.Abstract
{
    internal abstract class AbstractSoftwareInstaller : IInstaller<ISoftwareInstallerSetting>
    {
        private ProcessStartInfo? processInfo;

        /// <summary>
        /// Натройки установщика.
        /// </summary>
        public ISoftwareInstallerSetting InstallerSetting { get; set; }
        /// <summary>
        /// Проверка на установку.Не доделан
        /// </summary>
        /// <returns>Возвращает True, если провека прошла успешно, False, если обнаруженны проблемы.</returns>
        public bool CheckInstallation()
        {
            throw new NotImplementedException();
        }
        public AbstractSoftwareInstaller(ISoftwareInstallerSetting installerSetting)
        {
            this.InstallerSetting = installerSetting;
        }
        /// <summary>
        /// Разом устанавлевает все параметры установщика.
        /// </summary>
        /// <param name="setting">Принимает любой класс реализующий интерфейс настроек.</param>
        public void SetInstallerSetting(ISoftwareInstallerSetting setting)
        {
            InstallerSetting = setting;
        }
        /// <summary>
        /// Запускает установку, стороннего ПО.
        /// </summary>
         public IResponseState StartInstall()
        {
            processInfo = new ProcessStartInfo(InstallerSetting.PathToInstaller, InstallerSetting.AttributeInsteller);
            try
            {
                var processResponse = ProcessStarter.StartSingleProcess(processInfo);
                processResponse.ResponseCode = StateResponseCode.SUCCESS;
                processResponse.StringReposne = "Установка завершенна.";
                return processResponse;
            }
            catch (Exception ex)
            {
                return new InstallResponseState()
                {
                    ProcessStartInfo = processInfo,
                    ResponseCode = StateResponseCode.ERROR,
                    StringReposne = ex.Message
                };
            };
        }
        /// <summary>
        /// Запускает удаление стороннего ПО.
        /// </summary>
        new public IResponseState StartUnInstall()
        {
            processInfo = new ProcessStartInfo(InstallerSetting.PathToUnInstaller);
            try
            {
                var processResponse = ProcessStarter.StartSingleProcess(processInfo);
                processResponse.ResponseCode = StateResponseCode.SUCCESS;
                processResponse.StringReposne = "Удаление завершенно.";
                return processResponse;
            }
            catch (Exception ex)
            {
                return new InstallResponseState()
                {
                    ProcessStartInfo = processInfo,
                    ResponseCode = StateResponseCode.ERROR,
                    StringReposne = ex.Message
                };
            }

        }
    }
}
