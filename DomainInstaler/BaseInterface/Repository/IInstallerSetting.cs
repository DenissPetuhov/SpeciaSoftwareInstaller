using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainInstaller.BaseInterface.Repository
{
    /// <summary>
    /// Интерфейс настроек установщика
    /// </summary>
    public interface IInstallerSetting
    {
        /// <summary>
        /// Путь установки 
        /// </summary>
        public string InstallationPath { get; set; }
        /// <summary>
        /// Название установщика
        /// </summary>
        string InstallName { get; set; }
        /// <summary>
        /// Описание установщика
        /// </summary>
        string Discription { get; set; }

    }
}
