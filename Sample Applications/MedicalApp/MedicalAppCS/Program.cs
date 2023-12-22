using System;
using System.Windows.Forms;

namespace MedicalAppCS
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

            //we need this to load the needed references from other directory (for the standalone QSF)
            AppDomain.CurrentDomain.AssemblyResolve += MyResolveEventHandler;

            //run the manually created instance. This is needed as otherwise the static types of the assemblies will be needed prior we get here
            Form m = Activator.CreateInstance(System.Reflection.Assembly.GetExecutingAssembly().GetType("MedicalAppCS.MainForm")) as Form;
            Application.Run(m);
        }

        private static System.Reflection.Assembly MyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            string strTempAssmbPath = "";
            string neededAssembly = args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll";
            System.Reflection.Assembly objExecutingAssemblies = System.Reflection.Assembly.GetExecutingAssembly();

            foreach (System.Reflection.AssemblyName strAssmbName in objExecutingAssemblies.GetReferencedAssemblies())
            {
                string currentAssembly = strAssmbName.FullName.Substring(0, strAssmbName.FullName.IndexOf(",")) + ".dll";

                if (currentAssembly == neededAssembly)
                {
                    strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), args.Name.Substring(0, args.Name.IndexOf(",")) + ".dll");

                    if (!System.IO.File.Exists(strTempAssmbPath)) // we are in the case of QSF as exe, so the Path is different
                    {
                        strTempAssmbPath = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "..\\..\\..\\..\\bin\\ReleaseTrial");
                        strTempAssmbPath = System.IO.Path.Combine(strTempAssmbPath, neededAssembly);
                    }
                    break;
                }
            }

            System.Reflection.Assembly myAssembly = null;

            if (!string.IsNullOrEmpty(strTempAssmbPath))
            {
                myAssembly = System.Reflection.Assembly.LoadFrom(strTempAssmbPath);
            }
            return myAssembly;
        }
    }
}
