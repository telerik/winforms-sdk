using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ThemeLoader
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int StartTime = System.Environment.TickCount;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            form.Shown +=
                delegate
                {
                    MessageBox.Show((System.Environment.TickCount - StartTime).ToString());
                    //Application.Exit();
                };
            Application.Run(form);
        }
    }
}