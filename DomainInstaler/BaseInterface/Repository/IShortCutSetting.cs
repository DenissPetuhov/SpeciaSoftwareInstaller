using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainInstaller.BaseInterface.Repository
{
    /// <summary>
    /// Настройки создателя ярлыков
    /// </summary>
    public interface IShortCutSetting
    {
        /// <summary>
        /// Путь до цели.
        /// </summary>
        public string TargetPath { get; set; }
        /// <summary>
        /// Путь расположения ярлыка
        /// </summary>
        public string ShortcutPath { get; set; }
    }
}
