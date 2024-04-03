using DomainInstaller.BaseInterface;
using DomainInstaller.BaseInterface.IInsallersSettings;
using DomainInstaller.BaseInterface.Repository;
using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using OtherSoftwareInstaller.SoftwareIstaller.LoggResponse;
using OtherSoftwareInstaller.SoftwareIstallers;
using СommonService;
using СommonService.ResponseObserverService;

namespace OtherSoftwareInstaller
{
    /// <summary>
    /// Публичный контролер для управления софт инсталлером
    /// </summary>
    public class SoftwareInstallController : IInstallController<ISoftwareInstallerSetting>
    {

        private IInstaller<ISoftwareInstallerSetting>? Installer { get; set; }
        public IProcessResponseState StartInstall(ISoftwareInstallerSetting installSetting)
        {
            IProcessResponseState response = new InstallResponseState();
            try
            {
                Installer = new SoftwareInstaller(installSetting);

                response =  (IProcessResponseState)Installer.StartInstall();
                response.ResponseCode = StateResponseCode.SUCCESS;
                // Добавить механизм записи лога
                return response;
            }
            catch (Exception ex)
            {
                response.ResponseCode = StateResponseCode.ERROR;
                response.StringReposne = ex.Message;
                return response;
            }
        }
        public IStackInstallResponseState StartStackInstall(List<ISoftwareInstallerSetting> IsntallersStack)
        {
            IStackInstallResponseState response = new StackInstallResponseState();
            response.ResponseCode = StateResponseCode.SUCCESS;
            response.StringReposne = "Установка прошла успешно.";
            try
            {
                if (IsntallersStack.Count < 1)
                {
                    response.StringReposne = "В стеке не был найден ни один набор настрек";
                    response.ResponseCode = StateResponseCode.NotFoundProcess;
                    return response;
                }

                foreach (ISoftwareInstallerSetting setting in IsntallersStack)
                {
                    Installer = new SoftwareInstaller(setting);
                    IProcessResponseState installResponseState = (IProcessResponseState)Installer.StartInstall();
                    response.ResponseStates.Add(installResponseState);
                    if (installResponseState.ResponseCode == StateResponseCode.ERROR)
                    {
                        response.ResponseCode = StateResponseCode.ERROR;
                        response.StringReposne = "Найденны ошибки, смотри подробный лог.";
                    }
                }
                return response;
            }
            catch (Exception ex)
            {
                response.StringReposne = ex.Message;
                response.ResponseCode = StateResponseCode.ERROR;
            }
            return response;
        }

        IResponseState IInstallController<ISoftwareInstallerSetting>.StartInstall(ISoftwareInstallerSetting installSetting)
        {
            throw new NotImplementedException();
        }
    }
}
