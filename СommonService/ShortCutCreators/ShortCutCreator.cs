using DomainInstaller.BaseInterface.Repository;
using DomainInstaller.ResponseObserverInteface;
using DomainInstaller.ResponseObserverInteface.Repository;
using IWshRuntimeLibrary;
using SpeciaSoftwareInstaller.Resources;
using СommonService.ResponseObserverService;

namespace СommonService.ShortCutCreators
{
    public static class ShortCutCreator
    {
        /// <summary>
        /// Создает ярлык.
        /// </summary>
        /// <param name="targetPath"> Путь до цели.</param>
        /// <param name="shortcutPath"> Путь где расположить ярлык</param>
        public static IResponseState CreateShortcut(string targetPath, string shortcutPath)
        {
            try
            {
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = targetPath;
                shortcut.Save();
                return new ResponseState()
                {
                    ResponseCode = StateResponseCode.SUCCESS,
                    StringReposne = "Ярлык созданн по пути" + shortcutPath
                };
            }
            catch (Exception ex)
            {
                return new ResponseState()
                {
                    ResponseCode = StateResponseCode.ERROR,
                    StringReposne = ex.Message
                };
            }
        }
        /// <summary>
        /// Создает ярлык на рабочем столе
        /// </summary>
        /// <param name="targetPath">Путь до цели</param>
        public static IResponseState CreateShortcut(string targetPath)
        {
            try
            {
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(StaticPath.PublicDesktopDir);
                shortcut.TargetPath = targetPath;
                shortcut.Save();
                return new ResponseState()
                {
                    ResponseCode = StateResponseCode.SUCCESS,
                    StringReposne = "Ярлык созданн на рабочем столе"
                };
            }
            catch (Exception ex)
            {
                return new ResponseState()
                {
                    ResponseCode = StateResponseCode.ERROR,
                    StringReposne = ex.Message
                };
            }

        }
        /// <summary>
        /// Создает ярлык.
        /// </summary>
        /// <param name="CreatorSetting">Настрйки создателя ярлыков</param>
        public static IResponseState CreateShortcut(IShortCutSetting CreatorSetting)
        {
            try
            {
                WshShell shell = new WshShell();
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(CreatorSetting.ShortcutPath);
                shortcut.TargetPath = CreatorSetting.TargetPath;
                shortcut.Save();
                return new ResponseState()
                {
                    ResponseCode = StateResponseCode.SUCCESS,
                    StringReposne = "Ярлык созданн по пути" + CreatorSetting.ShortcutPath
                };
            }
            catch (Exception ex)
            {
                return new ResponseState()
                {
                    ResponseCode = StateResponseCode.ERROR,
                    StringReposne = ex.Message
                };
            }
        }
        /// <summary>
        /// Создает сразу несколько ярлыков.
        /// </summary>
        /// <param name="CreatorSettings">Списко настроек для создание ярлыков</param>
        /// <returns></returns>
        public static IMassResponseState CreateShortcuts(List<IShortCutSetting> CreatorSettings)
        {
            IMassResponseState response = new MassResponseState();
            try
            {
                response.ResponseCode = StateResponseCode.SUCCESS;
                response.StringReposne = "Ярлыки созданны.";
                // Добавить механизм записи лога.
                if (CreatorSettings.Count < 1) return new MassResponseState()
                {
                    ResponseCode = StateResponseCode.ERROR,
                    StringReposne = "Ошибка, настроки не найденны"
                };

                foreach (IShortCutSetting shortCutSetting in CreatorSettings)
                {
                    IResponseState createResponse = CreateShortcut(shortCutSetting);
                    //response.StringReponses.Add(createResponse.StringReposne);
                    //response.ResponseStates.Add(createResponse.ResponseCode);
                    if (createResponse.ResponseCode != StateResponseCode.SUCCESS)
                    {
                        response.ResponseCode = StateResponseCode.ERROR;
                        response.StringReposne = "Обнаруженны ошибки, подробнее смотри лог.";
                    }
                }
                return response;
            }
            catch (Exception ex)
            {

                return new MassResponseState()
                {
                    ResponseCode = StateResponseCode.ERROR,
                    StringReposne = ex.Message
                };

            }
        }
    }
}
