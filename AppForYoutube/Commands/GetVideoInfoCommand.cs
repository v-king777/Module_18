using System.Threading.Tasks;

namespace AppForYoutube
{
    /// <summary>
    /// Команда "Получить информацию о видео"
    /// </summary>
    class GetVideoInfoCommand : ICommand
    {
        YoutubeService youtube;

        public GetVideoInfoCommand(YoutubeService youtube)
        {
            this.youtube = youtube;
        }

        public async Task Execute()
        {
            await youtube.GetVideoInfo();
        }
    }
}
