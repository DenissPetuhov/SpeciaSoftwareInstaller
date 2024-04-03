using DomainInstaller.BaseInterface.Repository;

namespace DomainInstaller.BaseInterface.IInsallersSettings
{
    /// <summary>
    /// Настройки Компонент инсталлера
    /// </summary>
    public interface IZipComponentInstallerSetting : IInstallerSetting
    {
        /// <summary>
        /// Путь к архиву сжатого компонента 
        /// </summary>
        public string PathToCompressionComponent { get; set; }


    }
}
