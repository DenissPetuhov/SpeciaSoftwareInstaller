using DomainInstaller.BaseInterface.IInsallersSettings;
using DomainInstaller.BaseInterface.Repository;
using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using OtherSoftwareInstaller.SoftwareIstaller.LoggResponse;
using СommonService;

namespace SpecialComponentInstaller.ComponentInstaller.Abstract
{
    internal abstract class AbstractZipComponentInstaller : IInstaller<IZipComponentInstallerSetting>
    {
        IProcessResponseState? responseState;
        /// <summary>
        /// Настройки компонент инсталлера
        /// </summary>
        public IZipComponentInstallerSetting InstallerSetting { get; set; }
        public AbstractZipComponentInstaller(IZipComponentInstallerSetting InstallerSetting)
        {
            this.InstallerSetting = InstallerSetting;
        }
        /// <summary>
        /// Проверяет путь установки, если такой путь уже существует возвращает True, если нет False </summary>
        /// <returns></returns>
        public bool CheckInstallation()
        {
            try
            {
                return Directory.Exists(InstallerSetting.InstallationPath);
            }
            catch (Exception)
            {
                return false;

            }
        }
        /// <summary>
        /// Устанавливает настроки компонент инсталлера.
        /// </summary>
        /// <param name="setting"> Подходящие настроки компонент инсталлера</param>
        public void SetInstallerSetting(IZipComponentInstallerSetting setting)
        {
            InstallerSetting.InstallationPath = setting.InstallationPath;
            InstallerSetting.PathToCompressionComponent = setting.PathToCompressionComponent;
            InstallerSetting.InstallName = setting.InstallName;
            InstallerSetting.Discription = setting.Discription;
            
        }
        /// <summary>
        /// Запускает разархивацию компонента в путь заданный в настройках
        /// </summary>
        public IResponseState StartInstall()
        {
            try
            {
                responseState = new InstallResponseState();
                ZipCompressor.DecompressAsync(InstallerSetting.PathToCompressionComponent, InstallerSetting.InstallationPath);
                responseState.ResponseCode = StateResponseCode.SUCCESS;
                responseState.StringReposne = "Компонент успешно установлен";
                responseState.NameResponseProcess = InstallerSetting.InstallName;
                return responseState;
            }
            catch (Exception ex)
            {
                return new InstallResponseState() { StringReposne = ex.Message };
            }
        }
        /// <summary>
        /// Удаляет путь созданный разархивацией, заданной в настройках, перед этим проверяя его существование
        /// </summary>
        public IResponseState StartUnInstall()
        {
            try
            {
                responseState = new InstallResponseState();
                if (CheckInstallation())
                {
                    DirectoryInfo directory = new DirectoryInfo(InstallerSetting.InstallationPath);
                    directory.Delete(true);
                    responseState.ResponseCode = StateResponseCode.SUCCESS;
                    responseState.StringReposne = "Компонент успешно удален";
                    responseState.NameResponseProcess = InstallerSetting.InstallName;
                    return responseState;
                }
                else
                {
                    responseState.ResponseCode = StateResponseCode.ERROR;
                    responseState.StringReposne = "Компонент не был удален, так как не был найден";
                    return responseState;
                }

            }
            catch (Exception ex)
            {
                return new InstallResponseState() { StringReposne = ex.Message };
              
            }
        }

    }
}
