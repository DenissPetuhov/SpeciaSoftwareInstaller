using DomainInstaller.BaseInterface.IInsallersSettings;

namespace SpecialComponentInstaller.ComponentInstaller
{
    internal class ZipComponentInstallerSetting : IZipComponentInstallerSetting
    {
        private string pathToCompressionComponent;
        private string installationPath;
        private string installName;
        private string discription;
        public string PathToCompressionComponent { get => pathToCompressionComponent; set => pathToCompressionComponent = value; }
        public string InstallationPath { get => installationPath; set => installationPath = value; }
        public string InstallName { get => installName; set => installName = value; }
        public string Discription { get => discription; set => discription = value; }
        public ZipComponentInstallerSetting(string pathToCompressionComponent, string installationPath, string installName, string discription)
        {
            this.pathToCompressionComponent = pathToCompressionComponent;
            this.installationPath = installationPath;
            this.installName = installName;
            this.discription = discription;

        }
    }
}
