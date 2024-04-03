using DomainInstaller.BaseInterface.IInsallersSettings;
using DomainInstaller.BaseInterface.Repository;

namespace DomainInstaller.BaseInterface
{
    public interface IStackInstallers
    {
        List<ISoftwareInstallerSetting> SoftwareInstallersList { get; set; }
        List<IZipComponentInstallerSetting> ZipComponentInstallerList { get; set; }
        List<IShortCutSetting> ShortCutSettings { get; set; }

        
    }
}
