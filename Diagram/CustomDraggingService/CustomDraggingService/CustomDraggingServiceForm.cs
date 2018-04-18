using Telerik.Windows.Diagrams.Core;

namespace CustomDraggingService
{
    #region InitialSetup
    public partial class CustomDraggingServiceForm : Telerik.WinControls.UI.RadForm
    {
        private CustomDraggingService dragService;

        public CustomDraggingServiceForm()
        {
            InitializeComponent();

            this.dragService = new CustomDraggingService(this.radDiagram1.DiagramElement)
            {
                DragMode = DragMode.Horizontal
            };

            this.radDiagram1.DiagramElement.ServiceLocator.Register<IDraggingService>(this.dragService);
        }

        private void radButton1_Click(object sender, System.EventArgs e)
        {
            this.dragService.DragMode = this.dragService.DragMode == DragMode.Horizontal ? DragMode.Vertical : DragMode.Horizontal;
        }
    }
    #endregion
}
