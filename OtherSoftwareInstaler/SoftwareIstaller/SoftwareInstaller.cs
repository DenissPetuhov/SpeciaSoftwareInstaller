using DomainInstaller.BaseInterface.IInsallersSettings;
using OtherSoftwareInstaler.ComponetnIstlaers.Abstract;

namespace OtherSoftwareInstaller.SoftwareIstallers
{
    internal class SoftwareInstaller : AbstractSoftwareInstaller
    {
        public SoftwareInstaller(ISoftwareInstallerSetting installerSetting) : base(installerSetting) { }

    }
}
