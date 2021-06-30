using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace AppForYoutube
{
    /// <summary>
    /// Получатель команды
    /// </summary>
    class YoutubeService
    {
        YoutubeClient client;

        public YoutubeService()
        {
            client = new YoutubeClient();
        }

        /// <summary>
        /// Получить информацию о видео
        /// </summary>
        /// <returns></returns>
        public async Task GetVideoInfo()
        {
            var video = await client.Videos.GetAsync(VideoUrl.Url);

            Console.WriteLine($"Название: {video.Title}\n");
            Console.WriteLine($"Автор: {video.Author}\n");
            Console.WriteLine($"Продолжительность: {video.Duration}\n");
            Console.WriteLine($"Дата загрузки: {video.UploadDate}\n");
            Console.WriteLine($"Описание: {video.Description}\n");
        }

        /// <summary>
        /// Скачать видео
        /// </summary>
        /// <returns></returns>
        public async Task DownloadVideo()
        {
            Console.WriteLine("Скачиваем видео...\n");

            await client.Videos.DownloadAsync(
                VideoUrl.Url,
                "video.mp4",
                builder => builder.SetPreset(ConversionPreset.UltraFast));

            Console.WriteLine("Загрузка завершена!");
        }
    }
}
