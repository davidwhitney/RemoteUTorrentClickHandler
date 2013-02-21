using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoteUTorrentClickHandler.Features;

namespace RemoteUTorrentClickHandler
{
    class Program
    {
        static void Main(string[] args)
        {
            var aa = new AddMagnetHandlerCommand();
            aa.Exeute();
        }
    }
}
