using DomainInstaller.BaseInterface.IInsallersSettings;
using SpecialComponentInstaller.ComponentInstaller.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialComponentInstaller.ComponentInstaller
{
    internal class ZipComponentInstaller : AbstractZipComponentInstaller
    {
        public ZipComponentInstaller(IZipComponentInstallerSetting InstallerSetting) : base(InstallerSetting)
        {
        }
    }
}
