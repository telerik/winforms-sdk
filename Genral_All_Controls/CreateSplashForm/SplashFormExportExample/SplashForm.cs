using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace SplashFormExportExample
{

    public partial class SplashForm : Form
    {
        private static Thread waitingThread;
        private static SplashForm waitingForm;

        public SplashForm()
        {
            InitializeComponent();
        }

        public static void ShowForm(Form owner)
        {

            waitingThread = new Thread(new ParameterizedThreadStart(ThreadTask));
            waitingThread.IsBackground = false;
            Rectangle rect = new Rectangle(owner.DesktopLocation, owner.Size);
            waitingThread.Start(new { OwnerRect = rect });
        }

        private static void ThreadTask(object info)
        {
            //initialize the form
            waitingForm = new SplashForm();
            waitingForm.ShowInTaskbar = false;
            Rectangle or = (Rectangle)info.GetType().GetProperty("OwnerRect").GetValue(info);
            Point location = new Point(or.X + (or.Width - waitingForm.Width) / 2, or.Y + (or.Height - waitingForm.Height) / 2);
            waitingForm.Location = location;
            waitingForm.FormBorderStyle = FormBorderStyle.None;
            waitingForm.ControlBox = false;
            waitingForm.TopMost = true;
            waitingForm.StartPosition = FormStartPosition.Manual;

            RadProgressBar pb = waitingForm.Controls[0] as RadProgressBar;
            RadWaitingBar wb = new RadWaitingBar();
            wb.Size = pb.Size;
            wb.Location = pb.Location;

            waitingForm.Controls.Remove(pb);
            waitingForm.Controls.Add(wb);

            wb.StartWaiting();


            Application.Run(waitingForm);
        }

        public static void CloseDialogDown()
        {
            Application.ExitThread();
        }

        public static void CloseForm()
        {
            while (waitingForm == null || !waitingForm.IsHandleCreated)
            {
                Thread.Sleep(10);
            }
            MethodInvoker mi = new MethodInvoker(CloseDialogDown);
            waitingForm.Invoke(mi);
        }

    }
}
