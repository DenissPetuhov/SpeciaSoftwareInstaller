using DomainInstaller.ResponseObserverInteface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СommonService.ResponseObserverService
{
    public class StackInstallResponseState : IStackInstallResponseState
    {
        private List<ProcessStartInfo> processInfoList = new List<ProcessStartInfo>();
        private List<StateResponseCode> ResposneCodes = new List<StateResponseCode>();
        private StateResponseCode responseCode = StateResponseCode.SUCCESS;
        private string stringReposne = "";
        private string nameResponseProcess = "";

        /// <summary>
        /// Список информации о всех процессов.
        /// </summary>
        public List<ProcessStartInfo> ProcessInfoList { get => processInfoList; set { processInfoList = value; } }
        /// <summary>
        /// Список всех кодов
        /// </summary>
        public List<StateResponseCode> ResponseCodes { get => ResposneCodes; set { ResposneCodes = value; } }
        /// <summary>
        /// Итоговый код ответа
        /// </summary>
        public StateResponseCode ResponseCode { get => responseCode; set { responseCode = value; } }
        /// <summary>
        /// Итоговая строка вывода
        /// </summary>
        public string StringReposne { get => stringReposne; set { stringReposne = value; } }
        /// <summary>
        /// Иогове имя процесса
        /// </summary>
        public string NameResponseProcess { get => nameResponseProcess; set => nameResponseProcess = value; }
        public List<IProcessResponseState> ResponseStates { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
