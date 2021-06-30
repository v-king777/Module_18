using System.Threading.Tasks;

namespace AppForYoutube
{
    /// <summary>
    /// Общий интерфейс команды
    /// </summary>
    interface ICommand
    {
        /// <summary>
        /// Выполнить
        /// </summary>
        /// <returns></returns>
        Task Execute();
    }
}
