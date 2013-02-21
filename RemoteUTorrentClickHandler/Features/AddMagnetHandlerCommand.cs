﻿using Microsoft.Win32;

namespace RemoteUTorrentClickHandler.Features
{
    class AddMagnetHandlerCommand
    {
        public void Exeute()
        {
            var regKey = Registry.CurrentUser.OpenSubKey("Software\\Classes", true);

            var magnetRoot = regKey.CreateSubKey(@"Magnet");
            magnetRoot.SetValue(string.Empty, "Magnet URI");
            magnetRoot.SetValue("Content Type", "application/x-magnet");
            magnetRoot.SetValue("URL Protocol", string.Empty);
            magnetRoot.CreateSubKey(@"DefaultIcon").SetValue(string.Empty, "c:\\path\\to\\ico.ico");
            magnetRoot.CreateSubKey(@"shell").SetValue(string.Empty, "open");
            magnetRoot.CreateSubKey(@"shell\\open\\command").SetValue(string.Empty, "C:\\Program Files (x86)\\uTorrent\\uTorrent.exe\" \"%1\"");
        }
    }
}
