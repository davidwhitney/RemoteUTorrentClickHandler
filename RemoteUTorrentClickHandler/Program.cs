using System;
using System.Configuration;
using RemoteUTorrentClickHandler.Features;

namespace RemoteUTorrentClickHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                MagnetHandlerMapper.RegisterHandlerToExecutable(typeof(Program).Assembly.Location);
                return;
            }

            var apiPath = ConfigurationManager.AppSettings["utorrent:webUiPath"];
            var username = ConfigurationManager.AppSettings["utorrent:username"];
            var password = ConfigurationManager.AppSettings["utorrent:password"];

            var torrent = new UTorrentAPI.UTorrentClient(new Uri(apiPath), username, password);
            torrent.Torrents.AddUrl(args[0]);
        }
    }
}
