using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.Threading;

namespace IndicatingOperations
{
public partial class WaitingForm : Form
{
    private static Thread waitingThread;
    private static WaitingForm waitingForm;

    public WaitingForm()
    {
        InitializeComponent();

        MainForm f = Program.MForm;

        int startX = (f.Width - this.ClientSize.Width) / 2;
        int startY = (f.Height - this.ClientSize.Height) / 2;
        this.Location = new System.Drawing.Point(f.Location.X + startX, f.Location.Y + startY);
        this.Location = new System.Drawing.Point(f.Location.X + startX, f.Location.Y + startY);

        this.radWaitingBar1.StartWaiting();
    }

    public static void ShowForm()
    {
        waitingThread = new Thread(new ParameterizedThreadStart(ThreadTask));
        waitingThread.IsBackground = false;
        waitingThread.Start();
    }

    private static void ThreadTask(object owner)
    {
        waitingForm = new WaitingForm();
        waitingForm.ShowInTaskbar = false;
        waitingForm.Owner = (Form)owner;
        waitingForm.FormBorderStyle = FormBorderStyle.None;
        waitingForm.ControlBox = false;
        waitingForm.TopMost = true;
        waitingForm.StartPosition = FormStartPosition.Manual;

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
