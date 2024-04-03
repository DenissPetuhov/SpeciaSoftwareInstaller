using DomainInstaller.BaseInterface.Repository;

namespace СommonService.ShortCutCreators
{
    public class ShortCutCreatorSetting : IShortCutSetting
    {
        private string shortcutPath;
        private string targetPath;
        public string TargetPath { get => targetPath; set { targetPath = value; } }
        public string ShortcutPath { get => shortcutPath; set { shortcutPath = value; } }
        public ShortCutCreatorSetting(string shortcutPath, string targetPath)
        {
            this.shortcutPath = shortcutPath;
            this.targetPath = targetPath; 
        }
    }
}
