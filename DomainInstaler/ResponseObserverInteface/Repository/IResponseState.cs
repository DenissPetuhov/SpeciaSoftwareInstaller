using СommonService;

namespace DomainInstaller.ResponseObserverInteface.Repository
{
    /// <summary>
    /// Базовый ответ на  процесс
    /// </summary>
    public interface IResponseState
    {
        /// <summary>
        /// Имя процесса ответа
        /// </summary>
        string NameResponseProcess { get; set; }
        /// <summary>
        /// Код состояния процесса
        /// </summary>
        StateResponseCode ResponseCode { get; set; }
        /// <summary>
        /// Строка ответа.
        /// </summary>
        string StringReposne { get; set; }
    }
}
