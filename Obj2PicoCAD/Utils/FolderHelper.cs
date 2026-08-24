using System;
using System.IO;
using System.Runtime.InteropServices;
using SHDocVw; // Requires Microsoft Internet Controls









namespace Obj2PicoCAD.Utils
{
    public static class FolderHelper
    {
        [DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool IsIconic(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        private const int SW_RESTORE = 9;


        //' Source - https://stackoverflow.com/a/68497544
        //' Posted by Giorgos Xou
        //' Retrieved 2026-08-24, License - CC BY-SA 4.0
        //' Source - https://stackoverflow.com/a/20961047
        //' Posted by Luc Morin, modified by community. See post 'Timeline' for change history
        //' Retrieved 2026-08-24, License - CC BY-SA 4.0
        /// <summary>
        /// Checks if a folder path is open in Windows Explorer. If open, focuses that window.
        /// </summary>
        public static bool FocusIfFolderOpen(string targetDirectoryPath)
        {
            if (string.IsNullOrWhiteSpace(targetDirectoryPath))
                return false;

            string normalizedTarget = Path.GetFullPath(targetDirectoryPath).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

            var shellWindows = new ShellWindows();

            foreach (InternetExplorer window in shellWindows)
            {
                string processName = Path.GetFileNameWithoutExtension(window.FullName);

                if (processName.Equals("explorer", StringComparison.OrdinalIgnoreCase))
                {
                    string locationUrl = window.LocationURL;

                    if (!string.IsNullOrEmpty(locationUrl))
                    {
                        try
                        {
                            var uri = new Uri(locationUrl);
                            string openFolderPath = Path.GetFullPath(uri.LocalPath).TrimEnd(Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar);

                            if (normalizedTarget.Equals(openFolderPath, StringComparison.OrdinalIgnoreCase))
                            {
                                IntPtr hwnd = (IntPtr)window.HWND;
                                if (IsIconic(hwnd))
                                {
                                    ShowWindow(hwnd, SW_RESTORE);
                                }
                                SetForegroundWindow(hwnd);
                                return true;
                            }
                        }
                        catch (Exception)
                        {
                            continue;
                        }
                    }
                }
            }

            return false;
        }
    }
}