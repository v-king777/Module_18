using System.Threading.Tasks;

namespace AppForYoutube
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var youtube = new YoutubeService(); // Создаём получателя команды
            var user = new User(); // Создаём отправителя команды

            user.SetCommand(new GetVideoInfoCommand(youtube)); // Выбор команды
            await user.Run(); // Запуск команды

            user.SetCommand(new DownloadVideoCommand(youtube)); // Выбор команды
            await user.Run(); // Запуск команды
        }
    }
}
