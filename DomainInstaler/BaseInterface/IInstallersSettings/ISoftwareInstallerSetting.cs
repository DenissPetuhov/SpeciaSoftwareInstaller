using DomainInstaller.BaseInterface.Repository;

namespace DomainInstaller.BaseInterface.IInsallersSettings
{
    /// <summary>
    /// Настройки Софт Инсталлера
    /// </summary>
    public interface ISoftwareInstallerSetting : IInstallerSetting
    {
        /// <summary>
        /// Путь к установщику
        /// </summary>
        string PathToInstaller { get; set; }
        /// <summary>
        /// Путь к деинсталятору
        /// </summary>
        string PathToUnInstaller { get; set; }
        /// <summary>
        /// Атрибуты установщика
        /// </summary>
        string AttributeInsteller { get; set; }

    }
}
