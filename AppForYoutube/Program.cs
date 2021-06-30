using System.Threading.Tasks;

namespace AppForYoutube
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var youtube = new YoutubeService();
            var user = new User();

            user.SetCommand(new GetVideoInfoCommand(youtube));
            await user.Run();

            user.SetCommand(new DownloadVideoCommand(youtube));
            await user.Run();
        }
    }
}
