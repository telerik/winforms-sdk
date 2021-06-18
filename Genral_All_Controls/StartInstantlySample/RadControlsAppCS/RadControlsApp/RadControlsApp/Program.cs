using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;

namespace RadControlsApp
{
    static class Program
    {
        private static string requiredString;

        internal static class NativeMethods
        {
            [DllImport("user32.dll")]
            public static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

            [DllImport("user32.dll")]
            public static extern bool SetForegroundWindow(IntPtr hWnd);

            [DllImport("user32.dll")]
            public static extern bool EnumWindows(EnumWindowsProcDel lpEnumFunc,
                Int32 lParam);

            [DllImport("user32.dll")]
            public static extern int GetWindowThreadProcessId(IntPtr hWnd,
                ref Int32 lpdwProcessId);

            [DllImport("user32.dll")]
            public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString,
                Int32 nMaxCount);

            public const int SW_SHOWNORMAL = 1;
        }

        public delegate bool EnumWindowsProcDel(IntPtr hWnd, Int32 lParam);

        static private bool EnumWindowsProc(IntPtr hWnd, Int32 lParam)
        {
            int processId = 0;
            NativeMethods.GetWindowThreadProcessId(hWnd, ref processId);

            StringBuilder caption = new StringBuilder(1024);
            NativeMethods.GetWindowText(hWnd, caption, 1024);

            // Use IndexOf to make sure our required string is in the title.
            if (processId == lParam && (caption.ToString().IndexOf(requiredString,
                StringComparison.OrdinalIgnoreCase) != -1))
            {
                // Restore the window.
                NativeMethods.ShowWindowAsync(hWnd, NativeMethods.SW_SHOWNORMAL);
                NativeMethods.SetForegroundWindow(hWnd);
            }
            return true;
        }

        static public bool IsOnlyProcess(string forceTitle)
        {
            requiredString = forceTitle;
            foreach (Process proc in Process.GetProcessesByName(Application.ProductName))
            {
                if (proc.Id != Process.GetCurrentProcess().Id)
                {
                    NativeMethods.EnumWindows(new EnumWindowsProcDel(EnumWindowsProc),
                        proc.Id);
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (IsOnlyProcess("SingleInstanceDemo"))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
