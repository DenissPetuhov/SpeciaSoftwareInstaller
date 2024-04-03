using DomainInstaller.BaseInterface.IInsallersSettings;
using DomainInstaller.BaseInterface.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtherSoftwareInstaller.SoftwareIstallers
{
    internal class SoftwareInstallerSetting : ISoftwareInstallerSetting
    {
        private string pathToInstaller ;
        private string pathToUnInstaller ;
        private string attributeInsteller ;
        private string installationPath ;
        private string installName ;
        private string discription ;
        public string PathToInstaller { get => pathToInstaller; set => pathToInstaller = value; }
        public string PathToUnInstaller { get => pathToUnInstaller; set => pathToUnInstaller = value; }
        public string AttributeInsteller { get => attributeInsteller; set => attributeInsteller = value; }
        public string InstallationPath { get => installationPath; set => installationPath= value; }
        public string InstallName { get => installName; set => installName= value; }
        public string Discription { get => discription; set => discription = value; }
        /// <summary>
        /// Установщик Специального ПО
        /// </summary>
        /// <param name="pathToInstaller">Путь к установщику</param>
        /// <param name="pathToUnInstaller">Путь к деинсталятору</param>
        /// <param name="attributeInsteller">Атрибуты установщика</param>
        /// <param name="installationPath">Путь установки</param>
        /// <param name="installName">Название установщика</param>
        /// <param name="discription">Описание установщика</param>
        public SoftwareInstallerSetting(string pathToInstaller, string pathToUnInstaller, string attributeInsteller, string installationPath, string installName, string discription)
        {
            this.pathToInstaller = pathToInstaller;
            this.pathToUnInstaller = pathToUnInstaller;
            this.attributeInsteller = attributeInsteller;
            this.installationPath = installationPath;
            this.installName = installName;
            this.discription = discription;

        }
    }
}
