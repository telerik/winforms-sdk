using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace IndicatingOperations
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);   
        
            f = new MainForm();
            Application.Run(f);
        }

        static MainForm f;

        public static MainForm MForm
        {
            get
            {
                return f;
            }
        }
    }
}
