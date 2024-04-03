using DomainInstaller.BaseInterface;
using DomainInstaller.BaseInterface.IInsallersSettings;
using DomainInstaller.BaseInterface.Repository;
using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using OtherSoftwareInstaller.SoftwareIstaller.LoggResponse;
using SpecialComponentInstaller.ComponentInstaller;
using СommonService;
using СommonService.ResponseObserverService;

namespace SpecialComponentInstaller
{
    /// <summary>
    /// Публичный контроллер для управления компонент инсталлером. 
    /// </summary>
    public class ComponentInstallController : IInstallController<IZipComponentInstallerSetting>
    {
        private IInstaller<IZipComponentInstallerSetting>? Installer { get; set; }
        public IResponseState StartInstall(IZipComponentInstallerSetting installSetting)
        {
            IProcessResponseState response = new InstallResponseState();
            try
            {
                Installer = new ZipComponentInstaller(installSetting);
                response = (IProcessResponseState)Installer.StartInstall();
                response.ResponseCode = StateResponseCode.SUCCESS;
                return response;
            }
            catch (Exception ex)
            {
                response.ResponseCode = StateResponseCode.ERROR;
                response.StringReposne = ex.Message;
                return response;
            }

        }
        public IStackInstallResponseState StartStackInstall(List<IZipComponentInstallerSetting> IsntallersStack)
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
                foreach (IZipComponentInstallerSetting setting in IsntallersStack)
                {
                    Installer = new ZipComponentInstaller(setting);
                    IProcessResponseState installResponseState = (IProcessResponseState)Installer.StartInstall();
                    response.ResponseStates.Add( installResponseState);
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
    }
}

