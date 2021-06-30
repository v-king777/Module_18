using System.Threading.Tasks;

namespace AppForYoutube
{
    /// <summary>
    /// Команда "Скачать видео"
    /// </summary>
    class DownloadVideoCommand : ICommand
    {
        YoutubeService youtube;

        public DownloadVideoCommand(YoutubeService youtube)
        {
            this.youtube = youtube;
        }

        public async Task Execute()
        {
            await youtube.DownloadVideo();
        }
    }
}
