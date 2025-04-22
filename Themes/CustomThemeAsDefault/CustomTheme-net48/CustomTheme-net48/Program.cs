using System;
using System.Linq;
using System.Windows.Forms;

namespace CustomTheme_net48
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            new Windows11LightBlueClassLibrary.Windows11LightBlue();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RadForm1());
        }
    }
}