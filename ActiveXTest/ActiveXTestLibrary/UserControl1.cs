using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Reflection;

namespace ActiveXTestLibrary
{
    [ProgId("ActiveXTestLibrary.UserControl")]
    [ClassInterface(ClassInterfaceType.AutoDispatch)]
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            this.radLabel1.Text = "I am a .NET user control happily living \ninside an ActiveX container. Cheers.";
        }

        [ComRegisterFunction()]
        public static void RegisterClass(string key)
        {
            StringBuilder sb = new StringBuilder(key);
            sb.Replace(@"HKEY_CLASSES_ROOT\", "");

            RegistryKey k = Registry.ClassesRoot.OpenSubKey(sb.ToString(), true);

            RegistryKey ctrl = k.CreateSubKey("Control");
            ctrl.Close();

            RegistryKey inprocServer32 = k.OpenSubKey("InprocServer32", true);
            inprocServer32.SetValue("CodeBase", Assembly.GetExecutingAssembly().CodeBase);
            inprocServer32.Close();

            k.Close();
        }

        [ComUnregisterFunction()]
        public static void UnregisterClass(string key)
        {
            StringBuilder sb = new StringBuilder(key);
            sb.Replace(@"HKEY_CLASSES_ROOT\", "");

            RegistryKey k = Registry.ClassesRoot.OpenSubKey(sb.ToString(), true);

            if (k == null)
            {
                return;
            }
            k.DeleteSubKey("Control", false);

            RegistryKey inprocServer32 = k.OpenSubKey("InprocServer32", true);

            inprocServer32.DeleteSubKey("CodeBase", false);

            inprocServer32.Close();
        }
    }
}