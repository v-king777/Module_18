using System.Threading.Tasks;

namespace AppForYoutube
{
    /// <summary>
    /// Отправитель команды
    /// </summary>
    class User
    {
        ICommand command;

        /// <summary>
        /// Выбор команды
        /// </summary>
        /// <param name="command"></param>
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        /// <summary>
        /// Запуск команды
        /// </summary>
        /// <returns></returns>
        public async Task Run()
        {
            if (command != null)
            {
                await command.Execute();
            }
        }
    }
}
